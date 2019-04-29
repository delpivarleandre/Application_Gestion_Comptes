namespace Application_avec_base_de_donnée
{
    partial class CreationPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreationPage));
            this.labelCrea = new System.Windows.Forms.Label();
            this.buttonAnnule = new System.Windows.Forms.Button();
            this.buttonCrea = new System.Windows.Forms.Button();
            this.TextBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxCREA = new PHTextBox("Nom d'utilisateur");
            this.textBoxMDPCrea = new PHTextBox("Mot de passe");
            this.TextBoxCode = new PHTextBox("Entrer un nombre a 4 chiffres");
            this.SuspendLayout();
            // 
            // labelCrea
            // 
            this.labelCrea.AutoSize = true;
            this.labelCrea.BackColor = System.Drawing.Color.Transparent;
            this.labelCrea.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelCrea.ForeColor = System.Drawing.Color.Black;
            this.labelCrea.Location = new System.Drawing.Point(75, 35);
            this.labelCrea.Name = "labelCrea";
            this.labelCrea.Size = new System.Drawing.Size(207, 30);
            this.labelCrea.TabIndex = 11;
            this.labelCrea.Text = "Création du compte";
            // 
            // buttonAnnule
            // 
            this.buttonAnnule.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAnnule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAnnule.ForeColor = System.Drawing.Color.Black;
            this.buttonAnnule.Location = new System.Drawing.Point(104, 287);
            this.buttonAnnule.Name = "buttonAnnule";
            this.buttonAnnule.Size = new System.Drawing.Size(138, 51);
            this.buttonAnnule.TabIndex = 4;
            this.buttonAnnule.Text = "Retour";
            this.buttonAnnule.UseVisualStyleBackColor = false;
            this.buttonAnnule.Click += new System.EventHandler(this.buttonAnnule_Click);
            // 
            // buttonCrea
            // 
            this.buttonCrea.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCrea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCrea.ForeColor = System.Drawing.Color.Black;
            this.buttonCrea.Location = new System.Drawing.Point(8, 221);
            this.buttonCrea.Name = "buttonCrea";
            this.buttonCrea.Size = new System.Drawing.Size(337, 35);
            this.buttonCrea.TabIndex = 12;
            this.buttonCrea.Text = "Création";
            this.buttonCrea.UseVisualStyleBackColor = false;
            this.buttonCrea.Click += new System.EventHandler(this.buttonCrea_Click);
            // 
            // TextBoxCode
            // 
            this.TextBoxCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxCode.Location = new System.Drawing.Point(80, 171);
            this.TextBoxCode.Multiline = true;
            this.TextBoxCode.Name = "TextBoxCode";
            this.TextBoxCode.Size = new System.Drawing.Size(202, 25);
            this.TextBoxCode.TabIndex = 12;
            // 
            // textBoxCREA
            // 
            this.textBoxCREA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCREA.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCREA.Location = new System.Drawing.Point(80, 83);
            this.textBoxCREA.Name = "textBoxCREA";
            this.textBoxCREA.PlaceHolderText = "Nom de compte";
            this.textBoxCREA.Size = new System.Drawing.Size(202, 25);
            this.textBoxCREA.TabIndex = 10;
            this.textBoxCREA.Text = "Nom de compte";
            // 
            // textBoxMDPCrea
            // 
            this.textBoxMDPCrea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMDPCrea.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMDPCrea.Location = new System.Drawing.Point(80, 125);
            this.textBoxMDPCrea.Name = "textBoxMDPCrea";
            this.textBoxMDPCrea.PlaceHolderText = "Mot de passe";
            this.textBoxMDPCrea.Size = new System.Drawing.Size(202, 25);
            this.textBoxMDPCrea.TabIndex = 11;
            this.textBoxMDPCrea.Text = "Mot de passe";
            this.textBoxMDPCrea.TextChanged += new System.EventHandler(this.textBoxMDPCrea_TextChanged);
            // 
            // CreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(357, 403);
            this.Controls.Add(this.TextBoxCode);
            this.Controls.Add(this.labelCrea);
            this.Controls.Add(this.textBoxMDPCrea);
            this.Controls.Add(this.buttonAnnule);
            this.Controls.Add(this.buttonCrea);
            this.Controls.Add(this.textBoxCREA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerer les mots de passes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCrea;
        private System.Windows.Forms.Button buttonAnnule;
        private System.Windows.Forms.Button buttonCrea;
        private PHTextBox textBoxMDPCrea;
        private PHTextBox textBoxCREA;
        private System.Windows.Forms.TextBox TextBoxCode;
    }
}

