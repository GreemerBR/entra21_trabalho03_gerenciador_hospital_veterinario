using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios
{
    public partial class VeterinarioCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public VeterinarioCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public VeterinarioCadastroEdicaoForm(Veterinario veterinario) : this()
        {
            _idParaEditar = veterinario.Id;

            textBoxNome.Text = veterinario.Nome;

            maskedTextBoxTelefone.Text = veterinario.Telefone.ToString();

            maskedTextBoxCrvmNumero.Text = veterinario.CrmvNumero.ToString();

            textBoxCrmvUF.Text = veterinario.CrmvEstado;

            maskedTextBoxCpf.Text = veterinario.Cpf;

            maskedTextBoxIdade.Text = veterinario.Idade.ToString();

            textBoxEspecialidade.Text = veterinario.Especialidade;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            String nome = textBoxNome.Text.Trim();
            //try
            //{
            //    if (nome.Length >= 6)
            //        return;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("O nome do(a) veterinário(a) precisa ter ao menos 6 caracteres", "Aviso", MessageBoxButtons.OK);

            //    textBoxNome.Focus();

            //    return;
            //}

            String crmvEstado = textBoxCrmvUF.Text.Trim().ToUpper();
            //try
            //{
            //    if (crmvEstado.Length == 2)
            //        return;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("A unidade federativa (UF) deve ter 2 caracteres", "Aviso", MessageBoxButtons.OK);

            //    textBoxCrmvUF.Focus();

            //    return;
            //}

            String especialidade = textBoxEspecialidade.Text.Trim();
            //try
            //{
            //    if (crmvEstado.Length > 200)
            //        return;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("O campo especialidades deve conter no máximo 200 caracteres", "Aviso", MessageBoxButtons.OK);

            //    textBoxNome.Focus();

            //    return;
            //}

            string cpf = maskedTextBoxCpf.Text;
            string telefone = maskedTextBoxTelefone.Text;
            int crvmNumero = Convert.ToInt32(maskedTextBoxCrvmNumero.Text);
            int idade = Convert.ToInt32(maskedTextBoxIdade.Text);

            var veterinario = new Veterinario();
            veterinario.Nome = nome;
            veterinario.Idade = idade;
            veterinario.Telefone = telefone;
            veterinario.Cpf = cpf;
            veterinario.Especialidade = especialidade;
            veterinario.CrmvNumero = crvmNumero;
            veterinario.CrmvEstado = crmvEstado;

            var veterinarioService = new VeterinarioService();

            if (_idParaEditar == -1)
            {
                veterinarioService.Cadastrar(veterinario);

                MessageBox.Show("Veterinário(a) cadastrado(a) com sucesso");
                Close();

                return;
            }
            else
            {
                veterinario.Id = _idParaEditar;
                veterinarioService.Editar(veterinario);

                MessageBox.Show("Cadastro do(a) veterinário(a) editado(a) com sucesso");
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
