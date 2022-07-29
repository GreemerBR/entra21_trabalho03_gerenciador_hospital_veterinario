namespace Entra21.Gerenciador.Hospital.Vet.Views.Racas
{
    partial class RacaCadastroEdicaoForm
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
            this.textBoxEspécie1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEspecie = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEspécie1
            // 
            this.textBoxEspécie1.AutoSize = true;
            this.textBoxEspécie1.Location = new System.Drawing.Point(12, 83);
            this.textBoxEspécie1.Name = "textBoxEspécie1";
            this.textBoxEspécie1.Size = new System.Drawing.Size(46, 15);
            this.textBoxEspécie1.TabIndex = 0;
            this.textBoxEspécie1.Text = "Espécie";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome2_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 37);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(322, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxEspecie
            // 
            this.textBoxEspecie.Location = new System.Drawing.Point(12, 101);
            this.textBoxEspecie.Name = "textBoxEspecie";
            this.textBoxEspecie.Size = new System.Drawing.Size(322, 23);
            this.textBoxEspecie.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(280, 172);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(176, 172);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // RacaCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 205);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxEspecie);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.textBoxEspécie1);
            this.Name = "RacaCadastroEdicaoForm";
            this.Text = "Cadastro da Raça";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textBoxEspécie1;
        private Label Nome;
        private TextBox textBoxNome;
        private TextBox textBoxEspecie;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}