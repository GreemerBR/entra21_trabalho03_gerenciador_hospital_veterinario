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

namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    public partial class RacaListagemForm : Form
    {
        private RacaService racaService;

        public RacaListagemForm()
        {
            InitializeComponent();

            racaService = new RacaService();
        }
        private void ResponsavelListagemForm_Load(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGriedView();
        }
        private void AtualizarRegistrosDataGriedView()
        {
            var racas = racaService.ObterTodos();

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

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            var racaCadastroEdicaoForm =
               new RacaCadastroEdicaoForm();

            racaCadastroEdicaoForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRacas.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre!!");
                return;
            }

            if (dataGridViewRacas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridViewRacas.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var raca = racaService.ObterPorId(id);

            var racaForm = new RacaCadastroEdicaoForm(raca);
            racaForm.ShowDialog();

            AtualizarRegistrosDataGriedView();
        }

        private void ButtonApagar1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewRacas.SelectedRows[0].Cells[0].Value);

            racaService.Apagar(id);

            AtualizarRegistrosDataGriedView();

            MessageBox.Show("Registro apagado com sucesso");
        }
    }
}
