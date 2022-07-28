using Entra21.Gerenciador.Hospital.Vet.Views.Enderecos;
using Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios;

namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void buttonEndereco_Click(object sender, EventArgs e)
        {
            var enderecoForm = new EnderecoListagemForm();
            enderecoForm.ShowDialog();
        }

        private void buttonResponsavel_Click(object sender, EventArgs e)
        {
            var responsavelForm = new ResponsavelListagemForm();
            responsavelForm.ShowDialog();
        }

        private void buttonVeterinario_Click(object sender, EventArgs e)
        {
            var veterinarioForm = new VeterinarioListagemForm();
            veterinarioForm.ShowDialog();
        }
    }
}
