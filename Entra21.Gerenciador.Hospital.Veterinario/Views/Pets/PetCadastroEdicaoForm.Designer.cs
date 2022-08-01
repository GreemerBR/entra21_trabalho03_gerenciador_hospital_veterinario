namespace Entra21.Gerenciador.Hospital.Vet.Views.Pets
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
            this.labelRaca = new System.Windows.Forms.Label();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.radioButtonFenimino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(12, 9);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(40, 15);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome";
            // 
            // Peso2
            // 
            this.Peso2.AutoSize = true;
            this.Peso2.Location = new System.Drawing.Point(12, 64);
            this.Peso2.Name = "Peso2";
            this.Peso2.Size = new System.Drawing.Size(32, 15);
            this.Peso2.TabIndex = 1;
            this.Peso2.Text = "Peso";
            // 
            // LabelIdade
            // 
            this.LabelIdade.AutoSize = true;
            this.LabelIdade.Location = new System.Drawing.Point(161, 64);
            this.LabelIdade.Name = "LabelIdade";
            this.LabelIdade.Size = new System.Drawing.Size(36, 15);
            this.LabelIdade.TabIndex = 2;
            this.LabelIdade.Text = "Idade";
            // 
            // Altura4
            // 
            this.Altura4.AutoSize = true;
            this.Altura4.Location = new System.Drawing.Point(83, 64);
            this.Altura4.Name = "Altura4";
            this.Altura4.Size = new System.Drawing.Size(39, 15);
            this.Altura4.TabIndex = 3;
            this.Altura4.Text = "Altura";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(202, 23);
            this.textBoxNome.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(52, 362);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(78, 23);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(136, 362);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(78, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // comboBoxRaca
            // 
            this.comboBoxRaca.DisplayMember = "Nome";
            this.comboBoxRaca.FormattingEnabled = true;
            this.comboBoxRaca.Location = new System.Drawing.Point(12, 139);
            this.comboBoxRaca.Name = "comboBoxRaca";
            this.comboBoxRaca.Size = new System.Drawing.Size(202, 23);
            this.comboBoxRaca.TabIndex = 14;
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(12, 121);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(32, 15);
            this.labelRaca.TabIndex = 15;
            this.labelRaca.Text = "Raça";
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.DisplayMember = "Nome";
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(12, 195);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(202, 23);
            this.comboBoxResponsavel.TabIndex = 16;
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(12, 177);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(72, 15);
            this.labelResponsavel.TabIndex = 17;
            this.labelResponsavel.Text = "Responsavel";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(12, 239);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 15);
            this.labelGenero.TabIndex = 21;
            this.labelGenero.Text = "Gênero";
            // 
            // radioButtonFenimino
            // 
            this.radioButtonFenimino.AutoSize = true;
            this.radioButtonFenimino.Location = new System.Drawing.Point(12, 257);
            this.radioButtonFenimino.Name = "radioButtonFenimino";
            this.radioButtonFenimino.Size = new System.Drawing.Size(75, 19);
            this.radioButtonFenimino.TabIndex = 22;
            this.radioButtonFenimino.TabStop = true;
            this.radioButtonFenimino.Text = "Fenimino";
            this.radioButtonFenimino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(12, 282);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioButtonMasculino.TabIndex = 23;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(12, 82);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(45, 23);
            this.textBoxPeso.TabIndex = 24;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(83, 82);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(45, 23);
            this.textBoxAltura.TabIndex = 24;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(161, 82);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(45, 23);
            this.textBoxIdade.TabIndex = 24;
            // 
            // PetCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 400);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.radioButtonFenimino);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Altura4);
            this.Controls.Add(this.LabelIdade);
            this.Controls.Add(this.Peso2);
            this.Controls.Add(this.LabelNome);
            this.Name = "PetCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro dos Pets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNome;
        private Label Peso2;
        private Label LabelIdade;
        private Label Altura4;
        private TextBox textBoxNome;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private ComboBox comboBoxRaca;
        private Label labelRaca;
        private ComboBox comboBoxResponsavel;
        private Label labelResponsavel;
        private Label labelGenero;
        private RadioButton radioButtonFenimino;
        private RadioButton radioButtonMasculino;
        private TextBox textBoxPeso;
        private TextBox textBoxAltura;
        private TextBox textBoxIdade;
    }
}