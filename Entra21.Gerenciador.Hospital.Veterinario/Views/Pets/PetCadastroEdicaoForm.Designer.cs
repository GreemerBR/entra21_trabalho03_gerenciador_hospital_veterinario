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
            this.maskedTextBoxIdade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonFemea = new System.Windows.Forms.RadioButton();
            this.radioButtonMacho = new System.Windows.Forms.RadioButton();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxRaca = new System.Windows.Forms.ComboBox();
            this.labelRaca = new System.Windows.Forms.Label();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.groupBoxGenero.SuspendLayout();
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
            this.Peso2.Location = new System.Drawing.Point(12, 62);
            this.Peso2.Name = "Peso2";
            this.Peso2.Size = new System.Drawing.Size(32, 15);
            this.Peso2.TabIndex = 1;
            this.Peso2.Text = "Peso";
            // 
            // LabelIdade
            // 
            this.LabelIdade.AutoSize = true;
            this.LabelIdade.Location = new System.Drawing.Point(148, 68);
            this.LabelIdade.Name = "LabelIdade";
            this.LabelIdade.Size = new System.Drawing.Size(36, 15);
            this.LabelIdade.TabIndex = 2;
            this.LabelIdade.Text = "Idade";
            // 
            // Altura4
            // 
            this.Altura4.AutoSize = true;
            this.Altura4.Location = new System.Drawing.Point(82, 64);
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
            // maskedTextBoxIdade
            // 
            this.maskedTextBoxIdade.Location = new System.Drawing.Point(148, 86);
            this.maskedTextBoxIdade.Mask = "99";
            this.maskedTextBoxIdade.Name = "maskedTextBoxIdade";
            this.maskedTextBoxIdade.Size = new System.Drawing.Size(66, 23);
            this.maskedTextBoxIdade.TabIndex = 6;
            // 
            // maskedTextBoxAltura
            // 
            this.maskedTextBoxAltura.Location = new System.Drawing.Point(81, 86);
            this.maskedTextBoxAltura.Mask = "9,99";
            this.maskedTextBoxAltura.Name = "maskedTextBoxAltura";
            this.maskedTextBoxAltura.Size = new System.Drawing.Size(47, 23);
            this.maskedTextBoxAltura.TabIndex = 7;
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.Location = new System.Drawing.Point(12, 86);
            this.maskedTextBoxPeso.Mask = "999,99";
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.Size = new System.Drawing.Size(47, 23);
            this.maskedTextBoxPeso.TabIndex = 8;
            // 
            // radioButtonFemea
            // 
            this.radioButtonFemea.AutoSize = true;
            this.radioButtonFemea.Location = new System.Drawing.Point(6, 56);
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
            this.radioButtonMacho.Location = new System.Drawing.Point(6, 30);
            this.radioButtonMacho.Name = "radioButtonMacho";
            this.radioButtonMacho.Size = new System.Drawing.Size(62, 19);
            this.radioButtonMacho.TabIndex = 10;
            this.radioButtonMacho.TabStop = true;
            this.radioButtonMacho.Text = "Macho";
            this.radioButtonMacho.UseVisualStyleBackColor = true;
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
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonMacho);
            this.groupBoxGenero.Controls.Add(this.radioButtonFemea);
            this.groupBoxGenero.Location = new System.Drawing.Point(14, 246);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGenero.TabIndex = 18;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Gênero";
            // 
            // PetCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 400);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.comboBoxRaca);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxPeso);
            this.Controls.Add(this.maskedTextBoxAltura);
            this.Controls.Add(this.maskedTextBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Altura4);
            this.Controls.Add(this.LabelIdade);
            this.Controls.Add(this.Peso2);
            this.Controls.Add(this.LabelNome);
            this.Name = "PetCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro dos Pets";
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNome;
        private Label Peso2;
        private Label LabelIdade;
        private Label Altura4;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxIdade;
        private MaskedTextBox maskedTextBoxAltura;
        private MaskedTextBox maskedTextBoxPeso;
        private RadioButton radioButtonFemea;
        private RadioButton radioButtonMacho;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private ComboBox comboBoxRaca;
        private Label labelRaca;
        private ComboBox comboBoxResponsavel;
        private Label labelResponsavel;
        private GroupBox groupBoxGenero;
    }
}