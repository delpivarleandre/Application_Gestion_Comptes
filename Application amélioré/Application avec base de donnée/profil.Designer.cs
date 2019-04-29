namespace Application_avec_base_de_donnée
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.labelNDCProfil = new System.Windows.Forms.Label();
            this.textBoxNDCProfil = new System.Windows.Forms.TextBox();
            this.textBoxMDPProfil = new System.Windows.Forms.TextBox();
            this.labelMDPProfil = new System.Windows.Forms.Label();
            this.textBoxCodeProfil = new System.Windows.Forms.TextBox();
            this.labelCodeProfil = new System.Windows.Forms.Label();
            this.buttonModifierProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNDCProfil
            // 
            this.labelNDCProfil.AutoSize = true;
            this.labelNDCProfil.Location = new System.Drawing.Point(14, 33);
            this.labelNDCProfil.Name = "labelNDCProfil";
            this.labelNDCProfil.Size = new System.Drawing.Size(91, 13);
            this.labelNDCProfil.TabIndex = 0;
            this.labelNDCProfil.Text = "Nom de compte : ";
            // 
            // textBoxNDCProfil
            // 
            this.textBoxNDCProfil.Location = new System.Drawing.Point(111, 30);
            this.textBoxNDCProfil.Name = "textBoxNDCProfil";
            this.textBoxNDCProfil.Size = new System.Drawing.Size(100, 20);
            this.textBoxNDCProfil.TabIndex = 2;
            // 
            // textBoxMDPProfil
            // 
            this.textBoxMDPProfil.Location = new System.Drawing.Point(111, 67);
            this.textBoxMDPProfil.Name = "textBoxMDPProfil";
            this.textBoxMDPProfil.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDPProfil.TabIndex = 3;
            this.textBoxMDPProfil.UseSystemPasswordChar = true;
            // 
            // labelMDPProfil
            // 
            this.labelMDPProfil.AutoSize = true;
            this.labelMDPProfil.Location = new System.Drawing.Point(25, 70);
            this.labelMDPProfil.Name = "labelMDPProfil";
            this.labelMDPProfil.Size = new System.Drawing.Size(80, 13);
            this.labelMDPProfil.TabIndex = 2;
            this.labelMDPProfil.Text = "Mot de passe : ";
            // 
            // textBoxCodeProfil
            // 
            this.textBoxCodeProfil.Location = new System.Drawing.Point(111, 105);
            this.textBoxCodeProfil.Name = "textBoxCodeProfil";
            this.textBoxCodeProfil.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodeProfil.TabIndex = 4;
            this.textBoxCodeProfil.UseSystemPasswordChar = true;
            // 
            // labelCodeProfil
            // 
            this.labelCodeProfil.AutoSize = true;
            this.labelCodeProfil.Location = new System.Drawing.Point(64, 108);
            this.labelCodeProfil.Name = "labelCodeProfil";
            this.labelCodeProfil.Size = new System.Drawing.Size(41, 13);
            this.labelCodeProfil.TabIndex = 4;
            this.labelCodeProfil.Text = "Code : ";
            // 
            // buttonModifierProfil
            // 
            this.buttonModifierProfil.Location = new System.Drawing.Point(80, 150);
            this.buttonModifierProfil.Name = "buttonModifierProfil";
            this.buttonModifierProfil.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierProfil.TabIndex = 1;
            this.buttonModifierProfil.Text = "Modifer";
            this.buttonModifierProfil.UseVisualStyleBackColor = true;
            this.buttonModifierProfil.Click += new System.EventHandler(this.buttonModifierProfil_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 204);
            this.Controls.Add(this.buttonModifierProfil);
            this.Controls.Add(this.textBoxCodeProfil);
            this.Controls.Add(this.labelCodeProfil);
            this.Controls.Add(this.textBoxMDPProfil);
            this.Controls.Add(this.labelMDPProfil);
            this.Controls.Add(this.textBoxNDCProfil);
            this.Controls.Add(this.labelNDCProfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNDCProfil;
        private System.Windows.Forms.TextBox textBoxNDCProfil;
        private System.Windows.Forms.TextBox textBoxMDPProfil;
        private System.Windows.Forms.Label labelMDPProfil;
        private System.Windows.Forms.TextBox textBoxCodeProfil;
        private System.Windows.Forms.Label labelCodeProfil;
        private System.Windows.Forms.Button buttonModifierProfil;
    }
}