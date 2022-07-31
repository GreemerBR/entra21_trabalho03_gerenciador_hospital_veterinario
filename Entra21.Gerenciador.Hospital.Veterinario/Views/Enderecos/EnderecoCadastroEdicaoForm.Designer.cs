namespace Entra21.Gerenciador.Hospital.Vet.Views.Enderecos
{
    partial class EnderecoCadastroEdicaoForm
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
            this.labelCep = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelUnidadeFederativa = new System.Windows.Forms.Label();
            this.labelResponsavel = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.comboBoxResponsavel = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.maskedTextBoxUnidadeFederativa = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(12, 9);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 0;
            this.labelCep.Text = "Cep";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(12, 53);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(69, 15);
            this.labelLogradouro.TabIndex = 1;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(12, 97);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(38, 15);
            this.labelBairro.TabIndex = 2;
            this.labelBairro.Text = "Bairro";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 141);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 15);
            this.labelCidade.TabIndex = 3;
            this.labelCidade.Text = "Cidade";
            // 
            // labelUnidadeFederativa
            // 
            this.labelUnidadeFederativa.AutoSize = true;
            this.labelUnidadeFederativa.Location = new System.Drawing.Point(12, 185);
            this.labelUnidadeFederativa.Name = "labelUnidadeFederativa";
            this.labelUnidadeFederativa.Size = new System.Drawing.Size(108, 15);
            this.labelUnidadeFederativa.TabIndex = 4;
            this.labelUnidadeFederativa.Text = "Unidade Federativa";
            // 
            // labelResponsavel
            // 
            this.labelResponsavel.AutoSize = true;
            this.labelResponsavel.Location = new System.Drawing.Point(12, 229);
            this.labelResponsavel.Name = "labelResponsavel";
            this.labelResponsavel.Size = new System.Drawing.Size(72, 15);
            this.labelResponsavel.TabIndex = 5;
            this.labelResponsavel.Text = "Responsavel";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Location = new System.Drawing.Point(12, 71);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(198, 23);
            this.textBoxLogradouro.TabIndex = 7;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(12, 115);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(198, 23);
            this.textBoxBairro.TabIndex = 8;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(12, 159);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(198, 23);
            this.textBoxCidade.TabIndex = 9;
            // 
            // comboBoxResponsavel
            // 
            this.comboBoxResponsavel.DisplayMember = "nome";
            this.comboBoxResponsavel.FormattingEnabled = true;
            this.comboBoxResponsavel.Location = new System.Drawing.Point(12, 247);
            this.comboBoxResponsavel.Name = "comboBoxResponsavel";
            this.comboBoxResponsavel.Size = new System.Drawing.Size(198, 23);
            this.comboBoxResponsavel.TabIndex = 11;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(12, 27);
            this.maskedTextBoxCep.Mask = "99999-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(198, 23);
            this.maskedTextBoxCep.TabIndex = 12;
            this.maskedTextBoxCep.Leave += new System.EventHandler(this.maskedTextBoxCep_Leave_1);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(121, 276);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(89, 23);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 276);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // maskedTextBoxUnidadeFederativa
            // 
            this.maskedTextBoxUnidadeFederativa.Location = new System.Drawing.Point(12, 203);
            this.maskedTextBoxUnidadeFederativa.Mask = "aa";
            this.maskedTextBoxUnidadeFederativa.Name = "maskedTextBoxUnidadeFederativa";
            this.maskedTextBoxUnidadeFederativa.Size = new System.Drawing.Size(198, 23);
            this.maskedTextBoxUnidadeFederativa.TabIndex = 15;
            // 
            // EnderecoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 314);
            this.Controls.Add(this.maskedTextBoxUnidadeFederativa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.comboBoxResponsavel);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxLogradouro);
            this.Controls.Add(this.labelResponsavel);
            this.Controls.Add(this.labelUnidadeFederativa);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelLogradouro);
            this.Controls.Add(this.labelCep);
            this.Name = "EnderecoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnderecoCadastroEdicaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelCep;
        private Label labelLogradouro;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelUnidadeFederativa;
        private Label labelResponsavel;
        private TextBox textBoxLogradouro;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private ComboBox comboBoxResponsavel;
        private MaskedTextBox maskedTextBoxCep;
        private Button buttonSalvar;
        private Button buttonCancelar;
        private MaskedTextBox maskedTextBoxUnidadeFederativa;
    }
}