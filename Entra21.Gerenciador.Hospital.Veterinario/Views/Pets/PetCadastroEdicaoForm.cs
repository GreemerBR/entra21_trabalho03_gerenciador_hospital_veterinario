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

            textBoxPeso.Text = pet.Peso.ToString();

            textBoxIdade.Text = pet.Idade.ToString();

            textBoxAltura.Text = pet.Altura.ToString();

            if (pet.Genero.ToString() == "F")
            {
                radioButtonFenimino.Checked = true;
            }
            else
            {
                radioButtonMasculino.Checked = true;
            }

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
            var peso = Convert.ToDouble(textBoxPeso.Text.Trim().Replace(",","."));          
            var idade = Convert.ToInt32(textBoxIdade.Text.Trim());
            var altura = Convert.ToDouble(textBoxAltura.Text.Trim().Replace(",", "."));
            var raca = comboBoxRaca.SelectedItem as Raca;
            var responsavel = comboBoxResponsavel.SelectedItem as Responsavel;
            char genero;
            if (radioButtonFenimino.Checked == true)
            {
                genero = 'F';
            }
            else
            {
                genero = 'M';
            }            
            
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

            if (textBoxPeso.Text.Trim().Length <3)
            {
                MessageBox.Show("O peso do Pet deve ser informado com duas casas decimais", "ERRO", MessageBoxButtons.OK);

                textBoxPeso.Focus();

                return false;
            }

            if (textBoxIdade.Text.Trim().Length < 1)
            {
                MessageBox.Show("A idade do Pet deve ser informada em anos!", "ERRO", MessageBoxButtons.OK);

                textBoxIdade.Focus();

                return false;
            }

            if (textBoxAltura.Text.Trim().Length < 3)
            {
                MessageBox.Show("A Altura do Pet deve ser informado com duas casas decimais!", "ERRO", MessageBoxButtons.OK);

                textBoxAltura.Focus();

                return false;
            }

            for (var i = 0; i < textBoxPeso.Text.Length; i++)
            {
                var carater = textBoxPeso.Text.Substring(i, 1);

                if (carater != "0" && carater != "1" && carater != "2" && carater != "3" && carater != "4" && carater != "5" && carater != "6"
                    && carater != "7" && carater != "8" && carater != "9" && carater != "." && carater != ",")
                {
                    MessageBox.Show("O peso do Pet deve conter apenas números. Utilize vírgula para separar as casas decimais.", "ERRO", MessageBoxButtons.OK);

                    textBoxPeso.Focus();

                    return false;
                }
            }

            for (var i = 0; i < textBoxAltura.Text.Length; i++)
            {
                var carater = textBoxPeso.Text.Substring(i, 1);

                if (carater != "0" && carater != "1" && carater != "2" && carater != "3" && carater != "4" && carater != "5" && carater != "6"
                    && carater != "7" && carater != "8" && carater != "9" && carater != "." && carater != ",")
                {
                    MessageBox.Show("A altura do Pet deve conter apenas números. Utilize vírgula para separar as casas decimais.", "ERRO", MessageBoxButtons.OK);

                    textBoxPeso.Focus();

                    return false;
                }
            }

            for (var i = 0; i < textBoxIdade.Text.Length; i++)
            {
                var carater = textBoxIdade.Text.Substring(i, 1);

                if (carater != "0" && carater != "1" && carater != "2" && carater != "3" && carater != "4" && carater != "5" && carater != "6"
                    && carater != "7" && carater != "8" && carater != "9" && carater != "." && carater != ",")
                {
                    MessageBox.Show("A idade do Pet deve conter apenas números", "ERRO", MessageBoxButtons.OK);

                    textBoxPeso.Focus();

                    return false;
                }
            }

            return true;
        }
    }    
}