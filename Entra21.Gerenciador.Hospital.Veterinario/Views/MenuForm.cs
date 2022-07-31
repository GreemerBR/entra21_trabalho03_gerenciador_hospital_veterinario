using Entra21.Gerenciador.Hospital.Vet.Views.Consultas;
using Entra21.Gerenciador.Hospital.Vet.Views.Enderecos;
using Entra21.Gerenciador.Hospital.Vet.Views.Pets;
using Entra21.Gerenciador.Hospital.Vet.Views.Racas;
using Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios;

namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    public partial class MenuForm : Form
    {
        private Form frmAtivo;

        public MenuForm()
        {
            InitializeComponent();
        }
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelAbas.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
                ctrl.BackColor = Color.Navy;

            frmAtivo.BackColor = Color.Red;
        }

        private void buttonConsulta_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonConsulta);
            FormShow(new ConsultaListagemForm());
        }

        private void buttonRaca_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonRaca);
            FormShow(new RacaListagemForm());
        }

        private void buttonEndereco_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonEndereco);
            FormShow(new EnderecoListagemForm());
        }

        private void buttonResponsavel_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonResponsavel);
            FormShow(new ResponsavelListagemForm());
        }

        private void buttonPet_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonPet);
            FormShow(new PetListagemForm());
        }

        private void buttonVeterinario_Click_1(object sender, EventArgs e)
        {
            ActiveButton(buttonVeterinario);
            FormShow(new VeterinarioListagemForm());
        }
    }
}
