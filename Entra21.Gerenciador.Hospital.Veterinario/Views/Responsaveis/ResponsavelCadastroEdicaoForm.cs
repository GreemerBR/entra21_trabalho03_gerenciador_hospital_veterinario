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

            textBoxIdade.Text = responsavel.Idade.ToString();

            maskedTextBoxCpf.Text = responsavel.Cpf;

            maskedTextBoxTelefone.Text = responsavel.Telefone;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var idade = Convert.ToInt32(textBoxIdade.Text.Trim());
            var cpf = maskedTextBoxCpf.Text;
            var telefone = maskedTextBoxTelefone.Text;

            var responsavel = new Responsavel();
            responsavel.Nome = nome;
            responsavel.Idade = idade;
            responsavel.Cpf = cpf;
            responsavel.Telefone = telefone;

            var responsavelService = new ResponsavelService();

            if(_idParaEditar == -1)
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
