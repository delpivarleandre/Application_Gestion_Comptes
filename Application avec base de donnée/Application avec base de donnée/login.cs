using MySql.Data.MySqlClient;//Permet d'utiliser la base de données
using System;//importe les principales fonctionnalites du Framework.
using System.Windows.Forms;//Permet la creation d'applications windows.


namespace Application_avec_base_de_donnée
{
    public class login
    {
        private string userLogin = null;
        private string mdpLogin = null;
        private string userCrea = null;
        private string mdpCrea = null;
        public void SetUser(string TextUser)
        {
            userLogin = TextUser;
        }
        public string GetUser()
        {
            return userLogin;
        }
        public void SetMdp(string TextMdp)
        {
            mdpLogin = TextMdp;
        }
        public string GetMdp()
        {
            return mdpLogin;
        }
        public void SetUserCrea(string TextUserCrea)
        {
            userCrea = TextUserCrea;
        }
        public string GetUserCrea()
        {
            return userCrea;
        }
        public void SetMdpCrea(string TextMdpCrea)
        {
            mdpCrea = TextMdpCrea;
        }
        public string GetMdpCrea()
        {
            return mdpCrea;
        }

        public int  validlogin()
        {
            //Test le compte donné,Si fonctionne alors retourne 1.
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                const string query = "SELECT count(*)  FROM Login WHERE user=@user AND pass=@pass";
                var cmd = new MySqlCommand(query, cnn);
                //Déclarer parametre pour eviter les injections
                cmd.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                cmd.Parameters["@user"].Value = userLogin;
                cmd.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = mdpLogin;
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                if (count == 0)
                {
                    return 0;
                }
                else
                    return 1;
            }
            catch (Exception )
            {
                return 0;
            }     
        }
        public int validloginCrea()
        {
            //Teste dans la base de données,Savoir si il est possible de creer le compte.
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                // Connexion à la base de données
                cnn.Open();
                const string query = "SELECT count(*)  FROM Login WHERE user=@user";
                var cmd = new MySqlCommand(query, cnn);
                //Déclarer parametre pour eviter les injections
                cmd.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                cmd.Parameters["@user"].Value = userCrea;
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }                  
            }
            catch (Exception)
            {
                return 0;
            }          
        }

        public void CreationLogin()
        {
            //Permet de creer le compte de la base de données.
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_user";
            MySqlConnection cnn = new MySqlConnection(connetionString);          
                String query = "INSERT INTO Login (user,pass) VALUES (@user,@pass)";
                using (MySqlCommand command = new MySqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@user", userCrea);
                    command.Parameters.AddWithValue("@pass", mdpCrea);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre compte est créé .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();              
                }
        }
    }
}
