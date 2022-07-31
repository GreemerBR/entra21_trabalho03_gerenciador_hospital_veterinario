namespace Entra21.Gerenciador.Hospital.Vet.Views.Consultas
{
    partial class ConsultaCadastroEdicaoForm
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
            this.labelVeterinario = new System.Windows.Forms.Label();
            this.comboBoxVeterinario = new System.Windows.Forms.ComboBox();
            this.labelPet = new System.Windows.Forms.Label();
            this.comboBoxPet = new System.Windows.Forms.ComboBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerHorario = new System.Windows.Forms.DateTimePicker();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.richTextBoxObbservacao = new System.Windows.Forms.RichTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVeterinario
            // 
            this.labelVeterinario.AutoSize = true;
            this.labelVeterinario.Location = new System.Drawing.Point(12, 9);
            this.labelVeterinario.Name = "labelVeterinario";
            this.labelVeterinario.Size = new System.Drawing.Size(77, 15);
            this.labelVeterinario.TabIndex = 0;
            this.labelVeterinario.Text = "Veterinário(a)";
            // 
            // comboBoxVeterinario
            // 
            this.comboBoxVeterinario.DisplayMember = "Nome";
            this.comboBoxVeterinario.FormattingEnabled = true;
            this.comboBoxVeterinario.Location = new System.Drawing.Point(12, 27);
            this.comboBoxVeterinario.Name = "comboBoxVeterinario";
            this.comboBoxVeterinario.Size = new System.Drawing.Size(343, 23);
            this.comboBoxVeterinario.TabIndex = 1;
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Location = new System.Drawing.Point(12, 67);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(26, 15);
            this.labelPet.TabIndex = 0;
            this.labelPet.Text = "PET";
            // 
            // comboBoxPet
            // 
            this.comboBoxPet.DisplayMember = "Nome";
            this.comboBoxPet.FormattingEnabled = true;
            this.comboBoxPet.Location = new System.Drawing.Point(12, 85);
            this.comboBoxPet.Name = "comboBoxPet";
            this.comboBoxPet.Size = new System.Drawing.Size(343, 23);
            this.comboBoxPet.TabIndex = 1;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.CustomFormat = "";
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(12, 145);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(99, 23);
            this.dateTimePickerData.TabIndex = 2;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 127);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 15);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerHorario
            // 
            this.dateTimePickerHorario.CustomFormat = "";
            this.dateTimePickerHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHorario.Location = new System.Drawing.Point(298, 145);
            this.dateTimePickerHorario.Name = "dateTimePickerHorario";
            this.dateTimePickerHorario.Size = new System.Drawing.Size(57, 23);
            this.dateTimePickerHorario.TabIndex = 3;
            this.dateTimePickerHorario.Value = new System.DateTime(2022, 7, 28, 20, 0, 0, 0);
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Location = new System.Drawing.Point(298, 127);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(47, 15);
            this.labelHorario.TabIndex = 0;
            this.labelHorario.Text = "Horário";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(12, 194);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(69, 15);
            this.labelObservacao.TabIndex = 0;
            this.labelObservacao.Text = "Observação";
            // 
            // richTextBoxObbservacao
            // 
            this.richTextBoxObbservacao.Location = new System.Drawing.Point(12, 212);
            this.richTextBoxObbservacao.Name = "richTextBoxObbservacao";
            this.richTextBoxObbservacao.Size = new System.Drawing.Size(343, 97);
            this.richTextBoxObbservacao.TabIndex = 4;
            this.richTextBoxObbservacao.Text = "";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(280, 329);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(199, 329);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ConsultaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 368);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.richTextBoxObbservacao);
            this.Controls.Add(this.dateTimePickerHorario);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.comboBoxPet);
            this.Controls.Add(this.comboBoxVeterinario);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPet);
            this.Controls.Add(this.labelVeterinario);
            this.Name = "ConsultaCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Consultas";
            this.Load += new System.EventHandler(this.ConsultaCadastroEdicaoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelVeterinario;
        private ComboBox comboBoxVeterinario;
        private Label labelPet;
        private ComboBox comboBoxPet;
        private DateTimePicker dateTimePickerData;
        private Label labelData;
        private DateTimePicker dateTimePickerHorario;
        private Label labelHorario;
        private Label labelObservacao;
        private RichTextBox richTextBoxObbservacao;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}