using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaOnline.Controllers
{
    class LoginController
    {

        public String errorMessage;
 
        public Boolean registerUser(String user, String email, String password)
        {

            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}", 
                GlobalVariables.server_db, 
                GlobalVariables.uid_db, 
                GlobalVariables.pwd_db, 
                GlobalVariables.database_db));

            String mysqlQuery = String.Format("INSERT INTO `users` (`user_name`, `user_email`, `user_password`, `user_livro_atual`, `livro_data_pegou`, `livro_data_expira`) " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                user,
                email,
                password,
                "NULL",
                "NULL",
                "NULL"
                );

            MySqlCommand command = new MySqlCommand(mysqlQuery, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Clone();

                return true;
            } catch(MySqlException e)
            {
                errorMessage = e.ToString();
                return false;
            }
        }

        public Boolean loginUser(String email, String password)
        {
            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                GlobalVariables.server_db,
                GlobalVariables.uid_db,
                GlobalVariables.pwd_db,
                GlobalVariables.database_db));

            String mysqlQuery = String.Format("SELECT * FROM `users` WHERE user_email = '{0}' AND user_password = '{1}'",
                email,
                password);

            MySqlCommand command = new MySqlCommand(mysqlQuery, connection);

            try
            {
                connection.Open();
                MySqlDataReader queryResult = command.ExecuteReader();
 
                while (queryResult.Read())
                {
                    GlobalVariables.userID = queryResult["user_id"].ToString();
                    GlobalVariables.userType = queryResult["user_type"].ToString();
                    GlobalVariables.userName = queryResult["user_name"].ToString();
                    GlobalVariables.userLivroAtualID = queryResult["user_livro_atual"].ToString();
                    GlobalVariables.userLivroExpira = queryResult["livro_data_pegou"].ToString();
                    GlobalVariables.userLivroExpira = queryResult["livro_data_expira"].ToString();
                }

                command.Dispose();
                connection.Close();

                return true;
            } catch(MySqlException e)
            {
                errorMessage = e.ToString();

                return false;
            }
        }
    }
}
