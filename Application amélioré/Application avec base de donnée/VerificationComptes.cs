using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Application_avec_base_de_donnée
{
    class VerificationComptes
    {
        public static void VerificationBDD()
        {
            // Préparation de la connexion à la base de données
            string connetionString = null;

            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);

                // Connexion à la base de données
                cnn.Open();
                const string query = "SELECT user FROM Login";
                var cmd = new MySqlCommand(query, cnn);
                var result = cmd.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Connexion.comptes = new System.Collections.Generic.List<string>();
                        Connexion.comptes.Add(result.GetString("user"));
                    }

                }
        }
    }
}
