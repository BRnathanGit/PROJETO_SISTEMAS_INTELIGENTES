using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaOnline.Controllers
{
    class AdminScreenController
    {
        public static void addBookScreen(String title, String description, String imgurl, String genre, String tempoExpira)
        {
            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                Controllers.GlobalVariables.server_db,
                Controllers.GlobalVariables.uid_db,
                Controllers.GlobalVariables.pwd_db,
                Controllers.GlobalVariables.database_db));



            String mysqlQuery = String.Format("INSERT INTO `livros` (`livro_title`, `livro_description`, `livro_capa_imgurl`, `livro_genre`, `livro_tempo_limite`) VALUES " +
                "('{0}', '{1}', '{2}', '{3}', '{4}')",
                title,
                description,
                imgurl,
                genre,
                tempoExpira);

            MySqlCommand command = new MySqlCommand(mysqlQuery, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                connection.Dispose();
                connection.Close();
            }
            catch (MySqlException ee)
            {
                //MENSAGEM DE ERRO
            }
        }

        public static DataTable usersScreenController(Boolean apenasComLivro, String userType)
        {
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOME");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("LIVRO ID");
            dt.Columns.Add("TIPO");
            dt.Columns.Add("BANIDO");
            dt.Columns.Add(column);

            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                Controllers.GlobalVariables.server_db,
                Controllers.GlobalVariables.uid_db,
                Controllers.GlobalVariables.pwd_db,
                Controllers.GlobalVariables.database_db));

            String mysqlQuery = "SELECT * FROM `users`";

            MySqlCommand command = new MySqlCommand(mysqlQuery, connection);

            DataRow row;

            try
            {
                connection.Open();

                MySqlDataReader mysqlReader = command.ExecuteReader();

                while (mysqlReader.Read())
                {
                    if (apenasComLivro)
                    {
                        if (mysqlReader["user_livro_atual"].ToString() != "0" && mysqlReader["user_type"].ToString() == userType)
                        {
                            row = dt.NewRow();
                            row["ID"] = mysqlReader["user_id"];
                            row["NOME"] = mysqlReader["user_name"];
                            row["EMAIL"] = mysqlReader["user_email"];
                            row["LIVRO ID"] = mysqlReader["user_livro_atual"];
                            row["TIPO"] = mysqlReader["user_type"];
                            row["BANIDO"] = mysqlReader["user_banido"];
                            dt.Rows.Add(row);
                        } else if (mysqlReader["user_livro_atual"].ToString() != "0" && userType == "todos")
                        {
                            row = dt.NewRow();
                            row["ID"] = mysqlReader["user_id"];
                            row["NOME"] = mysqlReader["user_name"];
                            row["EMAIL"] = mysqlReader["user_email"];
                            row["LIVRO ID"] = mysqlReader["user_livro_atual"];
                            row["TIPO"] = mysqlReader["user_type"];
                            row["BANIDO"] = mysqlReader["user_banido"];
                            dt.Rows.Add(row);
                        }

                    } else
                    {
                        if (mysqlReader["user_type"].ToString() == userType)
                        {
                            row = dt.NewRow();
                            row["ID"] = mysqlReader["user_id"];
                            row["NOME"] = mysqlReader["user_name"];
                            row["EMAIL"] = mysqlReader["user_email"];
                            row["LIVRO ID"] = mysqlReader["user_livro_atual"];
                            row["TIPO"] = mysqlReader["user_type"];
                            row["BANIDO"] = mysqlReader["user_banido"];
                            dt.Rows.Add(row);
                        } else if (userType == "todos")
                        {
                            row = dt.NewRow();
                            row["ID"] = mysqlReader["user_id"];
                            row["NOME"] = mysqlReader["user_name"];
                            row["EMAIL"] = mysqlReader["user_email"];
                            row["LIVRO ID"] = mysqlReader["user_livro_atual"];
                            row["TIPO"] = mysqlReader["user_type"];
                            row["BANIDO"] = mysqlReader["user_banido"];
                            dt.Rows.Add(row);
                        }

                    }

                }

                connection.Dispose();
                connection.Close();
            }
            catch (MySqlException ee)
            {
                //MNESAGEM DE RRO
            }

            return dt;
        }
    }
}
