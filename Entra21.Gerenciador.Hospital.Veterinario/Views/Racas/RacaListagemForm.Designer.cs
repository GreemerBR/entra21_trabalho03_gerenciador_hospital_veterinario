namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    partial class RacaListagemForm
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
            this.dataGridViewRacas = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espécie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonApagar = new System.Windows.Forms.Button();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.labelNomeParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxNomeParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelEspecieParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxEspecieParaFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRacas
            // 
            this.dataGridViewRacas.AllowUserToAddRows = false;
            this.dataGridViewRacas.AllowUserToDeleteRows = false;
            this.dataGridViewRacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRacas.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewRacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.Nome,
            this.Espécie});
            this.dataGridViewRacas.Location = new System.Drawing.Point(15, 45);
            this.dataGridViewRacas.Name = "dataGridViewRacas";
            this.dataGridViewRacas.ReadOnly = true;
            this.dataGridViewRacas.RowTemplate.Height = 25;
            this.dataGridViewRacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRacas.Size = new System.Drawing.Size(811, 387);
            this.dataGridViewRacas.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Espécie
            // 
            this.Espécie.HeaderText = "Espécie";
            this.Espécie.Name = "Espécie";
            this.Espécie.ReadOnly = true;
            // 
            // ButtonApagar
            // 
            this.ButtonApagar.BackColor = System.Drawing.Color.Tomato;
            this.ButtonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonApagar.ForeColor = System.Drawing.Color.White;
            this.ButtonApagar.Location = new System.Drawing.Point(586, 4);
            this.ButtonApagar.Name = "ButtonApagar";
            this.ButtonApagar.Size = new System.Drawing.Size(78, 35);
            this.ButtonApagar.TabIndex = 1;
            this.ButtonApagar.Text = "Apagar";
            this.ButtonApagar.UseVisualStyleBackColor = false;
            this.ButtonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.Tomato;
            this.ButtonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastrar.ForeColor = System.Drawing.Color.White;
            this.ButtonCadastrar.Location = new System.Drawing.Point(748, 4);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(78, 35);
            this.ButtonCadastrar.TabIndex = 2;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.BackColor = System.Drawing.Color.Tomato;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Location = new System.Drawing.Point(667, 4);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(78, 35);
            this.ButtonEditar.TabIndex = 3;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click_1);
            // 
            // labelNomeParaFiltrar
            // 
            this.labelNomeParaFiltrar.AutoSize = true;
            this.labelNomeParaFiltrar.Location = new System.Drawing.Point(15, 20);
            this.labelNomeParaFiltrar.Name = "labelNomeParaFiltrar";
            this.labelNomeParaFiltrar.Size = new System.Drawing.Size(43, 15);
            this.labelNomeParaFiltrar.TabIndex = 4;
            this.labelNomeParaFiltrar.Text = "Nome:";
            // 
            // textBoxNomeParaFiltrar
            // 
            this.textBoxNomeParaFiltrar.Location = new System.Drawing.Point(64, 16);
            this.textBoxNomeParaFiltrar.Name = "textBoxNomeParaFiltrar";
            this.textBoxNomeParaFiltrar.Size = new System.Drawing.Size(131, 23);
            this.textBoxNomeParaFiltrar.TabIndex = 5;
            this.textBoxNomeParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeParaFiltrar_KeyUp);
            // 
            // labelEspecieParaFiltrar
            // 
            this.labelEspecieParaFiltrar.AutoSize = true;
            this.labelEspecieParaFiltrar.Location = new System.Drawing.Point(207, 20);
            this.labelEspecieParaFiltrar.Name = "labelEspecieParaFiltrar";
            this.labelEspecieParaFiltrar.Size = new System.Drawing.Size(49, 15);
            this.labelEspecieParaFiltrar.TabIndex = 4;
            this.labelEspecieParaFiltrar.Text = "Espécie:";
            // 
            // textBoxEspecieParaFiltrar
            // 
            this.textBoxEspecieParaFiltrar.Location = new System.Drawing.Point(256, 16);
            this.textBoxEspecieParaFiltrar.Name = "textBoxEspecieParaFiltrar";
            this.textBoxEspecieParaFiltrar.Size = new System.Drawing.Size(131, 23);
            this.textBoxEspecieParaFiltrar.TabIndex = 5;
            this.textBoxEspecieParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEspecieParaFiltrar_KeyUp);
            // 
            // RacaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.textBoxEspecieParaFiltrar);
            this.Controls.Add(this.textBoxNomeParaFiltrar);
            this.Controls.Add(this.labelEspecieParaFiltrar);
            this.Controls.Add(this.labelNomeParaFiltrar);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.ButtonApagar);
            this.Controls.Add(this.dataGridViewRacas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RacaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista das Raças";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewRacas;
        private Button ButtonApagar;
        private Button ButtonCadastrar;
        private Button ButtonEditar;
        private Label labelNomeParaFiltrar;
        private TextBox textBoxNomeParaFiltrar;
        private Label labelEspecieParaFiltrar;
        private TextBox textBoxEspecieParaFiltrar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Espécie;
    }
}