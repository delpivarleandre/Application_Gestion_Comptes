using System; //importe les principales fonctionnalites du Framework.
using System.Windows.Forms; //Permet la creation d'applications windows.



namespace Application_avec_base_de_donnée
{
    public partial class Connexion : Form
    {
        
            public Connexion()
            {
            InitializeComponent();
            }
        login login = new login();
        stockage stockage = new stockage();
        public static bool affectation = true;
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            //Entrer dans le compte.
            if (textBoxCO.Text == "" || textBoxMDP.Text == "" || textBoxCO.Text == "" && textBoxMDP.Text == "")
            {
                MessageBox.Show("Vous devez remplir tous les champs.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Recupere le mot ecrit dans le textbox connexion.
                login.SetUser(textBoxCO.Text);
                //Recupere le mot ecrit dans le textbox mdp.
                login.SetMdp(textBoxMDP.Text);
                if (login.validlogin() == 0)
                {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe incorrect(s).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabControl1.SelectedTab = PageCompte;
                }
                Size = new System.Drawing.Size(759, 489);
                //Centrer l'application au centre de l'ecran.
                CenterToScreen();
                //Recupere le mot ecrit dans le textbox connexion.
                stockage.SetUser2(textBoxCO.Text);
                //Actualiser les comptes.
                stockage.RemonterBDD(DataGV);
            }
                //Remplace ce qui est ecrit par du vide.
                textBoxCO.Text = "";
                textBoxMDP.Text = "";
        }

        private void buttonCreation_Click(object sender, EventArgs e)
        {
            //Ouvre la page Creation.
            CreationPage crea = new CreationPage();
            crea.Show();
        }

        private void RacourciTouch(object sender, KeyEventArgs e)
        {
            //Pouvoir appuyer sur entrer (connexion).
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnexion_Click(this, new EventArgs());
            }
        }
        private void RacourciTouch1(object sender, KeyEventArgs e)
        {
            //Pouvoir appuyer sur entrer (connexion).
            if (e.KeyCode == Keys.Enter)
            {
                AjouterButton_Click(this, new EventArgs());
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            //Afficher les comptes quand la connexion est ouverte.
            stockage.RemonterBDD(DataGV);
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            //Recupere le mot ecrit dans le textbox reseau.
            stockage.SetReseau(AjouterReseauBox.Text);
            //Recupere le mot ecrit dans le textbox adresse
            stockage.SetNdc(AjouterAdresseBox.Text);
            //Recupere le mot ecrit dans le textbox MotDePasse
            stockage.Setmdp2(AjouterMotDePasseBox.Text.ToString()) ;
            //Chiffre le mot de passe recupere avant.
            stockage.Setmdp2(Chiffrer.Chiffre(stockage.Getmdp2()));
            //Permet de ne pas ajouter une ligne vide
            DataGV.AllowUserToAddRows = false;
            if (AjouterAdresseBox.Text =="" || stockage.Getmdp2()=="" || AjouterAdresseBox.Text=="" && stockage.Getmdp2()== "")
            {
                MessageBox.Show("Vous devez remplir tous les champs.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                stockage.AjouterBDD(DataGV);
            }            
            //Remplacer le texte pas du vide apres l'ajout.
            AjouterMotDePasseBox.Text = "";
            AjouterAdresseBox.Text = "";
            AjouterReseauBox.Text = "";
        }

        private void Affichermdp_Click(object sender, EventArgs e)
        {
            stockage.SetReseau(AjouterReseauBox.Text);
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
                            DataGV[2, r].Value = Chiffrer.Dechiffre(mdp);
                        }
                    }
                    affectation = false;
                }
                else
                {
                    //Afficher le mot de passe ou non.
                    for (int r = 0; r < DataGV.Rows.Count; r++)
                    {
                        if (DataGV[2, r].Value != null)
                        {
                            string mdp = DataGV[2, r].Value.ToString();
                            DataGV[2, r].Value =Chiffrer.Chiffre(mdp);
                        }
                    }
                    affectation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            //Suprimer le compte.
            if (MessageBox.Show("Voulez vous vraiment supprimer l'adresse ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    stockage.DeleteBDD(DataGV);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeconnectionButton_Click(object sender, EventArgs e)
        {
            //Relancer l'application.
            Application.Restart();
        }

        private void QuitterButton_Click(object sender, EventArgs e)
        {
            //Fermer l'application.
            Close();
        }

        private void DataGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Permet de definir mon datagrind avec la ligne 0 pour supprimer.
            stockage.Setid(DataGV.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }

}

