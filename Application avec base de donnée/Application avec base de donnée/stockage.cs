using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    public class stockage
    {
        private string reseauAjoutCompte = null;
        private string nomDeCompteAjoutCompte = null;
        private string mdpAjoutCompte = null;
        public static DataTable DataTable;
        private string userDeLogin = null;
        private string id;
        
        public void SetReseau(string TextReseau)
        {
            reseauAjoutCompte = TextReseau;
        }
        public string GetReseau()
        {
            return reseauAjoutCompte;
        }
        public void SetNdc(string TextNdc)
        {
            nomDeCompteAjoutCompte = TextNdc;
        }
        public string GetNdc()
        {
            return nomDeCompteAjoutCompte;
        }
        public void Setmdp2(string Textmdp2)
        {
            mdpAjoutCompte = Textmdp2;
        }
        public string Getmdp2()
        {
            return mdpAjoutCompte;
        }
        public void SetUser2(string TextUser2)
        {
            userDeLogin = TextUser2;
        }
        public string GetUser2()
        {
            return userDeLogin;
        }
        public void Setid(string Textid)
        {
            id = Textid;
        }
        public string Getid()
        {
            return id;
        }
        public void AjouterBDD(DataGridView data)
        {
            
            // Préparation de la connexion à la base de données
            string connetionString = null;

            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            
                const string query = "INSERT INTO stockage(iduser,reseau,user,pass) values(@id,@reseau,@user,@pass)";              
                using (MySqlCommand com = new MySqlCommand(query, cnn))
                {
                    com.Parameters.AddWithValue("@reseau", reseauAjoutCompte);
                    com.Parameters.AddWithValue("@user", nomDeCompteAjoutCompte);
                    com.Parameters.AddWithValue("@pass", mdpAjoutCompte);
                    com.Parameters.AddWithValue("@id", userDeLogin);
                    com.ExecuteNonQuery();
                    RemonterBDD(data);
                    MessageBox.Show("Ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
        }
        public void RemonterBDD(DataGridView data)
        {
            // Préparation de la connexion à la base de données
            string connetionString = null;
            DataTable = new DataTable();
            MySqlDataAdapter adapter;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            string query = "SELECT reseau,user,pass FROM stockage WHERE iduser=@id";
            var cmd = new MySqlCommand(query, cnn);
            cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar));
            cmd.Parameters["@id"].Value = userDeLogin;

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(DataTable);
            data.AutoGenerateColumns = true;
            data.DataSource = DataTable;
            data.DataMember = DataTable.TableName;
            DataGridViewColumn columns = data.Columns[2];
            columns.Width = 270;
            cnn.Close();
        }
        public void DeleteBDD(DataGridView data)
        {
            login login = new login();
            // Préparation de la connexion à la base de données
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            string query = "DELETE FROM stockage WHERE iduser=@id AND reseau=@r";
            var cmd = new MySqlCommand(query, cnn);
            cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar));
            cmd.Parameters["@id"].Value = userDeLogin;
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
    }
}
