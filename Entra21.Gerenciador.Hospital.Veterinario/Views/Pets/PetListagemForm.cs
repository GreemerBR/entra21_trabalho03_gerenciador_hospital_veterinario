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
    public partial class PetListagemForm : Form
    {
        private readonly PetService _petsService;

        public PetListagemForm()
        {
            InitializeComponent();

            _petsService = new PetService();

            PreencherDataGridViewComPets();
        }

        private void PreencherDataGridViewComPets()
        {
            var nomeParaFiltrar = textBoxNomePetParaFiltrar.Text.Trim();

            List<Models.Pet> pets;

            if (nomeParaFiltrar == "")
            {
                pets = _petsService.ObterTodos();
            }
            else
            {
               pets = _petsService.ObterPorNome(nomeParaFiltrar);
            }

            dataGridView1.Rows.Clear();

            for (var i = 0; i < pets.Count; i++)
            {
                var pet = pets[i];

                dataGridView1.Rows.Add(new object[]
                {
                    pet.Id,
                    pet.Nome,
                    pet.Idade,
                    pet.Altura,
                    pet.Peso,
                    pet.Genero,
                   
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Pet para editar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var pet = _petsService.ObterPorId(id);

            var petCadastroForm = new PetCadastroEdicaoForm(pet);

            petCadastroForm.ShowDialog();

            PreencherDataGridViewComPets();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Pet para apagar!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o Pet?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O Pet permanece Registrado!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _petsService.Apagar(id);

                PreencherDataGridViewComPets();

                MessageBox.Show("Pet removido!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var petForm = new PetCadastroEdicaoForm();
            petForm.ShowDialog();

            PreencherDataGridViewComPets();
        }
    }
}
