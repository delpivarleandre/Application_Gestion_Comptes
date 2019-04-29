using System;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            textBoxNDCProfil.Text= Connexion.login.GetUser();
            textBoxMDPProfil.Text = Connexion.login.GetMdp();
            textBoxCodeProfil.Text = Convert.ToString(Connexion.login.GetCode());
        }

        private void buttonModifierProfil_Click(object sender, EventArgs e)
        {
            Connexion.login.SetNDCProfil(textBoxNDCProfil.Text);
            Connexion.login.SetMDPProfil(textBoxMDPProfil.Text);
            int codeprofil = Convert.ToInt32(textBoxCodeProfil.Text);
            Connexion.login.SetCodeProfil(codeprofil);
            if (Connexion.login.validloginprofil() == 1)
            {
                MessageBox.Show("Nom de compte déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connexion.login.ChangementLogin();
                Close();
            }
        }
    }
}
