﻿namespace Entra21.Gerenciador.Hospital.Vet.Views.Pets
{
    partial class PetCadastroEdicaoForm
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
            this.LabelNome = new System.Windows.Forms.Label();
            this.Peso2 = new System.Windows.Forms.Label();
            this.LabelIdade = new System.Windows.Forms.Label();
            this.Altura4 = new System.Windows.Forms.Label();
            this.Genero5 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxIdade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 27);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome";
            // 
            // Peso2
            // 
            this.Peso2.AutoSize = true;
            this.Peso2.Location = new System.Drawing.Point(12, 86);
            this.Peso2.Name = "Peso2";
            this.Peso2.Size = new System.Drawing.Size(32, 15);
            this.Peso2.TabIndex = 1;
            this.Peso2.Text = "Peso";
            // 
            // LabelIdade
            // 
            this.LabelIdade.AutoSize = true;
            this.LabelIdade.Location = new System.Drawing.Point(380, 27);
            this.LabelIdade.Name = "LabelIdade";
            this.LabelIdade.Size = new System.Drawing.Size(36, 15);
            this.LabelIdade.TabIndex = 2;
            this.LabelIdade.Text = "Idade";
            // 
            // Altura4
            // 
            this.Altura4.AutoSize = true;
            this.Altura4.Location = new System.Drawing.Point(386, 86);
            this.Altura4.Name = "Altura4";
            this.Altura4.Size = new System.Drawing.Size(39, 15);
            this.Altura4.TabIndex = 3;
            this.Altura4.Text = "Altura";
            // 
            // Genero5
            // 
            this.Genero5.AutoSize = true;
            this.Genero5.Location = new System.Drawing.Point(12, 161);
            this.Genero5.Name = "Genero5";
            this.Genero5.Size = new System.Drawing.Size(45, 15);
            this.Genero5.TabIndex = 4;
            this.Genero5.Text = "Genêro";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 45);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(250, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // maskedTextBoxIdade
            // 
            this.maskedTextBoxIdade.Location = new System.Drawing.Point(380, 45);
            this.maskedTextBoxIdade.Name = "maskedTextBoxIdade";
            this.maskedTextBoxIdade.Size = new System.Drawing.Size(202, 23);
            this.maskedTextBoxIdade.TabIndex = 6;
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.Location = new System.Drawing.Point(380, 104);
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.Size = new System.Drawing.Size(202, 23);
            this.maskedTextBoxAltura.TabIndex = 7;
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.Location = new System.Drawing.Point(12, 104);
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.Size = new System.Drawing.Size(250, 23);
            this.maskedTextBoxPeso.TabIndex = 8;
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.Location = new System.Drawing.Point(12, 213);
            this.radioButtonFemea.Name = "radioButtonFemea";
            this.radioButtonFemea.Size = new System.Drawing.Size(60, 19);
            this.radioButtonFemea.TabIndex = 9;
            this.radioButtonFemea.TabStop = true;
            this.radioButtonFemea.Text = "Fêmea";
            this.radioButtonFemea.UseVisualStyleBackColor = true;
            // 
            // radioButtonMacho
            // 
            this.radioButtonMacho.AutoSize = true;
            this.radioButtonMacho.Location = new System.Drawing.Point(12, 188);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(62, 19);
            this.radioButtonMacho.TabIndex = 10;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho";
            this.radioButtonMacho.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(380, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(78, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(494, 224);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(78, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // PetCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 259);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.radioButtonMacho);
            this.Controls.Add(this.radioButtonFemea);
            this.Controls.Add(this.maskedTextBoxPeso);
            this.Controls.Add(this.maskedTextBoxAltura);
            this.Controls.Add(this.maskedTextBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Genero5);
            this.Controls.Add(this.Altura4);
            this.Controls.Add(this.LabelIdade);
            this.Controls.Add(this.Peso2);
            this.Controls.Add(this.LabelNome);
            this.Name = "PetCadastroEdicaoForm";
            this.Text = "Cadastro dos Pets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNome;
        private Label Peso2;
        private Label LabelIdade;
        private Label Altura4;
        private Label Genero5;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxIdade;
        private MaskedTextBox maskedTextBoxAltura;
        private MaskedTextBox maskedTextBoxPeso;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private Button buttonCancelar;
        private Button buttonSalvar;
    }
}