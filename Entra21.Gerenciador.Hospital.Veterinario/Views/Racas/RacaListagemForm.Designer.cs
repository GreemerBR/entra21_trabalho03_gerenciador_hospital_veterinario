﻿namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espécie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonApagar = new System.Windows.Forms.Button();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.ButtonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRacas
            // 
            this.dataGridViewRacas.AllowUserToAddRows = false;
            this.dataGridViewRacas.AllowUserToDeleteRows = false;
            this.dataGridViewRacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRacas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Espécie});
            this.dataGridViewRacas.Location = new System.Drawing.Point(15, 45);
            this.dataGridViewRacas.Name = "dataGridViewRacas";
            this.dataGridViewRacas.ReadOnly = true;
            this.dataGridViewRacas.RowTemplate.Height = 25;
            this.dataGridViewRacas.Size = new System.Drawing.Size(644, 311);
            this.dataGridViewRacas.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Espécie
            // 
            this.Espécie.HeaderText = "Espécie";
            this.Espécie.Name = "Espécie";
            this.Espécie.ReadOnly = true;
            this.Espécie.Width = 300;
            // 
            // ButtonApagar
            // 
            this.ButtonApagar.Location = new System.Drawing.Point(422, 16);
            this.ButtonApagar.Name = "ButtonApagar";
            this.ButtonApagar.Size = new System.Drawing.Size(75, 23);
            this.ButtonApagar.TabIndex = 1;
            this.ButtonApagar.Text = "Apagar";
            this.ButtonApagar.UseVisualStyleBackColor = true;
            this.ButtonApagar.Click += new System.EventHandler(this.ButtonApagar_Click);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.Location = new System.Drawing.Point(584, 16);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCadastrar.TabIndex = 2;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = true;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Location = new System.Drawing.Point(503, 16);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditar.TabIndex = 3;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = true;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click_1);
            // 
            // RacaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 367);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.ButtonApagar);
            this.Controls.Add(this.dataGridViewRacas);
            this.Name = "RacaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista das Raças";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRacas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewRacas;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Espécie;
        private Button ButtonApagar;
        private Button ButtonCadastrar;
        private Button ButtonEditar;
    }
}