using MySql.Data.MySqlClient;//Permet d'utiliser la base de données
using System;//importe les principales fonctionnalites du Framework.
using System.Windows.Forms;//Permet la creation d'applications windows.


namespace Application_avec_base_de_donnée
{
    public class login
    {
        private string user = null;
        private string mdp = null;
        private string userCrea = null;
        private string mdpCrea = null;
        private int codeCrea;
        private string NDCProfil = null;
        private string MDPProfil = null;
        private int CodeProfil;


        public void SetUser(string TextUser)
        {
            user = TextUser;
        }
        public string GetUser()
        {
            return user;
        }
        public void SetMdp(string TextMdp)
        {
            mdp = TextMdp;
        }
        public string GetMdp()
        {
            return mdp;
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
        public void SetCode(int TextCode)
        {
            codeCrea = TextCode;
        }
        public int GetCode()
        {
            return codeCrea;
        }
        public void SetNDCProfil(string TextNDCProfil)
        {
            NDCProfil = TextNDCProfil;
        }
        public string GetNDCProfil()
        {
            return NDCProfil;
        }
        public void SetMDPProfil(string TextMDPProfil)
        {
            MDPProfil = TextMDPProfil;
        }
        public string GetMDPProfil()
        {
            return MDPProfil;
        }
        public void SetCodeProfil(int TextCodeProfil)
        {
            CodeProfil = TextCodeProfil;
        }
        public int GetCodeProfil()
        {
            return CodeProfil;
        }
        public int  validlogin()
        {
            //Test le compte donné,Si fonctionne alors retourne 1.
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                const string query = "SELECT count(*)  FROM Login WHERE user=@user AND pass=@pass";
                var cmd = new MySqlCommand(query, cnn);
                //Déclarer parametre pour eviter les injections
                cmd.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                cmd.Parameters["@user"].Value = user;
                cmd.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar));
                cmd.Parameters["@pass"].Value = mdp;
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
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
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
        public int validloginprofil()
        {
            //Teste dans la base de données,Savoir si il est possible de creer le compte.
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
            try
            {
                // Connexion à la base de données
                cnn.Open();
                const string query = "SELECT count(*)  FROM Login WHERE user=@user";
                var cmd = new MySqlCommand(query, cnn);
                //Déclarer parametre pour eviter les injections
                cmd.Parameters.Add(new MySqlParameter("@user", MySqlDbType.VarChar));
                cmd.Parameters["@user"].Value = NDCProfil;
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
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);
           
                String query = "INSERT INTO Login (user,pass,code) VALUES (@user,@pass,@code)";
                using (MySqlCommand command = new MySqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@user", userCrea);
                    command.Parameters.AddWithValue("@pass", mdpCrea);
                    command.Parameters.AddWithValue("@code", codeCrea);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Votre compte est créé .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        public void ChangementLogin()
        {
            string connetionString = null;
            connetionString = "server=mysql-leandredelpivar.alwaysdata.net;Port=3306; UserID=170958; Password=leandre; database=leandredelpivar_applicationameliore";
            MySqlConnection cnn = new MySqlConnection(connetionString);

            String query = "UPDATE Login, stockage SET Login.user=@user, Login.pass=@pass, Login.code=@code,stockage.iduser = @user";
            using (MySqlCommand command = new MySqlCommand(query, cnn))
            {
                command.Parameters.AddWithValue("@user", NDCProfil);
                command.Parameters.AddWithValue("@pass", MDPProfil);
                command.Parameters.AddWithValue("@code", CodeProfil);
                cnn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Votre compte a été modifié .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
