using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Application_avec_base_de_donnée
{
    class Sauvegarde
    {
        public static DataTable dt;
        
        
       
        public static void RemonterBDD(DataGridView data)
        {
            login login = new login();

            // Préparation de la connexion à la base de données
            string connetionString = null;
            dt = new DataTable();
            MySqlDataAdapter adapter;

            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            cnn.Open();
            // Connexion à la base de données
            string query = "SELECT reseau,user,pass FROM stockage WHERE iduser=@id";
            var cmd = new MySqlCommand(query, cnn);
            cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.VarChar));
            cmd.Parameters["@id"].Value = login.GetUser();

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            data.AutoGenerateColumns = true;
            data.DataSource = dt;
            data.DataMember = dt.TableName;
            DataGridViewColumn columns = data.Columns[2];
            columns.Width = 270;


        }
        public static void DeleteBDD(DataGridView data)
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
            cmd.Parameters["@id"].Value = login.GetUser();
            cmd.Parameters.Add(new MySqlParameter("@r", MySqlDbType.VarChar));
            cmd.Parameters["@r"].Value = Connexion.id;
            var ex = cmd.ExecuteNonQuery();
            if (ex < 0)
            {
                Console.WriteLine("Error deleting data into Database!");
            }
            else
            {
                MessageBox.Show("Suprimé");
                RemonterBDD(data);

            }





        }
    }
}
