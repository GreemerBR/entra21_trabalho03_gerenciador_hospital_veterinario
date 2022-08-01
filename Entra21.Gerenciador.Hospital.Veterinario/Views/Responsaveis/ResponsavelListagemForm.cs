using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    public partial class ResponsavelListagemForm : Form
    {
        private readonly ResponsavelService _responsavelService;

        public ResponsavelListagemForm()
        {
            InitializeComponent();

            _responsavelService = new ResponsavelService();

            AtualizarRegistrosDataGriedView();
        }

        private void AtualizarRegistrosDataGriedView()
        {
            var nomeParaFiltrar = textBoxBuscarPorNome.Text.Trim();
            List<Models.Responsavel> responsaveis;

            if (nomeParaFiltrar != "")
            {
                responsaveis = _responsavelService.ObterPorNome(nomeParaFiltrar);
            }
            else
            {
                responsaveis = _responsavelService.ObterTodos();
            }

            dataGridView1.Rows.Clear();

            for (int i = 0; i < responsaveis.Count; i++)
            {
                var responsavel = responsaveis[i];

                dataGridView1.Rows.Add(new object[]
                {
                    responsavel.Id,
                    responsavel.Nome,
                    responsavel.Idade,
                    responsavel.Cpf,
                    responsavel.Telefone
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var responsavelCadastroEdicaoForm =
                new ResponsavelCadastroEdicaoForm();

            responsavelCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um(a) responsável para apagar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o(a) responsável?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O(a) responsável permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _responsavelService.Apagar(id);

                AtualizarRegistrosDataGriedView();

                MessageBox.Show("Responsável removido(a) com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Não há nenhum(a) responsável cadastrado!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um(a) responsável para editar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var responsavel = _responsavelService.ObterPorId(id);

            var responsavelForm = new ResponsavelCadastroEdicaoForm(responsavel);
            
            responsavelForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }

        private void textBoxBuscarPorNome_KeyUp(object sender, KeyEventArgs e)
        {
            AtualizarRegistrosDataGriedView();
        }
    }
}
