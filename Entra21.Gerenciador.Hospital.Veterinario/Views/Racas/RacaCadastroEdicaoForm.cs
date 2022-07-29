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
            if (CamposValidos() == false)
            {
                return;
            }

            var nome = textBoxNome.Text.Trim();
            var especie = textBoxEspecie.Text.Trim();


            var pet = new Pet();
            pet.Nome = nome;
            pet.Especie = especie;
            


            var racaService = new RacaService();

            if (_idParaEditar == -1)
            {
                racaService.Cadastrar(raca);

                MessageBox.Show("Raça está Salvo  ", "Aviso", MessageBoxButtons.OK);
                Close();

                return;
            }
            else
            {
                pet.Id = _idParaEditar;
                petService.Editar(pet);

                MessageBox.Show("Cadastro do Pet editado com sucesso", "Aviso", MessageBoxButtons.OK);
                Close();
            }
        }

        private bool CamposValidos()
        {
            throw new NotImplementedException();
        }
    }
}
