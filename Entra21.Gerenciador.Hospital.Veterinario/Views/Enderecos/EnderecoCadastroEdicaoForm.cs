using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;
using Newtonsoft.Json;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Enderecos
{
    public partial class EnderecoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public EnderecoCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxResponsavel();

            _idParaEditar = -1;
        }

        public EnderecoCadastroEdicaoForm(Endereco endereco) : this()
        {
            _idParaEditar = endereco.Id;

            maskedTextBoxCep.Text = endereco.Cep;
            textBoxLogradouro.Text = endereco.Logradouro;
            textBoxBairro.Text = endereco.Bairro;
            textBoxCidade.Text = endereco.Localidade;
            maskedTextBoxUnidadeFederativa.Text = endereco.Uf;

            for (int i = 0; i < comboBoxResponsavel.Items.Count; i++)
            {
                var responsavelPercorrido = comboBoxResponsavel.Items[i] as
                    Responsavel;

                if (responsavelPercorrido.Id == endereco.Responsavel.Id)
                {
                    comboBoxResponsavel.SelectedItem = responsavelPercorrido;
                    break;
                }
            }
        }
        
        private void PreencherComboBoxResponsavel()
        {
            var responsavelService = new ResponsavelService();
            var responsaveis = responsavelService.ObterTodos();

            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];
                comboBoxResponsavel.Items.Add(responsavel);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBoxCep.Text == string.Empty)
                {
                    MessageBox.Show("O CEP deve ser informado!", "ERRO", MessageBoxButtons.OK);

                    maskedTextBoxCep.Focus();
                    return;
                }

                if (comboBoxResponsavel.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um(a) Responsável!", "ERRO", MessageBoxButtons.OK);
                    comboBoxResponsavel.DroppedDown = true;
                    return;
                }

                var cep = maskedTextBoxCep.Text.Trim();
                var logradouro = textBoxLogradouro.Text.Trim();
                var bairro = textBoxBairro.Text.Trim();
                var cidade = textBoxCidade.Text.Trim();
                var unidadeFederativa = maskedTextBoxUnidadeFederativa.Text.Trim().ToUpper();
                var responsavel = comboBoxResponsavel.SelectedItem as Responsavel;

                var endereco = new Endereco();
                endereco.Cep = cep;
                endereco.Logradouro = logradouro;
                endereco.Bairro = bairro;
                endereco.Localidade = cidade;
                endereco.Uf = unidadeFederativa;
                endereco.Responsavel = responsavel;

                var enderecoSevice = new EnderecoService();
                if (_idParaEditar == -1)
                {
                    enderecoSevice.Cadastrar(endereco);
                    MessageBox.Show("Endereco cadastrado com sucesso", "Aviso", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    endereco.Id = _idParaEditar; ;
                    enderecoSevice.Editar(endereco);
                    MessageBox.Show("Endereco editado com sucesso", "Aviso", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algum dado esta inválido!", "ERRO", MessageBoxButtons.OK);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObterDadosCep()
        {
            var cep = maskedTextBoxCep.Text.Replace("-", "").Trim();

            if (cep.Length != 8)
            {
                return;
            }

            var httpClient = new HttpClient();

            var resultado = httpClient.GetAsync(
                $"https://viacep.com.br/ws/{cep}/json/").Result;

            if (resultado.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var resposta = resultado.Content.ReadAsStringAsync().Result;

                var dadosEndereco = JsonConvert.DeserializeObject<Endereco>(resposta);

                textBoxLogradouro.Text = $"{dadosEndereco.Logradouro}";
                textBoxBairro.Text = $"{dadosEndereco.Bairro}";
                textBoxCidade.Text = $"{dadosEndereco.Localidade}";
                maskedTextBoxUnidadeFederativa.Text = $"{dadosEndereco.Uf}";
            }

        }

        private void maskedTextBoxCep_Leave_1(object sender, EventArgs e)
        {
            ObterDadosCep();
        }
    }
}
