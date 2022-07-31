using Entra21.Gerenciador.Hospital.Vet.Services;

namespace Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios
{
    public partial class VeterinarioListagemForm : Form
    {
        private readonly VeterinarioService _veterinariosService;

        public VeterinarioListagemForm()
        {
            InitializeComponent();

            _veterinariosService = new VeterinarioService();

            PreencherDataGridViewComVeterinarios();
        }

        private void PreencherDataGridViewComVeterinarios()
        {
            var nomeParaFiltrar = textBoxNomeParaFiltrar.Text.Trim();

            var especialidadeParaFiltrar = textBoxEspecialidadeParaFiltrar.Text.Trim();

            List<Models.Veterinario> veterinarios;

            if (nomeParaFiltrar != "")
            {
                veterinarios = _veterinariosService.ObterPorNome(nomeParaFiltrar);
            }
            else if (especialidadeParaFiltrar != "")
            {
                veterinarios = _veterinariosService.ObterPorEspecialidade(especialidadeParaFiltrar);
            }
            else
            {
                veterinarios = _veterinariosService.ObterTodos();
            }

            dataGridView1.Rows.Clear();

            for (var i = 0; i < veterinarios.Count; i++)
            {
                var veterinario = veterinarios[i];

                dataGridView1.Rows.Add(new object[]
                {
                    veterinario.Id,
                    veterinario.Nome,
                    veterinario.Especialidade,
                    veterinario.CrmvNumero,
                    veterinario.CrmvEstado,
                    veterinario.Idade,
                    veterinario.Cpf,
                    veterinario.Telefone
                });
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um(a) veterinário(a) para apagar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var resposta = MessageBox.Show("Deseja apagar o(a) veterinário(a)?", "Aviso", MessageBoxButtons.YesNo);

            if (resposta != DialogResult.Yes)
            {
                MessageBox.Show("O(a) veterinário(a) permanece na lista!", "Aviso", MessageBoxButtons.OK);
            }
            else
            {

                var linhaSelecionada = dataGridView1.SelectedRows[0];

                var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                _veterinariosService.Apagar(id);

                PreencherDataGridViewComVeterinarios();

                MessageBox.Show("Veterinário(a) removido(a) com sucesso!", "Aviso", MessageBoxButtons.OK);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Não há nenhum(a) veterinário(a) cadastrado!", "ERRO", MessageBoxButtons.OK);
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um(a) veterinário(a) para editar o cadastro!", "ERRO", MessageBoxButtons.OK);
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var veterinario = _veterinariosService.ObterPorId(id);

            var veterinarioCadastroForm = new VeterinarioCadastroEdicaoForm(veterinario);

            veterinarioCadastroForm.ShowDialog();

            PreencherDataGridViewComVeterinarios();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var veterinarioForm = new VeterinarioCadastroEdicaoForm();
            veterinarioForm.ShowDialog();

            PreencherDataGridViewComVeterinarios();
        }

        private void textBoxNomeParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComVeterinarios();
        }

        private void textBoxEspecialidadeParaFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            PreencherDataGridViewComVeterinarios();
        }
    }
}
