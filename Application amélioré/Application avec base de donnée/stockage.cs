using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    public class stockage
    {
        private string reseau = null;
        private string ndc = null;
        private string mdp2 = null;
        public static DataTable dt;
        private string user2 = null;
        private string id;
        private int validCode = 0;
        private bool affectation = true;
        private string nomReseau = null;
        private string nomAdresse = null;
        private string nomMotDePasse = null;
        private int valUrl = 1;
        private string linkUrl = null;

        public void SetReseau(string TextReseau)
        {
            reseau = TextReseau;
        }
        public string GetReseau()
        {
            return reseau;
        }
        public void SetNdc(string TextNdc)
        {
            ndc = TextNdc;
        }
        public string GetNdc()
        {
            return ndc;
        }
        public void Setmdp2(string Textmdp2)
        {
            mdp2 = Textmdp2;
        }
        public string Getmdp2()
        {
            return mdp2;
        }
        public void SetUser2(string TextUser2)
        {
            user2 = TextUser2;
        }
        public string GetUser2()
        {
            return user2;
        }
        public void Setid(string Textid)
        {
            id = Textid;
        }
        public string Getid()
        {
            return id;
        }
        public void SetCode(int IntCode)
        {
            validCode = IntCode;
        }
        public int GetCode()
        {
            return validCode;
        }
        public void SetAffectation(bool boolAffec)
        {
            affectation = boolAffec;
        }
        public bool GetAffectation()
        {
            return affectation;
        }
        public void SetnomReseau(string TextnomReseau)
        {
            nomReseau = TextnomReseau;
        }
        public string GetnomReseau()
        {
            return nomReseau;
        }
        public void SetnomAdresse(string TextnomAdresse)
        {
            nomAdresse = TextnomAdresse;
        }
        public string GetnomAdresse()
        {
            return nomAdresse;
        }
        public void SetnomMotdepasse(string TextnomMotdepasse)
        {
            nomMotDePasse = TextnomMotdepasse;
        }
        public string GetnomMotdepasse()
        {
            return nomMotDePasse;
        }
        public void SetValUrl(int TextValUrl)
        {
            valUrl = TextValUrl;
        }
        public int GetValUrl()
        {
            return valUrl;
        }
        public void SetLinkUrl(string textLinkUrl)
        {
            linkUrl = textLinkUrl;
        }
        public string GetLinkUrl()
        {
            return linkUrl;
        }
        public void AjouterBDD(DataGridView data)
        {

            // Préparation de la connexion à la base de données
            string connetionString = null;

            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            // Connexion à la base de données

            const string query = "INSERT INTO stockage(iduser,reseau,user,pass) values(@id,@reseau,@user,@pass)";

            using (MySqlCommand com = new MySqlCommand(query, cnn))
            {
                com.Parameters.AddWithValue("@reseau", reseau);
                com.Parameters.AddWithValue("@user", ndc);
                com.Parameters.AddWithValue("@pass", mdp2);
                com.Parameters.AddWithValue("@id", user2);
                com.ExecuteNonQuery();

                MessageBox.Show("Ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemonterBDD(data);
            }

        }
        public void RemonterBDD(DataGridView data)
        {
            // Préparation de la connexion à la base de données
            string connetionString = null;
            dt = new DataTable();
            MySqlDataAdapter adapter;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            string query = "SELECT reseau,user,pass FROM stockage WHERE iduser=@id";
            var cmd = new MySqlCommand(query, cnn);
            cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar));
            cmd.Parameters["@id"].Value = user2;


            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            data.AutoGenerateColumns = true;
            data.DataSource = dt;
            data.DataMember = dt.TableName;
            DataGridViewColumn columns = data.Columns[2];
            columns.Width = 270;
            cnn.Close();
        }
        public void DeleteBDD(DataGridView data)
        {
            login login = new login();
            // Préparation de la connexion à la base de données
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            string query = "DELETE FROM stockage WHERE iduser=@id AND reseau=@r";

            var cmd = new MySqlCommand(query, cnn);
            cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar));
            cmd.Parameters["@id"].Value = user2;
            cmd.Parameters.Add(new MySqlParameter("@r", MySqlDbType.VarChar));
            cmd.Parameters["@r"].Value = id;
            int ex = cmd.ExecuteNonQuery();
            if (ex < 0)
            {
                Console.WriteLine("Error inserting data into Database!");
            }
            else
            {
                RemonterBDD(data);
                MessageBox.Show("Suprimé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UrlImage()
        {

            // Préparation de la connexion à la base de données
            string connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            // Connexion à la base de données

            const string query = "SELECT url FROM stockage WHERE reseau=@reseau AND user=@user";

            using (MySqlCommand com = new MySqlCommand(query, cnn))
            {
                com.Parameters.Add(new MySqlParameter("@reseau", MySqlDbType.VarChar));
                com.Parameters["@reseau"].Value = nomReseau;
                com.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                com.Parameters["@user"].Value = nomAdresse;

                var reader = com.ExecuteReader();
                while (reader.Read())
                {
                    SetLinkUrl(reader.GetString("url"));
                }
                 
                

            }

        }
        public void AjouterUrl()
        {

            // Préparation de la connexion à la base de données

            string connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();

            // Connexion à la base de données

            const string query = "UPDATE stockage SET url=@url WHERE reseau=@reseau AND user=@user";

            using (MySqlCommand com = new MySqlCommand(query, cnn))
            {
                com.Parameters.Add(new MySqlParameter("@reseau", MySqlDbType.VarChar));
                com.Parameters["@reseau"].Value = nomReseau;
                com.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                com.Parameters["@user"].Value = nomAdresse;
                com.Parameters.AddWithValue("@url", linkUrl);


                com.ExecuteNonQuery();

                MessageBox.Show("Ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
