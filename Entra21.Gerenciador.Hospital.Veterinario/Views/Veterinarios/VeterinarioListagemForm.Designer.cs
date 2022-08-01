namespace Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios
{
    partial class VeterinarioListagemForm
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
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEspecialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCrmvNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCrmvEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelNomeParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxNomeParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelEspecialidadeParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxEspecialidadeParaFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnEspecialidade,
            this.ColumnCrmvNumero,
            this.ColumnCrmvEstado,
            this.ColumnIdade,
            this.ColumnCpf,
            this.ColumnTelefone});
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnEspecialidade
            // 
            this.ColumnEspecialidade.HeaderText = "Especialidades";
            this.ColumnEspecialidade.Name = "ColumnEspecialidade";
            this.ColumnEspecialidade.ReadOnly = true;
            // 
            // ColumnCrmvNumero
            // 
            this.ColumnCrmvNumero.HeaderText = "N° CRMV";
            this.ColumnCrmvNumero.Name = "ColumnCrmvNumero";
            this.ColumnCrmvNumero.ReadOnly = true;
            // 
            // ColumnCrmvEstado
            // 
            this.ColumnCrmvEstado.HeaderText = "UF";
            this.ColumnCrmvEstado.Name = "ColumnCrmvEstado";
            this.ColumnCrmvEstado.ReadOnly = true;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.HeaderText = "Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Tomato;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Location = new System.Drawing.Point(751, 5);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 35);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Tomato;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(670, 5);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 35);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Tomato;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.ForeColor = System.Drawing.Color.White;
            this.buttonApagar.Location = new System.Drawing.Point(589, 5);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 35);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelNomeParaFiltrar
            // 
            this.labelNomeParaFiltrar.AutoSize = true;
            this.labelNomeParaFiltrar.Location = new System.Drawing.Point(12, 15);
            this.labelNomeParaFiltrar.Name = "labelNomeParaFiltrar";
            this.labelNomeParaFiltrar.Size = new System.Drawing.Size(119, 15);
            this.labelNomeParaFiltrar.TabIndex = 2;
            this.labelNomeParaFiltrar.Text = "Nome Veterinário(a): ";
            // 
            // textBoxNomeParaFiltrar
            // 
            this.textBoxNomeParaFiltrar.Location = new System.Drawing.Point(139, 12);
            this.textBoxNomeParaFiltrar.Name = "textBoxNomeParaFiltrar";
            this.textBoxNomeParaFiltrar.Size = new System.Drawing.Size(169, 23);
            this.textBoxNomeParaFiltrar.TabIndex = 3;
            this.textBoxNomeParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxNomeParaFiltrar_KeyUp);
            // 
            // labelEspecialidadeParaFiltrar
            // 
            this.labelEspecialidadeParaFiltrar.AutoSize = true;
            this.labelEspecialidadeParaFiltrar.Location = new System.Drawing.Point(314, 15);
            this.labelEspecialidadeParaFiltrar.Name = "labelEspecialidadeParaFiltrar";
            this.labelEspecialidadeParaFiltrar.Size = new System.Drawing.Size(81, 15);
            this.labelEspecialidadeParaFiltrar.TabIndex = 2;
            this.labelEspecialidadeParaFiltrar.Text = "Especialidade:";
            // 
            // textBoxEspecialidadeParaFiltrar
            // 
            this.textBoxEspecialidadeParaFiltrar.Location = new System.Drawing.Point(401, 12);
            this.textBoxEspecialidadeParaFiltrar.Name = "textBoxEspecialidadeParaFiltrar";
            this.textBoxEspecialidadeParaFiltrar.Size = new System.Drawing.Size(168, 23);
            this.textBoxEspecialidadeParaFiltrar.TabIndex = 3;
            this.textBoxEspecialidadeParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEspecialidadeParaFiltrar_KeyUp);
            // 
            // VeterinarioListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.textBoxEspecialidadeParaFiltrar);
            this.Controls.Add(this.labelEspecialidadeParaFiltrar);
            this.Controls.Add(this.textBoxNomeParaFiltrar);
            this.Controls.Add(this.labelNomeParaFiltrar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VeterinarioListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veterinários(as)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonCadastrar;
        private Button buttonEditar;
        private Button buttonApagar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnEspecialidade;
        private DataGridViewTextBoxColumn ColumnCrmvNumero;
        private DataGridViewTextBoxColumn ColumnCrmvEstado;
        private DataGridViewTextBoxColumn ColumnIdade;
        private DataGridViewTextBoxColumn ColumnCpf;
        private DataGridViewTextBoxColumn ColumnTelefone;
        private Label labelNomeParaFiltrar;
        private TextBox textBoxNomeParaFiltrar;
        private Label labelEspecialidadeParaFiltrar;
        private TextBox textBoxEspecialidadeParaFiltrar;
    }
}