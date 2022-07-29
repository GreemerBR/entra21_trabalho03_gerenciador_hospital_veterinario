namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    partial class RacaListegemForm
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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espécie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonApagar1 = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRacas
            // 
            this.dataGridViewRacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Espécie});
            this.dataGridViewRacas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRacas.Name = "dataGridViewRacas";
            this.dataGridViewRacas.RowTemplate.Height = 25;
            this.dataGridViewRacas.Size = new System.Drawing.Size(644, 311);
            this.dataGridViewRacas.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // Espécie
            // 
            this.Espécie.HeaderText = "Espécie";
            this.Espécie.Name = "Espécie";
            this.Espécie.Width = 300;
            // 
            // ButtonApagar1
            // 
            this.ButtonApagar1.Location = new System.Drawing.Point(382, 362);
            this.ButtonApagar1.Name = "ButtonApagar1";
            this.ButtonApagar1.Size = new System.Drawing.Size(75, 23);
            this.ButtonApagar1.TabIndex = 1;
            this.ButtonApagar1.Text = "Apagar";
            this.ButtonApagar1.UseVisualStyleBackColor = true;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Location = new System.Drawing.Point(581, 362);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalvar.TabIndex = 2;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Location = new System.Drawing.Point(479, 362);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditar.TabIndex = 3;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = true;
            // 
            // RacaListegemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 392);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.ButtonApagar1);
            this.Controls.Add(this.dataGridViewRacas);
            this.Name = "RacaListegemForm";
            this.Text = "Lista das Raças";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewRacas;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Espécie;
        private Button ButtonApagar1;
        private Button ButtonSalvar;
        private Button ButtonEditar;
    }
}