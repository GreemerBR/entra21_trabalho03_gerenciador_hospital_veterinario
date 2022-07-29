namespace Entra21.Gerenciador.Hospital.Vet.Views.Pets
{
    partial class PetListagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxNomePetParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textBoxNome,
            this.maskedTextBoxIdade,
            this.ColumnGenero,
            this.maskedTextBoxPeso,
            this.maskedTextBoxAltura,
            this.comboBoxRaca,
            this.comboBoxResponsavel});
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(973, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(808, 390);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(910, 387);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(708, 390);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxNomePetParaFiltrar
            // 
            this.textBoxNomePetParaFiltrar.Location = new System.Drawing.Point(136, 382);
            this.textBoxNomePetParaFiltrar.Name = "textBoxNomePetParaFiltrar";
            this.textBoxNomePetParaFiltrar.Size = new System.Drawing.Size(244, 23);
            this.textBoxNomePetParaFiltrar.TabIndex = 4;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(25, 390);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(0, 15);
            this.labelFiltrar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Para Filtrar";
            // 
            // textBoxNome
            // 
            this.textBoxNome.HeaderText = "Nome";
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Width = 200;
            // 
            // maskedTextBoxIdade
            // 
            this.maskedTextBoxIdade.HeaderText = "Idade";
            this.maskedTextBoxIdade.Name = "maskedTextBoxIdade";
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Gênero";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.Width = 150;
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.HeaderText = "Peso";
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.Width = 120;
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.HeaderText = "Altura";
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.Width = 120;
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.HeaderText = "Raça";
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Width = 120;
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.HeaderText = "Responsavel";
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Width = 120;
            // 
            // PetListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.textBoxNomePetParaFiltrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PetListagemForm";
            this.Text = "Listagem de Pets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonSalvar;
        private Button buttonEditar;
        private TextBox textBoxNomePetParaFiltrar;
        private Label labelFiltrar;
        private Label label1;
        private DataGridViewTextBoxColumn textBoxNome;
        private DataGridViewTextBoxColumn maskedTextBoxIdade;
        private DataGridViewTextBoxColumn ColumnGenero;
        private DataGridViewTextBoxColumn maskedTextBoxPeso;
        private DataGridViewTextBoxColumn maskedTextBoxAltura;
        private DataGridViewTextBoxColumn comboBoxRaca;
        private DataGridViewTextBoxColumn comboBoxResponsavel;
    }
}