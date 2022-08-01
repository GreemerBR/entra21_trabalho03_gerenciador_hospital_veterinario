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

            textBoxPeso.Text = pet.Peso.ToString("N2");

            textBoxIdade.Text = pet.Idade.ToString();

            textBoxAltura.Text = pet.Altura.ToString("N2");

            if (pet.Genero == 'M')
            {
                radioButtonMasculino.Checked = true;
            }
            else
            {
                radioButtonFenimino.Checked = true;
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
            var peso = Convert.ToDecimal(textBoxPeso.Text.Replace(",", "."))/100;
            var idade = Convert.ToInt32(textBoxIdade.Text);
            var altura = Convert.ToDecimal(textBoxAltura.Text.Replace(",", "."))/100;
            var raca = comboBoxRaca.SelectedItem as Raca;
            var responsavel = comboBoxResponsavel.SelectedItem as Responsavel;
            char genero;

            if (radioButtonMasculino.Checked == true)
            {
                genero = 'M';

            }
            else
            {
                genero = 'F';
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

            if (textBoxPeso.Text.Trim().Length < 3 || textBoxPeso.Text.Trim().Length > 5)
            {
                MessageBox.Show("O peso do Pet deve ser preenchido com no mínimo 3 caracteres (x,xx)!", "ERRO", MessageBoxButtons.OK);

                textBoxPeso.Focus();

                return false;
            }

            for (var i = 0; i < textBoxPeso.Text.Length; i++)
            {
                if (textBoxPeso.Text.Substring(i, 1) != "0" && textBoxPeso.Text.Substring(i, 1) != "1" && textBoxPeso.Text.Substring(i, 1) != "2" &&
                    textBoxPeso.Text.Substring(i, 1) != "3" && textBoxPeso.Text.Substring(i, 1) != "4" && textBoxPeso.Text.Substring(i, 1) != "5" &&
                    textBoxPeso.Text.Substring(i, 1) != "6" && textBoxPeso.Text.Substring(i, 1) != "7" && textBoxPeso.Text.Substring(i, 1) != "8" &&
                    textBoxPeso.Text.Substring(i, 1) != "9" && textBoxPeso.Text.Substring(i, 1) != "," && textBoxPeso.Text.Substring(i, 1) != ".")
                {
                    MessageBox.Show("O peso do Pet deve ser informado utilizando números! Você pode usar . ou , para separar as casas decimais.", "ERRO", MessageBoxButtons.OK);

                    textBoxPeso.Focus();

                    return false;
                }
            }

            if (textBoxIdade.Text.Trim().Length < 1 || textBoxIdade.Text.Trim().Length > 2)
            {
                MessageBox.Show("A idade do Pet deve ser preenchido com no mínimo 1 caracter. Sempre em anos!", "ERRO", MessageBoxButtons.OK);

                textBoxIdade.Focus();

                return false;
            }

            for (var i = 0; i < textBoxIdade.Text.Length; i++)
            {
                if (textBoxIdade.Text.Substring(i, 1) != "0" && textBoxIdade.Text.Substring(i, 1) != "1" && textBoxIdade.Text.Substring(i, 1) != "2" &&
                    textBoxIdade.Text.Substring(i, 1) != "3" && textBoxIdade.Text.Substring(i, 1) != "4" && textBoxIdade.Text.Substring(i, 1) != "5" &&
                    textBoxIdade.Text.Substring(i, 1) != "6" && textBoxIdade.Text.Substring(i, 1) != "7" && textBoxIdade.Text.Substring(i, 1) != "8" &&
                    textBoxIdade.Text.Substring(i, 1) != "9")
                {
                    MessageBox.Show("A idade do Pet deve ser informado utilizando números!", "ERRO", MessageBoxButtons.OK);

                    textBoxIdade.Focus();

                    return false;
                }
            }

            if (textBoxAltura.Text.Trim().Length < 3 || textBoxAltura.Text.Trim().Length > 5)
            {
                MessageBox.Show("A altura do Pet deve ser preenchida com 3 caracteres (x,xx)!", "ERRO", MessageBoxButtons.OK);

                textBoxAltura.Focus();

                return false;
            }

            for (var i = 0; i < textBoxAltura.Text.Length; i++)
            {
                if (textBoxAltura.Text.Substring(i, 1) != "0" && textBoxAltura.Text.Substring(i, 1) != "1" && textBoxAltura.Text.Substring(i, 1) != "2" &&
                    textBoxAltura.Text.Substring(i, 1) != "3" && textBoxAltura.Text.Substring(i, 1) != "4" && textBoxAltura.Text.Substring(i, 1) != "5" &&
                    textBoxAltura.Text.Substring(i, 1) != "6" && textBoxAltura.Text.Substring(i, 1) != "7" && textBoxAltura.Text.Substring(i, 1) != "8" &&
                    textBoxAltura.Text.Substring(i, 1) != "9" && textBoxAltura.Text.Substring(i, 1) != "," && textBoxAltura.Text.Substring(i, 1) != ".")
                {
                    MessageBox.Show("A altura do Pet deve ser informado utilizando números! Você pode usar . ou , para separar as casas decimais.", "ERRO", MessageBoxButtons.OK);

                    textBoxAltura.Focus();

                    return false;
                }
            }

            return true;
        }
    }

}