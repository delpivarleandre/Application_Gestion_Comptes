using System; //importe les principales fonctionnalites du Framework.
using System.Windows.Forms; //Permet la creation d'applications windows.


namespace Application_avec_base_de_donnée
{
    
    public partial class CreationPage : Form
    {
        
            public CreationPage()
            {
            InitializeComponent();
            }

        login login = new login();

        private void buttonAnnule_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCrea_Click(object sender, EventArgs e)
        {
            login.SetUserCrea(textBoxCREA.Text);
            login.SetMdpCrea(textBoxMDPCrea.Text);
            int code = Convert.ToInt32(TextBoxCode.Text);
            login.SetCode(code);
            if (login.validloginCrea() == 1)
            {
                MessageBox.Show("Nom de compte déjà utilisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                login.CreationLogin();
                Close();

            }
            textBoxCREA.Text = "";
            textBoxMDPCrea.Text = "";
        }

        private void textBoxMDPCrea_TextChanged(object sender, EventArgs e)
        {
            textBoxMDPCrea.UseSystemPasswordChar = true;
        }
    }
}

