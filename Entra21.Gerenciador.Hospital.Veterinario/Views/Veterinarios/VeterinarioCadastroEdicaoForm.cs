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
            if (CamposValidos() == false)
            {
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var crmvEstado = textBoxCrmvUF.Text.Trim().ToUpper();
            var especialidade = textBoxEspecialidade.Text.Trim();
            var cpf = maskedTextBoxCpf.Text;
            var telefone = maskedTextBoxTelefone.Text;
            var crvmNumero = Convert.ToInt32(maskedTextBoxCrvmNumero.Text);
            var idade = Convert.ToInt32(maskedTextBoxIdade.Text);

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

                MessageBox.Show("Veterinário(a) cadastrado(a) com sucesso!", "Aviso", MessageBoxButtons.OK);
                Close();

                return;
            }
            else
            {
                veterinario.Id = _idParaEditar;
                veterinarioService.Editar(veterinario);

                MessageBox.Show("Cadastro do(a) veterinário(a) editado(a) com sucesso!", "Aviso", MessageBoxButtons.OK);
                Close();
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
                MessageBox.Show("O nome do(a) veterinário(a) precisa ter ao menos 6 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            if (maskedTextBoxTelefone.Text == string.Empty)
            {
                MessageBox.Show("O número de telefone do(a) Veterinário(a) deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxTelefone.Focus();

                return false;
            }

            if (maskedTextBoxCrvmNumero.Text == string.Empty)
            {
                MessageBox.Show("O número do CRMV do(a) Veterinário(a) deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxCrvmNumero.Focus();

                return false;
            }

            if (textBoxCrmvUF.Text.Trim().ToUpper().Length != 2)
            {
                MessageBox.Show("A unidade federativa (UF) do CRMV do(a) Veterinário(a) deve ter 2 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxCrmvUF.Focus();

                return false;
            }

            if (maskedTextBoxCpf.Text == string.Empty)
            {
                MessageBox.Show("O CPF do(a) Veterinário(a) deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxCpf.Focus();

                return false;
            }

            if (maskedTextBoxIdade.Text == string.Empty)
            {
                MessageBox.Show("A idade do(a) Veterinário(a) deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxIdade.Focus();

                return false;
            }

            if (textBoxEspecialidade.Text.Trim().Length > 200)
            {
                MessageBox.Show("O campo especialidades do(a) Veterinário(a) deve conter com no máximo 200 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxEspecialidade.Focus();

                return false;
            }

            return true;
        }
    }
}
