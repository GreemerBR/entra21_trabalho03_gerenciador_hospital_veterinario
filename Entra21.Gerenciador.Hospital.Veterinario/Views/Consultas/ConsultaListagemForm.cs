using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Consultas
{
    public partial class ConsultaListagemForm : Form
    {
        private readonly ConsultaService _consultaService;

        public ConsultaListagemForm()
        {
            InitializeComponent();

            _consultaService = new ConsultaService();

            PreencherDataGridViewComConsultas();
        }

        private void PreencherDataGridViewComConsultas()
        {
            var nomeVeterinarioParaFiltrar = textBoxVeterinarioParaFiltrar.Text.Trim();

            var nomePetParaFiltrar = textBoxPetParaFiltrar.Text.Trim();

            List<Models.Consulta> consultas;

            //if (nomeVeterinarioParaFiltrar == "" && nomePetParaFiltrar == "")
            //{
            //    consultas = _consultaService.ObterTodos();
            //}
            //else if (nomePetParaFiltrar == "")
            //{
            //    consultas = _consultaService.ObterPorVeterinario(nomeVeterinarioParaFiltrar);
            //}
            //else
            //{
            //    consultas = _consultaService.ObterPorPet(nomePetParaFiltrar);
            //}

            if (nomeVeterinarioParaFiltrar != "")
            {
                consultas = _consultaService.ObterPorVeterinario(nomeVeterinarioParaFiltrar);
            }
            else if (nomePetParaFiltrar != "")
            {
                consultas = _consultaService.ObterPorPet(nomePetParaFiltrar);
            }
            else
            {
                consultas = _consultaService.ObterTodos();
            }
            
            dataGridView1.Rows.Clear();

            for (var i = 0; i < consultas.Count; i++)
            {
                var consulta = consultas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    consulta.Id,
                    consulta.Veterinario.Nome,
                    consulta.Pet.Nome,
                    consulta.DataHora.ToString("dd/MM/yyyy"),
                    consulta.DataHora.ToString("hh:MM"),
                    consulta.Observacao
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma consulta para apagar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar a consulta?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("A consulta permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _consultaService.Apagar(id);

                PreencherDataGridViewComConsultas();

                MessageBox.Show("Consulta removida com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma consulta para editar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var consulta = _consultaService.ObterPorId(id);

            var consultaCadastroForm = new ConsultaCadastroEdicaoForm(consulta);

            consultaCadastroForm.ShowDialog();

            PreencherDataGridViewComConsultas();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var consultaForm = new ConsultaCadastroEdicaoForm();
            consultaForm.ShowDialog();

            PreencherDataGridViewComConsultas();
        }

        private void textBoxVeterinarioParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComConsultas();
        }

        private void textBoxPetParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComConsultas();
        }
    }
}