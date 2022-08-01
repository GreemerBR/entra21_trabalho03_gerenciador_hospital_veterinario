using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    public partial class ResponsavelCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public ResponsavelCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public ResponsavelCadastroEdicaoForm(Responsavel responsavel) : this()
        {
            _idParaEditar = responsavel.Id;

            textBoxNome.Text = responsavel.Nome;

            maskedTextBoxIdade.Text = responsavel.Idade.ToString();

            maskedTextBoxCpf.Text = responsavel.Cpf;

            maskedTextBoxTelefone.Text = responsavel.Telefone;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposValidos() == false)
                {
                    return;
                }

                var nome = textBoxNome.Text.Trim();
                var idade = Convert.ToInt32(maskedTextBoxIdade.Text);
                var cpf = maskedTextBoxCpf.Text;
                var telefone = maskedTextBoxTelefone.Text;

                var responsavel = new Responsavel();
                responsavel.Nome = nome;
                responsavel.Idade = idade;
                responsavel.Cpf = cpf;
                responsavel.Telefone = telefone;

                var responsavelService = new ResponsavelService();

                if (_idParaEditar == -1)
                {
                    responsavelService.Cadastrar(responsavel);

                    MessageBox.Show("Responsável cadastrado(a) com sucesso!", "Aviso", MessageBoxButtons.OK);

                    Close();

                    return;
                }

                responsavel.Id = _idParaEditar;
                responsavelService.Editar(responsavel);

                MessageBox.Show("Cadastro do(a) responsável editado(a) com sucesso!", "Aviso", MessageBoxButtons.OK);

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Algum dado esta invalido!!!");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CamposValidos()
        {
            if (textBoxNome.Text.Trim().Length < 6)
            {
                MessageBox.Show("O nome do(a) responsável precisa ter ao menos 6 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            if (maskedTextBoxTelefone.Text == string.Empty)
            {
                MessageBox.Show("O número de telefone do(a) Responsável deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxTelefone.Focus();

                return false;
            }
            

            if (maskedTextBoxCpf.Text == string.Empty)
            {
                MessageBox.Show("O CPF do(a) Responsável deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxCpf.Focus();

                return false;
            }

            if (maskedTextBoxIdade.Text == string.Empty)
            {
                MessageBox.Show("A idade do(a) Responsável deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxIdade.Focus();

                return false;
            }            

            return true;
        }
    }
}
