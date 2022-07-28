using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Enderecos
{
    public partial class EnderecoListagemForm : Form
    {

        private readonly EnderecoService _enderecoService;

        public EnderecoListagemForm()
        {
            InitializeComponent();

            _enderecoService = new EnderecoService();

            PreencherDataGriedViewComEndereco();
        }

        private void PreencherDataGriedViewComEndereco()
        {
            var enderecos = _enderecoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < enderecos.Count; i++)
            {
                var endereco = enderecos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    endereco.Id,
                    endereco.Cep,
                    endereco.Logradouro,
                    endereco.Bairro,
                    endereco.Localidade,
                    endereco.Uf,
                    endereco.Responsavel.Nome
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var enderecoForm = new EnderecoCadastroEdicaoForm();
            enderecoForm.ShowDialog();

            PreencherDataGriedViewComEndereco();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _enderecoService.Apagar(id);

            PreencherDataGriedViewComEndereco();

            MessageBox.Show("registro removido com sucesso");
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var endereco = _enderecoService.ObterPorId(id);

            var endercoCadastroForm = new EnderecoCadastroEdicaoForm(endereco);
            endercoCadastroForm.ShowDialog();

            PreencherDataGriedViewComEndereco();
        }
    }
}
