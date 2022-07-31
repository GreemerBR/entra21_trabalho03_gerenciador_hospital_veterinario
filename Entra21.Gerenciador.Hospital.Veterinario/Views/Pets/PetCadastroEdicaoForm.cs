using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Pets
{
    public partial class PetCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public PetCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxResponsavel();

            PreencherComboBoxRaca();

            _idParaEditar = -1;
        }
        public PetCadastroEdicaoForm(Pet pet) : this()
        {
            _idParaEditar = pet.Id;

            textBoxNome.Text = pet.Nome;

            maskedTextBoxPeso.Text = pet.Peso.ToString();

            maskedTextBoxIdade.Text = pet.Idade.ToString();

            maskedTextBoxAltura.Text = pet.Altura.ToString();

            groupBoxGenero.Text = pet.Genero.ToString();

            for (int i = 0; i < comboBoxResponsavel.Items.Count; i++)
            {
                var responsavelPercorrido = comboBoxResponsavel.Items[i] as
                    Responsavel;

                if (responsavelPercorrido.Id == pet.Responsavel.Id)
                {
                    comboBoxResponsavel.SelectedItem = responsavelPercorrido;
                    break;
                }
            }
            for (int i = 0; i < comboBoxRaca.Items.Count; i++)
            {
                var racaPercorrido = comboBoxRaca.Items[i] as
                    Raca;

                if (racaPercorrido.Id == pet.Raca.Id)
                {
                    comboBoxRaca.SelectedItem = racaPercorrido;
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

        private void PreencherComboBoxRaca()
        {
            var racaService = new RacaService();
            var racas = racaService.ObterTodos();

            for (int i = 0; i < racas.Count; i++)
            {
                var raca = racas[i];
                comboBoxRaca.Items.Add(raca);
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == false)
            {
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var peso = Convert.ToDouble(maskedTextBoxPeso.Text);
            var idade = Convert.ToInt32(maskedTextBoxIdade.Text);
            var altura = Convert.ToDouble(maskedTextBoxAltura.Text);
            var raca = comboBoxRaca.SelectedItem as Raca;
            var responsavel = comboBoxResponsavel.SelectedItem as Responsavel;
            var genero= Convert.ToChar(groupBoxGenero.Text.Substring(0,1));
            
            var pet = new Pet();
            pet.Nome = nome;
            pet.Peso = peso;
            pet.Idade = idade;
            pet.Altura = altura;
            pet.Raca = raca;
            pet.Responsavel = responsavel;
            pet.Genero = genero;
            
            var petService = new PetService();

            if (_idParaEditar == -1)
            {
                petService.Cadastrar(pet);

                MessageBox.Show("Pet cadastrado com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();

                return;
            }
            else
            {
                pet.Id = _idParaEditar;
                petService.Editar(pet);

                MessageBox.Show("Cadastro do Pet editado com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();
            }

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CamposValidos()
        {
            if (textBoxNome.Text.Trim().Length < 2)
            {
                MessageBox.Show("O nome do Pet precisa ter ao menos 2 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }
            if (comboBoxRaca.Text.Trim().Length < 2)
            {
                MessageBox.Show("A função Raça deve ser selecionada!", "ERRO", MessageBoxButtons.OK);

                comboBoxRaca.Focus();

                return false;
            }

            if (maskedTextBoxPeso.Text == string.Empty)
            {
                MessageBox.Show("O peso do Pet deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxPeso.Focus();

                return false;
            }

            if (maskedTextBoxIdade.Text == string.Empty)
            {
                MessageBox.Show("A idade do Pet deve ser preenchida!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxIdade.Focus();

                return false;
            }

            if (maskedTextBoxAltura.Text == string.Empty)
            {
                MessageBox.Show("A Altura do Pet deve ser preenchida!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxAltura.Focus();

                return false;
            }

            return true;
        }
    }
    
}
