using Entra21.Gerenciador.Hospital.Vet.Models;
using Entra21.Gerenciador.Hospital.Vet.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var petService = new PetService();
            var pets = petService.ObterTodos();

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];
                comboBoxResponsavel.Items.Add(pet);
            }
        }

        private void PreencherComboBoxRaca()
        {
            var petService = new PetService();
            var pets = petService.ObterTodos();

            for (int i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];
                comboBoxRaca.Items.Add(pet);
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (CamposValidos() == false)
            {
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var peso = Convert.ToInt32(maskedTextBoxPeso.Text);
            var idade = Convert.ToInt32(maskedTextBoxIdade.Text);
            var altura = Convert.ToInt32(maskedTextBoxAltura.Text);
            var macho= radioButtonMacho.Text;
            var femea = radioButtonFemea.Text;
            
            var responsavel = comboBoxResponsavel.SelectedItem as Responsavel;
            var raca = comboBoxRaca.SelectedItem as Pet;

            var pet = new Pet();
            pet.Nome = nome;
            pet.Peso = peso;
            pet.Idade = idade;
            pet.Altura = altura;
            pet.Macho = macho;
            pet.Femea = femea;


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
            if (textBoxNome.Text.Trim().Length < 6)
            {
                MessageBox.Show("O nome do Pet precisa ter ao menos 10 caracteres!", "ERRO", MessageBoxButtons.OK);

                textBoxNome.Focus();

                return false;
            }

            if (maskedTextBoxPeso.Text == string.Empty)
            {
                MessageBox.Show("O Peso do Pet deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxPeso.Focus();

                return false;
            }

            if (maskedTextBoxIdade.Text == string.Empty)
            {
                MessageBox.Show("A Idade do Pet deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxIdade.Focus();

                return false;
            }

            if (maskedTextBoxAltura.Text == string.Empty)
            {
                MessageBox.Show("A Altura do Pet deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                maskedTextBoxAltura.Focus();

                return false;
            }

            if (radioButtonMacho.Text == string.Empty)
            {
                MessageBox.Show("O Seleção Gênero deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                radioButtonMacho.Focus();

                return false;
            }

            if (radioButtonFemea.Text == string.Empty)
            {
                MessageBox.Show("O Seleção Gênero deve ser preenchido!", "ERRO", MessageBoxButtons.OK);

                radioButtonFemea.Focus();

                return false;
            }
            return true;
        }

        
    }
    
}
