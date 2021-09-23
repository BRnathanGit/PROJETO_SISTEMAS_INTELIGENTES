using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaOnline
{
    public partial class TelaRegistro : Form
    {
        public TelaRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Controllers.LoginController loginController = new Controllers.LoginController();

            if (loginController.registerUser(txtUser.Text, txtEmail.Text, txtPassword.Text))
            {
                this.Close();
                MessageBox.Show("Usuário registrado com sucesso!");
            } else
            {
                MessageBox.Show("Algum erro ocorreu ao salvar o usuário no banco de dados!\n" + loginController.errorMessage);
            }
        }
    }
}
