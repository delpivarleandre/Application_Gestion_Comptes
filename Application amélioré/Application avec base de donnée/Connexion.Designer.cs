namespace Application_avec_base_de_donnée
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageCo = new System.Windows.Forms.TabPage();
            this.labelAppli = new System.Windows.Forms.Label();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.buttonCreation = new System.Windows.Forms.Button();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxCO = new System.Windows.Forms.TextBox();
            this.photo1 = new System.Windows.Forms.PictureBox();
            this.PageCompte = new System.Windows.Forms.TabPage();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.AjoutComptes = new System.Windows.Forms.GroupBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.AjouterMotDePasseBox = new System.Windows.Forms.TextBox();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.AjouterReseauBox = new System.Windows.Forms.ComboBox();
            this.Affichermdp = new System.Windows.Forms.Button();
            this.QuitterButton = new System.Windows.Forms.Button();
            this.MDP = new System.Windows.Forms.Label();
            this.DeconnectionButton = new System.Windows.Forms.Button();
            this.adresse = new System.Windows.Forms.Label();
            this.AjouterAdresseBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.PageCo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo1)).BeginInit();
            this.PageCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.AjoutComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageCo);
            this.tabControl1.Controls.Add(this.PageCompte);
            this.tabControl1.Location = new System.Drawing.Point(2, -23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // PageCo
            // 
            this.PageCo.BackColor = System.Drawing.Color.AliceBlue;
            this.PageCo.Controls.Add(this.labelAppli);
            this.PageCo.Controls.Add(this.textBoxMDP);
            this.PageCo.Controls.Add(this.buttonCreation);
            this.PageCo.Controls.Add(this.buttonConnexion);
            this.PageCo.Controls.Add(this.textBoxCO);
            this.PageCo.Controls.Add(this.photo1);
            this.PageCo.Location = new System.Drawing.Point(4, 22);
            this.PageCo.Name = "PageCo";
            this.PageCo.Padding = new System.Windows.Forms.Padding(3);
            this.PageCo.Size = new System.Drawing.Size(740, 445);
            this.PageCo.TabIndex = 0;
            this.PageCo.Text = "Page de connexion";
            // 
            // labelAppli
            // 
            this.labelAppli.AutoSize = true;
            this.labelAppli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppli.Location = new System.Drawing.Point(115, 27);
            this.labelAppli.Name = "labelAppli";
            this.labelAppli.Size = new System.Drawing.Size(124, 25);
            this.labelAppli.TabIndex = 5;
            this.labelAppli.Text = "Connexion";
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMDP.Location = new System.Drawing.Point(103, 212);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(147, 25);
            this.textBoxMDP.TabIndex = 2;
            this.textBoxMDP.Text = "admin";
            this.textBoxMDP.UseSystemPasswordChar = true;
            this.textBoxMDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacourciTouch);
            // 
            // buttonCreation
            // 
            this.buttonCreation.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCreation.Location = new System.Drawing.Point(251, 332);
            this.buttonCreation.Name = "buttonCreation";
            this.buttonCreation.Size = new System.Drawing.Size(94, 31);
            this.buttonCreation.TabIndex = 4;
            this.buttonCreation.Text = "Creation";
            this.buttonCreation.UseVisualStyleBackColor = false;
            this.buttonCreation.Click += new System.EventHandler(this.buttonCreation_Click);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonConnexion.Location = new System.Drawing.Point(102, 257);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(148, 51);
            this.buttonConnexion.TabIndex = 3;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // textBoxCO
            // 
            this.textBoxCO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCO.Location = new System.Drawing.Point(103, 159);
            this.textBoxCO.Name = "textBoxCO";
            this.textBoxCO.Size = new System.Drawing.Size(147, 25);
            this.textBoxCO.TabIndex = 1;
            this.textBoxCO.Text = "admin";
            // 
            // photo1
            // 
            this.photo1.Image = global::Application_avec_base_de_donnée.Properties.Resources.user;
            this.photo1.Location = new System.Drawing.Point(144, 69);
            this.photo1.Name = "photo1";
            this.photo1.Size = new System.Drawing.Size(68, 71);
            this.photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo1.TabIndex = 0;
            this.photo1.TabStop = false;
            // 
            // PageCompte
            // 
            this.PageCompte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PageCompte.Controls.Add(this.DataGV);
            this.PageCompte.Controls.Add(this.AjoutComptes);
            this.PageCompte.Location = new System.Drawing.Point(4, 22);
            this.PageCompte.Name = "PageCompte";
            this.PageCompte.Padding = new System.Windows.Forms.Padding(3);
            this.PageCompte.Size = new System.Drawing.Size(740, 445);
            this.PageCompte.TabIndex = 1;
            this.PageCompte.Text = "Page de gestion";
            // 
            // DataGV
            // 
            this.DataGV.AllowUserToAddRows = false;
            this.DataGV.AllowUserToDeleteRows = false;
            this.DataGV.AllowUserToOrderColumns = true;
            this.DataGV.BackgroundColor = System.Drawing.Color.White;
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.GridColor = System.Drawing.Color.AliceBlue;
            this.DataGV.Location = new System.Drawing.Point(2, 12);
            this.DataGV.Margin = new System.Windows.Forms.Padding(2);
            this.DataGV.Name = "DataGV";
            this.DataGV.ReadOnly = true;
            this.DataGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGV.RowTemplate.Height = 28;
            this.DataGV.Size = new System.Drawing.Size(513, 422);
            this.DataGV.TabIndex = 9;
            this.DataGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGV_RowHeaderMouseClick);
            this.DataGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGV_RowHeaderMouseDoubleClick);
            // 
            // AjoutComptes
            // 
            this.AjoutComptes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AjoutComptes.Controls.Add(this.labeltext);
            this.AjoutComptes.Controls.Add(this.pictureBox1);
            this.AjoutComptes.Controls.Add(this.SupprimerButton);
            this.AjoutComptes.Controls.Add(this.AjouterMotDePasseBox);
            this.AjoutComptes.Controls.Add(this.AjouterButton);
            this.AjoutComptes.Controls.Add(this.AjouterReseauBox);
            this.AjoutComptes.Controls.Add(this.Affichermdp);
            this.AjoutComptes.Controls.Add(this.QuitterButton);
            this.AjoutComptes.Controls.Add(this.MDP);
            this.AjoutComptes.Controls.Add(this.DeconnectionButton);
            this.AjoutComptes.Controls.Add(this.adresse);
            this.AjoutComptes.Controls.Add(this.AjouterAdresseBox);
            this.AjoutComptes.Location = new System.Drawing.Point(522, 12);
            this.AjoutComptes.Margin = new System.Windows.Forms.Padding(2);
            this.AjoutComptes.Name = "AjoutComptes";
            this.AjoutComptes.Padding = new System.Windows.Forms.Padding(2);
            this.AjoutComptes.Size = new System.Drawing.Size(210, 428);
            this.AjoutComptes.TabIndex = 17;
            this.AjoutComptes.TabStop = false;
            this.AjoutComptes.Text = "Connexion";
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(5, 378);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(168, 13);
            this.labeltext.TabIndex = 16;
            this.labeltext.Text = "Vous êtes connecté en tant que : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Application_avec_base_de_donnée.Properties.Resources.icons8_profiles_80;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(85, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.BackColor = System.Drawing.Color.White;
            this.SupprimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SupprimerButton.Location = new System.Drawing.Point(46, 185);
            this.SupprimerButton.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(124, 23);
            this.SupprimerButton.TabIndex = 6;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = false;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // AjouterMotDePasseBox
            // 
            this.AjouterMotDePasseBox.Location = new System.Drawing.Point(85, 44);
            this.AjouterMotDePasseBox.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterMotDePasseBox.Name = "AjouterMotDePasseBox";
            this.AjouterMotDePasseBox.Size = new System.Drawing.Size(96, 20);
            this.AjouterMotDePasseBox.TabIndex = 2;
            this.AjouterMotDePasseBox.UseSystemPasswordChar = true;
            this.AjouterMotDePasseBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacourciTouch1);
            // 
            // AjouterButton
            // 
            this.AjouterButton.BackColor = System.Drawing.Color.White;
            this.AjouterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AjouterButton.Location = new System.Drawing.Point(46, 111);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(124, 23);
            this.AjouterButton.TabIndex = 4;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = false;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            this.AjouterButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacourciTouch);
            // 
            // AjouterReseauBox
            // 
            this.AjouterReseauBox.FormattingEnabled = true;
            this.AjouterReseauBox.Items.AddRange(new object[] {
            "Instagram",
            "Facebook",
            "Twitter",
            "Mail",
            "Autres"});
            this.AjouterReseauBox.Location = new System.Drawing.Point(85, 70);
            this.AjouterReseauBox.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterReseauBox.Name = "AjouterReseauBox";
            this.AjouterReseauBox.Size = new System.Drawing.Size(96, 21);
            this.AjouterReseauBox.TabIndex = 3;
            this.AjouterReseauBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacourciTouch1);
            // 
            // Affichermdp
            // 
            this.Affichermdp.BackColor = System.Drawing.Color.White;
            this.Affichermdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Affichermdp.Location = new System.Drawing.Point(46, 148);
            this.Affichermdp.Margin = new System.Windows.Forms.Padding(2);
            this.Affichermdp.Name = "Affichermdp";
            this.Affichermdp.Size = new System.Drawing.Size(124, 23);
            this.Affichermdp.TabIndex = 5;
            this.Affichermdp.Text = "Afficher";
            this.Affichermdp.UseVisualStyleBackColor = false;
            this.Affichermdp.Click += new System.EventHandler(this.Affichermdp_Click);
            // 
            // QuitterButton
            // 
            this.QuitterButton.BackColor = System.Drawing.Color.White;
            this.QuitterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitterButton.Location = new System.Drawing.Point(46, 338);
            this.QuitterButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuitterButton.Name = "QuitterButton";
            this.QuitterButton.Size = new System.Drawing.Size(124, 23);
            this.QuitterButton.TabIndex = 8;
            this.QuitterButton.Text = "Quitter";
            this.QuitterButton.UseVisualStyleBackColor = false;
            this.QuitterButton.Click += new System.EventHandler(this.QuitterButton_Click);
            // 
            // MDP
            // 
            this.MDP.AutoSize = true;
            this.MDP.Location = new System.Drawing.Point(5, 47);
            this.MDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(77, 13);
            this.MDP.TabIndex = 13;
            this.MDP.Text = "Mot de passe :";
            // 
            // DeconnectionButton
            // 
            this.DeconnectionButton.BackColor = System.Drawing.Color.White;
            this.DeconnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeconnectionButton.Location = new System.Drawing.Point(46, 311);
            this.DeconnectionButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeconnectionButton.Name = "DeconnectionButton";
            this.DeconnectionButton.Size = new System.Drawing.Size(124, 23);
            this.DeconnectionButton.TabIndex = 7;
            this.DeconnectionButton.Text = "Déconnexion";
            this.DeconnectionButton.UseVisualStyleBackColor = false;
            this.DeconnectionButton.Click += new System.EventHandler(this.DeconnectionButton_Click);
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.Location = new System.Drawing.Point(27, 20);
            this.adresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(54, 13);
            this.adresse.TabIndex = 12;
            this.adresse.Text = "Adresse : ";
            // 
            // AjouterAdresseBox
            // 
            this.AjouterAdresseBox.Location = new System.Drawing.Point(85, 16);
            this.AjouterAdresseBox.Margin = new System.Windows.Forms.Padding(2);
            this.AjouterAdresseBox.Name = "AjouterAdresseBox";
            this.AjouterAdresseBox.Size = new System.Drawing.Size(96, 20);
            this.AjouterAdresseBox.TabIndex = 1;
            this.AjouterAdresseBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacourciTouch1);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 374);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gérer les mots de passes";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.tabControl1.ResumeLayout(false);
            this.PageCo.ResumeLayout(false);
            this.PageCo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo1)).EndInit();
            this.PageCompte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.AjoutComptes.ResumeLayout(false);
            this.AjoutComptes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageCo;
        private System.Windows.Forms.PictureBox photo1;
        private System.Windows.Forms.TabPage PageCompte;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Button buttonCreation;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.TextBox textBoxCO;
        private System.Windows.Forms.Label labelAppli;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.GroupBox AjoutComptes;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.TextBox AjouterMotDePasseBox;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.ComboBox AjouterReseauBox;
        private System.Windows.Forms.Button Affichermdp;
        private System.Windows.Forms.Button QuitterButton;
        private System.Windows.Forms.Label MDP;
        private System.Windows.Forms.Button DeconnectionButton;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.TextBox AjouterAdresseBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltext;
    }
}

