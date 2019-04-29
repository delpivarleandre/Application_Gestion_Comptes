namespace Application_avec_base_de_donnée
{
    partial class affichage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(affichage));
            this.labelnomreseau = new System.Windows.Forms.Label();
            this.labelnomdecompte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelReseauAffiche = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelmotdepasse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxaddpic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnomreseau
            // 
            this.labelnomreseau.AutoSize = true;
            this.labelnomreseau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomreseau.Location = new System.Drawing.Point(134, 77);
            this.labelnomreseau.Name = "labelnomreseau";
            this.labelnomreseau.Size = new System.Drawing.Size(0, 25);
            this.labelnomreseau.TabIndex = 0;
            // 
            // labelnomdecompte
            // 
            this.labelnomdecompte.AutoSize = true;
            this.labelnomdecompte.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomdecompte.Location = new System.Drawing.Point(248, 77);
            this.labelnomdecompte.Name = "labelnomdecompte";
            this.labelnomdecompte.Size = new System.Drawing.Size(0, 25);
            this.labelnomdecompte.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // labelReseauAffiche
            // 
            this.labelReseauAffiche.AutoSize = true;
            this.labelReseauAffiche.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReseauAffiche.Location = new System.Drawing.Point(134, 27);
            this.labelReseauAffiche.Name = "labelReseauAffiche";
            this.labelReseauAffiche.Size = new System.Drawing.Size(71, 25);
            this.labelReseauAffiche.TabIndex = 3;
            this.labelReseauAffiche.Text = "Réseau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom de compte";
            // 
            // labelmotdepasse
            // 
            this.labelmotdepasse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmotdepasse.Location = new System.Drawing.Point(430, 77);
            this.labelmotdepasse.Name = "labelmotdepasse";
            this.labelmotdepasse.Size = new System.Drawing.Size(124, 25);
            this.labelmotdepasse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mot de passe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxaddpic
            // 
            this.textBoxaddpic.Location = new System.Drawing.Point(14, 143);
            this.textBoxaddpic.Name = "textBoxaddpic";
            this.textBoxaddpic.Size = new System.Drawing.Size(100, 20);
            this.textBoxaddpic.TabIndex = 8;
            this.textBoxaddpic.TextChanged += new System.EventHandler(this.textBoxaddpic_TextChanged);
            // 
            // affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 214);
            this.Controls.Add(this.textBoxaddpic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelmotdepasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelReseauAffiche);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelnomdecompte);
            this.Controls.Add(this.labelnomreseau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "affichage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnomreseau;
        private System.Windows.Forms.Label labelnomdecompte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelReseauAffiche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelmotdepasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxaddpic;
    }
}