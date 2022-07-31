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
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.textBoxNomePetParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.labelNomePetParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxNomeResponsavelParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelNomeReponsavelParaFiltrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.textBoxNome,
            this.maskedTextBoxIdade,
            this.ColumnGenero,
            this.maskedTextBoxPeso,
            this.maskedTextBoxAltura,
            this.comboBoxRaca,
            this.comboBoxResponsavel});
            this.dataGridView1.Location = new System.Drawing.Point(11, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(734, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.HeaderText = "Nome";
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            // 
            // maskedTextBoxIdade
            // 
            this.maskedTextBoxIdade.HeaderText = "Idade";
            this.maskedTextBoxIdade.Name = "maskedTextBoxIdade";
            this.maskedTextBoxIdade.ReadOnly = true;
            // 
            // ColumnGenero
            // 
            this.ColumnGenero.HeaderText = "Gênero";
            this.ColumnGenero.Name = "ColumnGenero";
            this.ColumnGenero.ReadOnly = true;
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.HeaderText = "Peso";
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.ReadOnly = true;
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.HeaderText = "Altura";
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.ReadOnly = true;
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.HeaderText = "Raça";
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.ReadOnly = true;
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.HeaderText = "Responsavel";
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.ReadOnly = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(751, 75);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(751, 17);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 2;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(751, 46);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // textBoxNomePetParaFiltrar
            // 
            this.textBoxNomePetParaFiltrar.Location = new System.Drawing.Point(79, 12);
            this.textBoxNomePetParaFiltrar.Name = "textBoxNomePetParaFiltrar";
            this.textBoxNomePetParaFiltrar.Size = new System.Drawing.Size(244, 23);
            this.textBoxNomePetParaFiltrar.TabIndex = 4;
            this.textBoxNomePetParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNomePetParaFiltrar_KeyUp);
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(25, 390);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(0, 15);
            this.labelFiltrar.TabIndex = 5;
            // 
            // labelNomePetParaFiltrar
            // 
            this.labelNomePetParaFiltrar.AutoSize = true;
            this.labelNomePetParaFiltrar.Location = new System.Drawing.Point(11, 17);
            this.labelNomePetParaFiltrar.Name = "labelNomePetParaFiltrar";
            this.labelNomePetParaFiltrar.Size = new System.Drawing.Size(65, 15);
            this.labelNomePetParaFiltrar.TabIndex = 6;
            this.labelNomePetParaFiltrar.Text = "Nome PET:";
            // 
            // textBoxNomeResponsavelParaFiltrar
            // 
            this.textBoxNomeResponsavelParaFiltrar.Location = new System.Drawing.Point(457, 12);
            this.textBoxNomeResponsavelParaFiltrar.Name = "textBoxNomeResponsavelParaFiltrar";
            this.textBoxNomeResponsavelParaFiltrar.Size = new System.Drawing.Size(244, 23);
            this.textBoxNomeResponsavelParaFiltrar.TabIndex = 4;
            this.textBoxNomeResponsavelParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeResponsavelParaFiltrar_KeyUp);
            // 
            // labelNomeReponsavelParaFiltrar
            // 
            this.labelNomeReponsavelParaFiltrar.AutoSize = true;
            this.labelNomeReponsavelParaFiltrar.Location = new System.Drawing.Point(340, 17);
            this.labelNomeReponsavelParaFiltrar.Name = "labelNomeReponsavelParaFiltrar";
            this.labelNomeReponsavelParaFiltrar.Size = new System.Drawing.Size(111, 15);
            this.labelNomeReponsavelParaFiltrar.TabIndex = 6;
            this.labelNomeReponsavelParaFiltrar.Text = "Nome Responsável:";
            // 
            // PetListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.labelNomeReponsavelParaFiltrar);
            this.Controls.Add(this.labelNomePetParaFiltrar);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.textBoxNomeResponsavelParaFiltrar);
            this.Controls.Add(this.textBoxNomePetParaFiltrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PetListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Pets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private TextBox textBoxNomePetParaFiltrar;
        private Label labelFiltrar;
        private Label labelNomePetParaFiltrar;
        private TextBox textBoxNomeResponsavelParaFiltrar;
        private Label labelNomeReponsavelParaFiltrar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn textBoxNome;
        private DataGridViewTextBoxColumn maskedTextBoxIdade;
        private DataGridViewTextBoxColumn ColumnGenero;
        private DataGridViewTextBoxColumn maskedTextBoxPeso;
        private DataGridViewTextBoxColumn maskedTextBoxAltura;
        private DataGridViewTextBoxColumn comboBoxRaca;
        private DataGridViewTextBoxColumn comboBoxResponsavel;
    }
}