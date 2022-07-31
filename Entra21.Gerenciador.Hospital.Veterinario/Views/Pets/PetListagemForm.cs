using Entra21.Gerenciador.Hospital.Vet.Services;

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
            var nomePetParaFiltrar = textBoxNomePetParaFiltrar.Text.Trim();

            var nomeResponsavelPraFiltrar = textBoxNomeResponsavelParaFiltrar.Text.Trim();

            List<Models.Pet> pets;

            if (nomePetParaFiltrar != "")
            {
                pets = _petsService.ObterPorNomePet(nomePetParaFiltrar);
            }
            else if (nomeResponsavelPraFiltrar != "")
            {
                pets = _petsService.ObterPorNomeResponsavel(nomeResponsavelPraFiltrar);
            }
            else
            {
                pets = _petsService.ObterTodos();
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
                    pet.Genero,
                    pet.Peso,
                    pet.Altura,
                    pet.Raca.Nome,
                    pet.Responsavel.Nome
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Pet para editar!", "ERRO", MessageBoxButtons.OK);
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
                MessageBox.Show("Selecione um Pet para apagar!", "ERRO", MessageBoxButtons.OK);
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var petCadastroEdicaoForm = new PetCadastroEdicaoForm();

            petCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComPets();
        }

        private void textBoxNomePetParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComPets();
        }

        private void textBoxNomeResponsavelParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComPets();
        }
    }
}
