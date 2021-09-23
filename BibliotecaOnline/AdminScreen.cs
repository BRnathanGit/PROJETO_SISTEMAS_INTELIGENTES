using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaOnline
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();

            comboSelecionaUserTipo.Items.Add("todos");
            comboSelecionaUserTipo.Items.Add("user");
            comboSelecionaUserTipo.Items.Add("admin");
            comboSelecionaUserTipo.SelectedItem = "todos";

            genreListBox.Items.Add("Ação");
            genreListBox.Items.Add("Ficção");
            genreListBox.Items.Add("Aventura");
            genreListBox.Items.Add("Drama");
            genreListBox.Items.Add("Aventura");
            genreListBox.Items.Add("Romance");
            genreListBox.Items.Add("Terror");

            dataGridUserList.ReadOnly = true;

            dataGridUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridUserList.DataSource = Controllers.AdminScreenController.usersScreenController(false, "todos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controllers.AdminScreenController.addBookScreen(
                txtBoxTitle.Text,
                txtBoxDescription.Text,
                txtBoxImgUrl.Text,
                genreListBox.SelectedItem.ToString(),
                txtBoxTempoExpira.Text);

            MessageBox.Show("Livro adicionado com sucesso!");
        }

        private void checkApenasUserComLivro_CheckedChanged(object sender, EventArgs e)
        {

            Boolean check = (sender as CheckBox).Checked;

            dataGridUserList.Controls.Clear();
            dataGridUserList.DataSource = Controllers.AdminScreenController.usersScreenController(check, "todos");

        }

        private void comboSelecionaUserTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedUserType = (sender as ComboBox).Text;

            dataGridUserList.Controls.Clear();
            dataGridUserList.DataSource = Controllers.AdminScreenController.usersScreenController(checkApenasUserComLivro.Checked, selectedUserType);
        }

        private void dataGridUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridUserList.ReadOnly = false;
        }
    }
}
