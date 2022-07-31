using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Consultas
{
    public partial class ConsultaCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public ConsultaCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxVeterinarios();

            PreencherComboBoxPets();

            _idParaEditar = -1;
        }

        private void ConsultaCadastroEdicaoForm_Load(object sender, EventArgs e)
        {
            //dateTimePickerHorario.CustomFormat = "HH:mm";
            //dateTimePickerHorario.Format = DateTimePickerFormat.Custom;

            dateTimePickerData.CustomFormat = "dd/MM/yyyy";
            dateTimePickerData.Format = DateTimePickerFormat.Custom;
        }

        public ConsultaCadastroEdicaoForm(Consulta consulta) : this()
        {
            _idParaEditar = consulta.Id;

            var data = consulta.DataHora.ToString("dd/MM/yyyy");
            dateTimePickerData.Text = data;

            var hora = consulta.DataHora.ToString("HH:mm");
            maskedTextBoxHorario.Text = hora;

            richTextBoxObbservacao.Text = consulta.Observacao;

            for (var i = 0; i < comboBoxVeterinario.Items.Count; i++)
            {
                var nomeVeterinario = comboBoxVeterinario.Items[i] as Veterinario;

                if (nomeVeterinario.Id == consulta.Veterinario.Id)
                {
                    comboBoxVeterinario.SelectedItem = nomeVeterinario;
                    break;
                }
            }

            for (var i = 0; i < comboBoxPet.Items.Count; i++)
            {
                var nomePet = comboBoxPet.Items[i] as Pet;

                if (nomePet.Id == consulta.Pet.Id)
                {
                    comboBoxPet.SelectedItem = nomePet;
                    break;
                }
            }
        }

        private void PreencherComboBoxVeterinarios()
        {
            var veterinarioService = new VeterinarioService();
            var veterinarios = veterinarioService.ObterTodos();

            for (int i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];
                comboBoxVeterinario.Items.Add(veterinario);
            }
        }

        private void PreencherComboBoxPets()
        {
            var petService = new PetService();
            var pets = petService.ObterTodos();

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];
                comboBoxPet.Items.Add(pet);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == false)
            {
                return;
            }

            var veterinario = comboBoxVeterinario.SelectedItem as Veterinario;
            var pet = comboBoxPet.SelectedItem as Pet;
            var data = Convert.ToDateTime(dateTimePickerData.Value.Date);
            var hora = Convert.ToDateTime(maskedTextBoxHorario.Text);
            var dataHora = data.Date + hora.TimeOfDay;
            var observacao = richTextBoxObbservacao.Text.Trim();

            var consulta = new Consulta();
            consulta.Veterinario = veterinario;
            consulta.Pet = pet;
            consulta.DataHora = dataHora;
            consulta.Observacao = observacao;

            var consultaService = new ConsultaService();

            if (_idParaEditar == -1)
            {
                consultaService.Cadastrar(consulta);

                MessageBox.Show("Consulta cadastrada com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();

                return;
            }
            else
            {
                consulta.Id = _idParaEditar;
                consultaService.Editar(consulta);

                MessageBox.Show("Consulta editada com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CamposValidos()
        {
            if (comboBoxVeterinario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um(a) Veterinário(a)!", "ERRO", MessageBoxButtons.OK);

                comboBoxVeterinario.DroppedDown = true;

                return false;
            }

            if (comboBoxPet.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um(a) Veterinário(a)!", "ERRO", MessageBoxButtons.OK);

                comboBoxPet.DroppedDown = true;

                return false;
            }

            if (dateTimePickerData.Text == string.Empty)
            {
                MessageBox.Show("A data da consulta deve ser informada!", "ERRO", MessageBoxButtons.OK);

                dateTimePickerData.Focus();

                return false;
            }

            if (maskedTextBoxHorario.Text == string.Empty)
            {
                MessageBox.Show("A hora da consulta deve ser informada!", "ERRO", MessageBoxButtons.OK);

                dateTimePickerData.Focus();

                return false;
            }

            return true;
        }
    }
}
