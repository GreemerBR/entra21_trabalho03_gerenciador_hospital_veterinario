using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    public partial class RacaListagemForm : Form
    {
        private RacaService _racaService;

        public RacaListagemForm()
        {
            InitializeComponent();

            _racaService = new RacaService();

            PreencherDataGridViewComRacas();
        }
        
        private void PreencherDataGridViewComRacas()
        {
            var nomeParaFiltrar = textBoxNomeParaFiltrar.Text.Trim();

            var especieParaFiltrar = textBoxEspecieParaFiltrar.Text.Trim();

            List<Models.Raca> racas;

            if (nomeParaFiltrar != "")
            {
                racas = _racaService.ObterPorNome(nomeParaFiltrar);
            }
            else if (especieParaFiltrar != "")
            {
                racas = _racaService.ObterPorEspecie(especieParaFiltrar);
            }
            else
            {
                racas = _racaService.ObterTodos();
            }

            dataGridViewRacas.Rows.Clear();

            for (int i = 0; i < racas.Count; i++)
            {
                var raca = racas[i];

                dataGridViewRacas.Rows.Add(new object[]
                {
                    raca.Id,
                    raca.Nome,
                    raca.Especie,
                    
                });
            }
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            var racaCadastroEdicaoForm =
               new RacaCadastroEdicaoForm();

            racaCadastroEdicaoForm.ShowDialog();

            PreencherDataGridViewComRacas();
        }

        private void ButtonEditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewRacas.Rows.Count == 0)
            {
                MessageBox.Show("Selecione uma raça para editar o cadastro!", "Aviso", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridViewRacas.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var raca = _racaService.ObterPorId(id);

            var racaForm = new RacaCadastroEdicaoForm(raca);

            racaForm.ShowDialog();

            PreencherDataGridViewComRacas();
        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma raça para apagar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar a raça?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("A raça permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridViewRacas.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _racaService.Apagar(id);

                PreencherDataGridViewComRacas();

                MessageBox.Show("Raça removida com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }
    }
}
