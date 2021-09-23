using BibliotecaOnline.Controllers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaOnline
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();

            UserScreenController userScreenController = new UserScreenController();

            userScreenController.loadBooksFromDatabase(flowLayoutPanel1);
            UserScreenController.accountTabUserLivros(flowLayoutPanel2);

            accountTabUserName.Text = "Usuário: " + GlobalVariables.userName;

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel2.AutoScroll = true;

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 10000;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        public static void btnSelecionarLivro(object sender, EventArgs e)
        {
            Button myButton = (sender as Button);

            UserScreenController.userLivroEscolhe(myButton.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O livro foi adquirido com sucesso!\nEntre na aba \"Conta\" para ver ele.");

            UserScreenController.accountTabUserLivros(flowLayoutPanel2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            UserScreenController.accountTabUserLivros(flowLayoutPanel2);
        }

        public static void msgBox(String msg)
        {
            MessageBox.Show(msg);
        }
    }
}
