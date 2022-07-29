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

namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    public partial class RacaCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        private int idEdicao;

        public RacaCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }
        public RacaCadastroEdicaoForm(Raca raca) : this()
        {
            _idParaEditar = raca.Id;

            textBoxNome.Text = raca.Nome;

            textBoxEspecie.Text = raca.Especie;

        }

        private void Nome2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var especie = textBoxEspecie.Text.Trim();

            var raca = new Raca();
            raca.Nome = nome;
            raca.Especie = especie;
            

            var racaService = new RacaService();

            if (idEdicao == -1)
            {
                racaService.Cadastrar(raca);

                MessageBox.Show("Raça cadastrado com sucesso");

                Close();

                return;
            }

            raca.Id = idEdicao;
            racaService.Editar(raca);

            MessageBox.Show("Raça alterado com sucesso!!");

            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            Close();
            
        }
    

    
        
            
        
    }
}
