namespace Entra21.Gerenciador.Hospital.Vet.Views
{
    partial class MenuForm
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
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.buttonEndereco = new System.Windows.Forms.Button();
            this.buttonPet = new System.Windows.Forms.Button();
            this.buttonRaca = new System.Windows.Forms.Button();
            this.buttonResponsavel = new System.Windows.Forms.Button();
            this.buttonVeterinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(22, 25);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(98, 54);
            this.buttonConsulta.TabIndex = 0;
            this.buttonConsulta.Text = "Consulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            // 
            // buttonEndereco
            // 
            this.buttonEndereco.Location = new System.Drawing.Point(147, 25);
            this.buttonEndereco.Name = "buttonEndereco";
            this.buttonEndereco.Size = new System.Drawing.Size(98, 54);
            this.buttonEndereco.TabIndex = 0;
            this.buttonEndereco.Text = "Endereço";
            this.buttonEndereco.UseVisualStyleBackColor = true;
            this.buttonEndereco.Click += new System.EventHandler(this.buttonEndereco_Click);
            // 
            // buttonPet
            // 
            this.buttonPet.Location = new System.Drawing.Point(275, 25);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(98, 54);
            this.buttonPet.TabIndex = 0;
            this.buttonPet.Text = "Pet";
            this.buttonPet.UseVisualStyleBackColor = true;
            // 
            // buttonRaca
            // 
            this.buttonRaca.Location = new System.Drawing.Point(22, 108);
            this.buttonRaca.Name = "buttonRaca";
            this.buttonRaca.Size = new System.Drawing.Size(98, 54);
            this.buttonRaca.TabIndex = 0;
            this.buttonRaca.Text = "Raça";
            this.buttonRaca.UseVisualStyleBackColor = true;
            // 
            // buttonResponsavel
            // 
            this.buttonResponsavel.Location = new System.Drawing.Point(147, 108);
            this.buttonResponsavel.Name = "buttonResponsavel";
            this.buttonResponsavel.Size = new System.Drawing.Size(98, 54);
            this.buttonResponsavel.TabIndex = 0;
            this.buttonResponsavel.Text = "Responsável";
            this.buttonResponsavel.UseVisualStyleBackColor = true;
            this.buttonResponsavel.Click += new System.EventHandler(this.buttonResponsavel_Click);
            // 
            // buttonVeterinario
            // 
            this.buttonVeterinario.Location = new System.Drawing.Point(275, 108);
            this.buttonVeterinario.Name = "buttonVeterinario";
            this.buttonVeterinario.Size = new System.Drawing.Size(98, 54);
            this.buttonVeterinario.TabIndex = 0;
            this.buttonVeterinario.Text = "Veterinário(a)";
            this.buttonVeterinario.UseVisualStyleBackColor = true;
            this.buttonVeterinario.Click += new System.EventHandler(this.buttonVeterinario_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 179);
            this.Controls.Add(this.buttonVeterinario);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.buttonResponsavel);
            this.Controls.Add(this.buttonEndereco);
            this.Controls.Add(this.buttonRaca);
            this.Controls.Add(this.buttonConsulta);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonConsulta;
        private Button buttonEndereco;
        private Button buttonPet;
        private Button buttonRaca;
        private Button buttonResponsavel;
        private Button buttonVeterinario;
    }
}