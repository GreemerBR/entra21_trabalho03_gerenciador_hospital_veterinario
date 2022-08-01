namespace Entra21.Gerenciador.Hospital.Vet.Views.Consultas
{
    partial class ConsultaListagemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelVeterinarioParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxVeterinarioParaFiltrar = new System.Windows.Forms.TextBox();
            this.labelPetParaFiltrar = new System.Windows.Forms.Label();
            this.textBoxPetParaFiltrar = new System.Windows.Forms.TextBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeterinario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnVeterinario,
            this.ColumnPet,
            this.ColumnData,
            this.ColumnHora,
            this.ColumnObservacao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(814, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelVeterinarioParaFiltrar
            // 
            this.labelVeterinarioParaFiltrar.AutoSize = true;
            this.labelVeterinarioParaFiltrar.Location = new System.Drawing.Point(12, 9);
            this.labelVeterinarioParaFiltrar.Name = "labelVeterinarioParaFiltrar";
            this.labelVeterinarioParaFiltrar.Size = new System.Drawing.Size(151, 15);
            this.labelVeterinarioParaFiltrar.TabIndex = 1;
            this.labelVeterinarioParaFiltrar.Text = "Pesquisar por veterinário(a)";
            // 
            // textBoxVeterinarioParaFiltrar
            // 
            this.textBoxVeterinarioParaFiltrar.Location = new System.Drawing.Point(12, 27);
            this.textBoxVeterinarioParaFiltrar.Name = "textBoxVeterinarioParaFiltrar";
            this.textBoxVeterinarioParaFiltrar.Size = new System.Drawing.Size(173, 23);
            this.textBoxVeterinarioParaFiltrar.TabIndex = 2;
            this.textBoxVeterinarioParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxVeterinarioParaFiltrar_KeyUp);
            // 
            // labelPetParaFiltrar
            // 
            this.labelPetParaFiltrar.AutoSize = true;
            this.labelPetParaFiltrar.Location = new System.Drawing.Point(204, 9);
            this.labelPetParaFiltrar.Name = "labelPetParaFiltrar";
            this.labelPetParaFiltrar.Size = new System.Drawing.Size(98, 15);
            this.labelPetParaFiltrar.TabIndex = 1;
            this.labelPetParaFiltrar.Text = "Pesquisar por Pet";
            // 
            // textBoxPetParaFiltrar
            // 
            this.textBoxPetParaFiltrar.Location = new System.Drawing.Point(204, 27);
            this.textBoxPetParaFiltrar.Name = "textBoxPetParaFiltrar";
            this.textBoxPetParaFiltrar.Size = new System.Drawing.Size(127, 23);
            this.textBoxPetParaFiltrar.TabIndex = 2;
            this.textBoxPetParaFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPetParaFiltrar_KeyUp);
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.Tomato;
            this.buttonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApagar.ForeColor = System.Drawing.Color.White;
            this.buttonApagar.Location = new System.Drawing.Point(520, 9);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(98, 40);
            this.buttonApagar.TabIndex = 3;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Tomato;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(624, 9);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(98, 40);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Tomato;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Location = new System.Drawing.Point(728, 9);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(98, 40);
            this.buttonCadastrar.TabIndex = 3;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnVeterinario
            // 
            this.ColumnVeterinario.HeaderText = "Veterinário(a)";
            this.ColumnVeterinario.Name = "ColumnVeterinario";
            this.ColumnVeterinario.ReadOnly = true;
            // 
            // ColumnPet
            // 
            this.ColumnPet.HeaderText = "PET";
            this.ColumnPet.Name = "ColumnPet";
            this.ColumnPet.ReadOnly = true;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            // 
            // ColumnHora
            // 
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            // 
            // ColumnObservacao
            // 
            this.ColumnObservacao.HeaderText = "Observação";
            this.ColumnObservacao.Name = "ColumnObservacao";
            this.ColumnObservacao.ReadOnly = true;
            // 
            // ConsultaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.textBoxPetParaFiltrar);
            this.Controls.Add(this.labelPetParaFiltrar);
            this.Controls.Add(this.textBoxVeterinarioParaFiltrar);
            this.Controls.Add(this.labelVeterinarioParaFiltrar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labelVeterinarioParaFiltrar;
        private TextBox textBoxVeterinarioParaFiltrar;
        private Label labelPetParaFiltrar;
        private TextBox textBoxPetParaFiltrar;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastrar;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnVeterinario;
        private DataGridViewTextBoxColumn ColumnPet;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn ColumnHora;
        private DataGridViewTextBoxColumn ColumnObservacao;
    }
}