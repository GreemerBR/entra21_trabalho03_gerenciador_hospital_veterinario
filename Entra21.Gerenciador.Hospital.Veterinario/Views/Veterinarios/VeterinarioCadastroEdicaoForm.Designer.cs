namespace Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios
{
    partial class VeterinarioCadastroEdicaoForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.labelCrvm = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxIdade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCrvmNumero = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCrmvUF = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.richTextBoxEspecialidade = new System.Windows.Forms.RichTextBox();
            this.labelEspecialidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(351, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(12, 64);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(51, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(327, 64);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(36, 15);
            this.labelIdade.TabIndex = 2;
            this.labelIdade.Text = "Idade";
            // 
            // labelCrvm
            // 
            this.labelCrvm.AutoSize = true;
            this.labelCrvm.Location = new System.Drawing.Point(126, 64);
            this.labelCrvm.Name = "labelCrvm";
            this.labelCrvm.Size = new System.Drawing.Size(65, 15);
            this.labelCrvm.TabIndex = 2;
            this.labelCrvm.Text = "CRVM / UF";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(12, 82);
            this.maskedTextBoxTelefone.Mask = "(99)99999-9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(84, 23);
            this.maskedTextBoxTelefone.TabIndex = 3;
            // 
            // maskedTextBoxIdade
            // 
            this.maskedTextBoxIdade.Location = new System.Drawing.Point(329, 82);
            this.maskedTextBoxIdade.Mask = "99";
            this.maskedTextBoxIdade.Name = "maskedTextBoxIdade";
            this.maskedTextBoxIdade.Size = new System.Drawing.Size(34, 23);
            this.maskedTextBoxIdade.TabIndex = 3;
            // 
            // maskedTextBoxCrvmNumero
            // 
            this.maskedTextBoxCrvmNumero.Location = new System.Drawing.Point(124, 82);
            this.maskedTextBoxCrvmNumero.Mask = "99999";
            this.maskedTextBoxCrvmNumero.Name = "maskedTextBoxCrvmNumero";
            this.maskedTextBoxCrvmNumero.Size = new System.Drawing.Size(35, 23);
            this.maskedTextBoxCrvmNumero.TabIndex = 3;
            this.maskedTextBoxCrvmNumero.ValidatingType = typeof(int);
            // 
            // textBoxCrmvUF
            // 
            this.textBoxCrmvUF.Location = new System.Drawing.Point(165, 82);
            this.textBoxCrmvUF.Name = "textBoxCrmvUF";
            this.textBoxCrmvUF.Size = new System.Drawing.Size(24, 23);
            this.textBoxCrmvUF.TabIndex = 4;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(220, 82);
            this.maskedTextBoxCpf.Mask = "999.999.999-99";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(84, 23);
            this.maskedTextBoxCpf.TabIndex = 3;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(220, 64);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 2;
            this.labelCpf.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(288, 240);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(207, 240);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // richTextBoxEspecialidade
            // 
            this.richTextBoxEspecialidade.Location = new System.Drawing.Point(12, 142);
            this.richTextBoxEspecialidade.Name = "richTextBoxEspecialidade";
            this.richTextBoxEspecialidade.Size = new System.Drawing.Size(351, 81);
            this.richTextBoxEspecialidade.TabIndex = 6;
            this.richTextBoxEspecialidade.Text = "";
            // 
            // labelEspecialidade
            // 
            this.labelEspecialidade.AutoSize = true;
            this.labelEspecialidade.Location = new System.Drawing.Point(12, 124);
            this.labelEspecialidade.Name = "labelEspecialidade";
            this.labelEspecialidade.Size = new System.Drawing.Size(83, 15);
            this.labelEspecialidade.TabIndex = 2;
            this.labelEspecialidade.Text = "Especialidades";
            // 
            // VeterinarioCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 274);
            this.Controls.Add(this.richTextBoxEspecialidade);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxCrmvUF);
            this.Controls.Add(this.maskedTextBoxCrvmNumero);
            this.Controls.Add(this.maskedTextBoxIdade);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.labelCrvm);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelEspecialidade);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "VeterinarioCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro e Edição de Veterinários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelTelefone;
        private Label labelIdade;
        private Label labelCrvm;
        private MaskedTextBox maskedTextBoxTelefone;
        private MaskedTextBox maskedTextBoxIdade;
        private MaskedTextBox maskedTextBoxCrvmNumero;
        private TextBox textBoxCrmvUF;
        private MaskedTextBox maskedTextBoxCpf;
        private Label labelCpf;
        private Label label1;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private RichTextBox richTextBoxEspecialidade;
        private Label labelEspecialidade;
    }
}