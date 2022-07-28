using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    public partial class ResponsavelListagemForm : Form
    {
        private ResponsavelService responsavelService;

        public ResponsavelListagemForm()
        {
            InitializeComponent();

            responsavelService = new ResponsavelService();
        }

        private void ResponsavelListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGriedView();
        }

        private void AtualizarRegistrosDataGriedView()
        {
            var responsaveis = responsavelService.ObterTodos();

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
            var id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            responsavelService.Apagar(id);

            AtualizarRegistrosDataGriedView();

            MessageBox.Show("Registro apagado com sucessp");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum responsavel");
                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var responsavel = responsavelService.ObterPorId(id);

            var responsavelForm = new ResponsavelCadastroEdicaoForm(responsavel);
            responsavelForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }
    }
}
