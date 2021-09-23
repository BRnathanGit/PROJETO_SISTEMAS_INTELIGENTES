using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaOnline
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaRegistro telaRegistro = new TelaRegistro();
            telaRegistro.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Controllers.LoginController loginController = new Controllers.LoginController();

            if(loginController.loginUser(txtEmail.Text, txtPassword.Text))
            {
                if(Controllers.GlobalVariables.userType == "admin")
                {
                    AdminScreen admScreen = new AdminScreen();
                    admScreen.Show();
                    this.Dispose(false);
                } else if (Controllers.GlobalVariables.userType == "user")
                {
                    UserScreen usrScreen = new UserScreen();
                    usrScreen.Show();
                    this.Dispose(false);
                } else
                {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }

            } else
            {
                MessageBox.Show(loginController.errorMessage);
            }
        }
    }
}
