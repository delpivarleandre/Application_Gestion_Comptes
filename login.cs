using Microsoft.VisualBasic.FileIO; //Permet de gerer fichier.txt / donnees. 
using System; //importe les principales fonctionnalites du Framework.
using System.IO; //Permet la lecture ou l'ecriture dans des fichiers ou flux de donnees.
using System.Windows.Forms; //Permet la creation d'applications windows.
using System.Security.Cryptography; //Fournit des services de chiffrement, comprenant l'encodage et le décodage sécurisé des données.
using System.Text; //Permet des encodages de caractères ASCII et Unicode.

namespace Appli
{

    public partial class login : Form
    {
        //Pour savoir si le bouton est a l'etat 0 ou 1.
        bool affectation = true;

        public static string Chiffrer(string text)
        {
            //Methode base64(64 caracteres) pour chiffrer les mots de passes.
            return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser));
            //protectedData = System.Security.Cryptography
            //Encoding = System.Text
        }

        public static string Dechiffrer(string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser));
        }

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

            using (TextFieldParser parser = new TextFieldParser(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Comptes.txt")))
            {
                //Ouvrir le document texte a l'ouverture de la page 
                parser.Delimiters = new string[] { "," };
                while (true)
                {
                    string[] LineData = parser.ReadFields();
                    if (LineData == null)
                    {
                        break;
                    }
                    //Ajouter les lignes 
                    DataGV.Rows.Add(new object[] { LineData[0], LineData[1], LineData[2] });
                }

                //Dimensionne automatiquement le DataGrid
                DataGV.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                DataGV.AllowUserToAddRows = false;
            }
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            //Entrer dans le compte.
            if (textBoxNomDeCompte.Text == "admin" && textBoxMotDePasse.Text == "admin")
            {
                //Taille de la 2 eme page.
                tabControl1.SelectedTab = tabPage2;
                Size = new System.Drawing.Size(568, 339);
            }
            else
            {
                MessageBox.Show("Nom de compte ou mot de passe incorrect ");
            }

            //Remplace ce qui est ecrit par du vide.
            textBoxNomDeCompte.Text = "";
            textBoxMotDePasse.Text = "";
        }

        private void creation_Click(object sender, EventArgs e)
        {
            //Ouvre la page ajouter.
            ajouter ajouter = new ajouter();
            ajouter.Show();

            MessageBox.Show("Maintenance");
            ajouter.Close();
        }

        private void textBoxCompte_KeyDown(object sender, KeyEventArgs e)
        {
            // pouvoir appuyer sur entrer (connexion).
            if (e.KeyCode == Keys.Enter)
            {
                connexion_Click(this, new EventArgs());
            }
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            //ajouter ce qu'on ecrit dans les TextBoxs avec chiffrage du mot de passe.
            string mdp2 = AjouterMotDePasseBox.Text.ToString();
            mdp2 = Chiffrer(mdp2);
            DataGV.AllowUserToAddRows = false;
            DataGV.Rows.Add(AjouterReseauBox.Text, AjouterAdresseBox.Text, mdp2);
            //Remplacer le texte pas du vide apres l'ajout.
            AjouterMotDePasseBox.Text = "";
            AjouterAdresseBox.Text = "";
            AjouterReseauBox.Text = "";
        }

        private void Affichermdp_Click(object sender, EventArgs e)
        {
            try
            {
                //Afficher le mot de passe ou non.
                if (affectation == true)
                {
                    for (int r = 0; r < DataGV.Rows.Count; r++)
                    {
                        if (DataGV[2, r].Value != null)
                        {
                            string mdp = DataGV[2, r].Value.ToString();
                            DataGV[2, r].Value = Dechiffrer(mdp);
                        }
                    }
                    affectation = false;
                }
                else
                {
                    for (int r = 0; r < DataGV.Rows.Count; r++)
                    {
                        if (DataGV[2, r].Value != null)
                        {
                            string mdp = DataGV[2, r].Value.ToString();
                            DataGV[2, r].Value = Chiffrer(mdp);
                        }
                    }
                    affectation = true;
                }
            }
            catch (Exception PB)
            {
                MessageBox.Show(PB.Message);
            }
        }

        private void SauvegarderButton_Click_1(object sender, EventArgs e)
        {
            //Sauvegarder les comptes.
            TextWriter writer = new StreamWriter(@"Comptes.txt");
            //En fonction du nombre de lignes .
            for (int i = 0; i < DataGV.Rows.Count; i++)
            {
                //En fonction du nombre de colonnes. 
                for (int j = 0; j < DataGV.Columns.Count; j++)
                {
                    writer.Write(DataGV.Rows[i].Cells[j].Value.ToString() + ",");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Sauvegardé");
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            //Suprimer ligne du tableau avec une verification si l'on veut vraiment le fermer.
            if (MessageBox.Show("Voulez vous vraiment supprimer l'adresse ?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    int index = DataGV.SelectedRows[0].Index;
                    DataGV.Rows.RemoveAt(index);
                }
                catch (Exception Bug)
                {
                    MessageBox.Show(Bug.Message);
                }

            }
        }

        private void DeconnectionButton_Click(object sender, EventArgs e)
        {
            //Passer de la page 1 a la page 2.
            tabControl1.SelectedTab = tabPage1;
        }

        private void QuitterButton_Click(object sender, EventArgs e)
        {
            //Fermer l'application
            Close();
        }
    }
}