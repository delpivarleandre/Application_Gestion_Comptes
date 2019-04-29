namespace Application_avec_base_de_donnée
{
    partial class Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code));
            this.TextBoxReponseCode = new System.Windows.Forms.TextBox();
            this.buttonVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxReponseCode
            // 
            this.TextBoxReponseCode.Location = new System.Drawing.Point(12, 12);
            this.TextBoxReponseCode.Multiline = true;
            this.TextBoxReponseCode.Name = "TextBoxReponseCode";
            this.TextBoxReponseCode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReponseCode.TabIndex = 0;
            this.TextBoxReponseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonVal
            // 
            this.buttonVal.Location = new System.Drawing.Point(26, 38);
            this.buttonVal.Name = "buttonVal";
            this.buttonVal.Size = new System.Drawing.Size(75, 23);
            this.buttonVal.TabIndex = 1;
            this.buttonVal.Text = "Validation";
            this.buttonVal.UseVisualStyleBackColor = true;
            this.buttonVal.Click += new System.EventHandler(this.buttonVal_Click);
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 78);
            this.Controls.Add(this.buttonVal);
            this.Controls.Add(this.TextBoxReponseCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saisir le code : ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxReponseCode;
        private System.Windows.Forms.Button buttonVal;
    }
}