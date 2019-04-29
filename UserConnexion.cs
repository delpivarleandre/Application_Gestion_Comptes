using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
   public class UserConnexion
    {
        public static void connexionBDD(TextBox CO,TextBox MDP,TabControl Tabcontrol , TabPage Page )
        {
            // Préparation de la connexion à la base de données
            string connetionString = null;

            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);

            try
            {
                // Connexion à la base de données
                cnn.Open();
                const string query = "SELECT user, pass FROM Login WHERE user=@user AND pass=@pass";
                var cmd = new MySqlCommand(query, cnn);
                //Déclarer parametre pour eviter les injections
                cmd.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                cmd.Parameters["@user"].Value = CO.Text;
                cmd.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = MDP.Text;
                var result = cmd.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Connexion.user = result.GetString("user");
                    }
                    Tabcontrol.SelectedTab = Page;
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe incorrect(s).", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
