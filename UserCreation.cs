using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Application_avec_base_de_donnée
{
    class UserCreation
    {
        public static void CreationAdd(TextBox Crea ,TextBox MDPCrea)
        {
            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "server = mysql-leandredelpivar.alwaysdata.net; Port = 3306; UserID = 170958; Password = leandre; database = leandredelpivar_user";

                String query = "INSERT INTO Login (user,pass) VALUES (@username,@password)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@username", Crea.Text);
                    command.Parameters.AddWithValue("@password", MDPCrea.Text);


                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into Database!");
                    }
                    else
                    {
                        MessageBox.Show("Votre compte est créé .");
                        
                    }
                    
                }
            }
        }
    }

}
