using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaOnline.Controllers
{
    class UserScreenController
    {
        public void loadBooksFromDatabase(FlowLayoutPanel flowLayoutPanel)
        {
            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                GlobalVariables.server_db,
                GlobalVariables.uid_db,
                GlobalVariables.pwd_db,
                GlobalVariables.database_db));

            String mysqlQuery = "SELECT * FROM `livros`";

            MySqlCommand command = new MySqlCommand(mysqlQuery, connection);

            try
            {
                connection.Open();

                MySqlDataReader queryResult = command.ExecuteReader();

                while (queryResult.Read())
                {
                    GroupBox groupBox = new GroupBox();
                    Label lblTitle = new Label();
                    Label lblDesc = new Label();
                    PictureBox pictureBox = new PictureBox();
                    Button btnSelecionarLivro = new Button();

                    // Titulo
                    lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    lblTitle.Location = new System.Drawing.Point(189, 26);
                    lblTitle.Name = "label1";
                    lblTitle.Size = new System.Drawing.Size(361, 29);
                    lblTitle.TabIndex = 0;
                    lblTitle.Text = queryResult["livro_title"].ToString();
                    lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    // Descrição
                    lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lblDesc.Location = new System.Drawing.Point(189, 67);
                    lblDesc.Name = "label2";
                    lblDesc.Size = new System.Drawing.Size(361, 162);
                    lblDesc.TabIndex = 2;
                    lblDesc.Text = queryResult["livro_description"].ToString();
                    lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                    //Capa - Imagem
                    pictureBox.Location = new System.Drawing.Point(6, 26);
                    pictureBox.Name = "pictureBox1";
                    pictureBox.Size = new System.Drawing.Size(153, 223);
                    pictureBox.TabIndex = 1;
                    pictureBox.TabStop = false;

                    // Botão
                    btnSelecionarLivro.Location = new System.Drawing.Point(618, 196);
                    btnSelecionarLivro.Name = queryResult["livro_id"].ToString();
                    btnSelecionarLivro.Size = new System.Drawing.Size(142, 53);
                    btnSelecionarLivro.TabIndex = 1;
                    btnSelecionarLivro.Text = "Alugar este livro";
                    btnSelecionarLivro.UseVisualStyleBackColor = true;
                    btnSelecionarLivro.Click += new System.EventHandler(UserScreen.btnSelecionarLivro);

                    // Adicionando a imagem
                    var request = WebRequest.Create(queryResult["livro_capa_imgurl"].ToString());

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        //pictureBox.Image = Bitmap.FromStream(stream);
                        Image img = (Image)new Bitmap(Bitmap.FromStream(stream), new Size(153, 223));
                        pictureBox.Image = img;
                    }

                    groupBox.Controls.Add(lblTitle);
                    groupBox.Controls.Add(lblDesc);
                    groupBox.Controls.Add(pictureBox);
                    groupBox.Controls.Add(btnSelecionarLivro);
                    groupBox.Size = new System.Drawing.Size(770, 260);
                    groupBox.TabIndex = 0;
                    groupBox.TabStop = false;
                    groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    groupBox.Text = queryResult["livro_genre"].ToString();

                    flowLayoutPanel.Controls.Add(groupBox);
                }

                connection.Dispose();
                connection.Close();
            }
            catch (MySqlException e)
            {
                //TODO: MENSAGEM DE ERRO
            }
        }

        public static void accountTabUserLivros(FlowLayoutPanel accountTabFlowLayoutPanel)
        {
            MySqlConnection connection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                GlobalVariables.server_db,
                GlobalVariables.uid_db,
                GlobalVariables.pwd_db,
                GlobalVariables.database_db));

            MySqlConnection conn = connection.Clone();

            MySqlConnection removerLivroExpiraConn = connection.Clone();

            String mysqlQuery2 = "SELECT * FROM `livros`";
            String mysqlQuery1 = String.Format("SELECT * FROM `users` WHERE `user_id` = '{0}'", GlobalVariables.userID);

            MySqlCommand command1 = new MySqlCommand(mysqlQuery1, connection);
            MySqlCommand command2 = new MySqlCommand(mysqlQuery2, conn);

            try
            {

                // -=-=-=-=- Atualizar o livro do usuário -=-=-=-=-

                connection.Open();

                MySqlDataReader sqlReader1 = command1.ExecuteReader();

                while(sqlReader1.Read())
                {
                    GlobalVariables.userLivroAtualID = sqlReader1["user_livro_atual"].ToString();
                    GlobalVariables.userLivroDataPegou = sqlReader1["livro_data_pegou"].ToString();
                    GlobalVariables.userLivroExpira = sqlReader1["livro_data_expira"].ToString();
                }

                connection.Dispose();
                connection.Close();

                // -=-=-=-=- Atualizar o livro do usuário -=-=-=-=-

                // -=-=-=-=- Atualizar a lista de livros -=-=-=-=-

                conn.Open();

                MySqlDataReader sqlReader2 = command2.ExecuteReader();

                while (sqlReader2.Read())
                {
                    if (sqlReader2["livro_id"].ToString() == GlobalVariables.userLivroAtualID)
                    {

                        GroupBox accountGroupBox = new GroupBox();
                        Label lblTitle = new Label();
                        Label lblDesc = new Label();
                        PictureBox pictureBox = new PictureBox();
                        Button btnSelecionarLivro = new Button();

                        // Titulo
                        lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                        lblTitle.Location = new System.Drawing.Point(189, 26);
                        lblTitle.Name = "label1";
                        lblTitle.Size = new System.Drawing.Size(361, 29);
                        lblTitle.TabIndex = 0;
                        lblTitle.Text = sqlReader2["livro_title"].ToString();
                        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                        // Descrição
                        lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        lblDesc.Location = new System.Drawing.Point(189, 67);
                        lblDesc.Name = "label2";
                        lblDesc.Size = new System.Drawing.Size(361, 162);
                        lblDesc.TabIndex = 2;
                        lblDesc.Text = sqlReader2["livro_description"].ToString();
                        lblDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;

                        //Capa - Imagem
                        pictureBox.Location = new System.Drawing.Point(6, 26);
                        pictureBox.Name = "pictureBox1";
                        pictureBox.Size = new System.Drawing.Size(153, 223);
                        pictureBox.TabIndex = 1;
                        pictureBox.TabStop = false;

                        // Adicionando a imagem
                        var request = WebRequest.Create(sqlReader2["livro_capa_imgurl"].ToString());

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            //pictureBox.Image = Bitmap.FromStream(stream);
                            Image img = (Image)new Bitmap(Bitmap.FromStream(stream), new Size(153, 223));
                            pictureBox.Image = img;
                        }

                        accountGroupBox.Controls.Add(lblTitle);
                        accountGroupBox.Controls.Add(lblDesc);
                        accountGroupBox.Controls.Add(pictureBox);
                        accountGroupBox.Size = new System.Drawing.Size(770, 260);
                        accountGroupBox.TabIndex = 0;
                        accountGroupBox.TabStop = false;
                        accountGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

                        if (GlobalVariables.userLivroAtualID != "0" && GlobalVariables.userLivroAtualID != "NULL")
                        {
                            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                            dtDateTime = dtDateTime.AddSeconds(int.Parse(GlobalVariables.userLivroExpira)).ToLocalTime();

                            accountGroupBox.Text = "Livro expira em: " + dtDateTime;
                        }

                        accountTabFlowLayoutPanel.Controls.Add(accountGroupBox);

                    }
                }

                conn.Dispose();
                conn.Close();

                // -=-=-=-=- Atualizar a lista de livros -=-=-=-=-

                // -=-=-=-=- Remover o livro -=-=-=-=-

                if (GlobalVariables.userLivroAtualID != "0")
                {
                    TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
                    int secondsSinceEpoch = (int)t.TotalSeconds;

                    System.DateTime dtDateTimeAtual = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTimeAtual = dtDateTimeAtual.AddSeconds(secondsSinceEpoch).ToLocalTime();

                    System.DateTime dtDateTimeLivroExpira = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                    dtDateTimeLivroExpira = dtDateTimeLivroExpira.AddSeconds(int.Parse(GlobalVariables.userLivroExpira)).ToLocalTime();

                    if (dtDateTimeAtual >= dtDateTimeLivroExpira)
                    {
                        String removerLivroExpiraQuery = "UPDATE `users` SET `user_livro_atual` = 'NULL', `livro_data_pegou` = 'NULL', `livro_data_expira` = 'NULL' WHERE `user_id` = '" + GlobalVariables.userID + "'";
                        MySqlCommand removerLivroExpiraCommand = new MySqlCommand(removerLivroExpiraQuery, removerLivroExpiraConn);

                        try
                        {
                            removerLivroExpiraConn.Open();

                            removerLivroExpiraCommand.ExecuteNonQuery();

                            removerLivroExpiraConn.Dispose();
                            removerLivroExpiraConn.Close();

                            UserScreen.msgBox("Seu livro expirou!");
                        }
                        catch (MySqlException e)
                        {
                            //TODO: Mensagem de erro
                        }
                    }
                }

                // -=-=-=-=- Remover o livro -=-=-=-=-

            }
            catch (MySqlException e)
            {
                //TODO: Mensagem de erro
            }
        }

        public static void userLivroEscolhe(String livroID)
        {
            MySqlConnection updateUserLivroConnection = new MySqlConnection(String.Format("server={0};uid={1};pwd={2};database={3}",
                GlobalVariables.server_db,
                GlobalVariables.uid_db,
                GlobalVariables.pwd_db,
                GlobalVariables.database_db));

            MySqlConnection getBookInfosConnection = updateUserLivroConnection.Clone();

            String livroTempoLimite = "600"; // 120 segundos padrão
            String getBookInfosQuery = String.Format("SELECT * FROM `livros` WHERE `livro_id` = '{0}'", livroID);

            MySqlCommand getBookInfosCommand = new MySqlCommand(getBookInfosQuery, getBookInfosConnection);

            try {
                getBookInfosConnection.Open();

                MySqlDataReader bookInfosReader = getBookInfosCommand.ExecuteReader();

                while(bookInfosReader.Read())
                {
                    livroTempoLimite = bookInfosReader["livro_tempo_limite"].ToString();
                }

                getBookInfosConnection.Dispose();
                getBookInfosConnection.Close();
            } catch (MySqlException e)
            {
                //TODO: MENSAGEM DE ERRO
            }

            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int epochSeconds = (int)t.TotalSeconds;

            String updateUserLivroQuery = String.Format("UPDATE `users` SET `user_livro_atual` = '{0}', `livro_data_pegou` = '{1}', `livro_data_expira` = '{2}' WHERE `user_id` = '{3}'",
                livroID,
                epochSeconds,
                (epochSeconds + int.Parse(livroTempoLimite)).ToString(),
                GlobalVariables.userID);

            MySqlCommand updateUserLivroCommand = new MySqlCommand(updateUserLivroQuery, updateUserLivroConnection);

            try
            {
                updateUserLivroConnection.Open();

                updateUserLivroCommand.ExecuteNonQuery();

                updateUserLivroConnection.Dispose();
                updateUserLivroConnection.Close();
            } catch (MySqlException e)
            {
                //TODO: MENSAGEM DE ERRO
            }
        }
    }
}
