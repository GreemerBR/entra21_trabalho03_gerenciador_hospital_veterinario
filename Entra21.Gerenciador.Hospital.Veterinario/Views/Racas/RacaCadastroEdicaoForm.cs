using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    public partial class RacaCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public RacaCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }
        public RacaCadastroEdicaoForm(Raca raca) : this()
        {
            _idParaEditar = raca.Id;

            textBoxNome.Text = raca.Nome;

            textBoxEspecie.Text = raca.Especie;

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == false)
            {
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var especie = textBoxEspecie.Text.Trim();

            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;
            

            var racaService = new RacaService();

            if (_idParaEditar == -1)
            {
                racaService.Cadastrar(raca);

                MessageBox.Show("Raça cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK);

                Close();

                return;
            }

            raca.Id = _idParaEditar;
            racaService.Editar(raca);

            MessageBox.Show("Raça alterado com sucesso!", "Aviso", MessageBoxButtons.OK);

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CamposValidos()
        {
            if (textBoxNome.Text.Trim().Length < 3)
            {
                MessageBox.Show("O nome da raça precisa ter ao menos 3 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            if (textBoxEspecie.Text.Trim().Length < 3)
            {
                MessageBox.Show("O nome da espécie precisa ter ao menos 3 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            return true;
        }

    }
}
