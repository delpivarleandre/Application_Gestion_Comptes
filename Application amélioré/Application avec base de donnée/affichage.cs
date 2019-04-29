using System;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    public partial class affichage : Form
    {
        public affichage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelnomreseau.Text = Connexion.stockage.GetnomReseau();
            labelnomdecompte.Text = Connexion.stockage.GetnomAdresse();
            labelmotdepasse.Text = Connexion.stockage.GetnomMotdepasse();
            Connexion.stockage.UrlImage();
            button1.Visible = false;
            textBoxaddpic.Visible = false;
            pictureBox1.ImageLocation = Connexion.stockage.GetLinkUrl();
        }
        private void button1_Click(object sender, EventArgs e)
        {           
            pictureBox1.ImageLocation = textBoxaddpic.Text;
            Connexion.stockage.SetLinkUrl(textBoxaddpic.Text);
            button1.Visible = false;
            textBoxaddpic.Visible = false;
            Connexion.stockage.AjouterUrl();
        }

        private void textBoxaddpic_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                button1.Visible = true;
                textBoxaddpic.Visible = true;
            }
        }
    }
}
