
namespace BibliotecaOnline
{
    partial class AdminScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxTempoExpira = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxImgUrl = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridUserList = new System.Windows.Forms.DataGridView();
            this.comboSelecionaUserTipo = new System.Windows.Forms.ComboBox();
            this.checkApenasUserComLivro = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtBoxTempoExpira);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBoxImgUrl);
            this.tabPage1.Controls.Add(this.txtBoxDescription);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBoxTitle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.genreListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livros";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(60, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adicionar livro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxTempoExpira
            // 
            this.txtBoxTempoExpira.Location = new System.Drawing.Point(645, 324);
            this.txtBoxTempoExpira.MaxLength = 8;
            this.txtBoxTempoExpira.Name = "txtBoxTempoExpira";
            this.txtBoxTempoExpira.PlaceholderText = "600";
            this.txtBoxTempoExpira.Size = new System.Drawing.Size(78, 27);
            this.txtBoxTempoExpira.TabIndex = 9;
            this.txtBoxTempoExpira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tempo que o usuário poderá ficar com o livro em segundos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Link da imagem da capa";
            // 
            // txtBoxImgUrl
            // 
            this.txtBoxImgUrl.Location = new System.Drawing.Point(409, 230);
            this.txtBoxImgUrl.MaxLength = 400;
            this.txtBoxImgUrl.Multiline = true;
            this.txtBoxImgUrl.Name = "txtBoxImgUrl";
            this.txtBoxImgUrl.PlaceholderText = "https://i.imgur.com/NeA9eB7.png";
            this.txtBoxImgUrl.Size = new System.Drawing.Size(358, 68);
            this.txtBoxImgUrl.TabIndex = 6;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(346, 111);
            this.txtBoxDescription.MaxLength = 99;
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(421, 90);
            this.txtBoxDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(346, 62);
            this.txtBoxTitle.MaxLength = 30;
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(421, 27);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria do livro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 20;
            this.genreListBox.Location = new System.Drawing.Point(36, 58);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(150, 204);
            this.genreListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridUserList);
            this.tabPage2.Controls.Add(this.comboSelecionaUserTipo);
            this.tabPage2.Controls.Add(this.checkApenasUserComLivro);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Usuários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de usuário para mostrar";
            // 
            // dataGridUserList
            // 
            this.dataGridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserList.Location = new System.Drawing.Point(7, 222);
            this.dataGridUserList.Name = "dataGridUserList";
            this.dataGridUserList.RowHeadersWidth = 51;
            this.dataGridUserList.RowTemplate.Height = 29;
            this.dataGridUserList.Size = new System.Drawing.Size(776, 188);
            this.dataGridUserList.TabIndex = 2;
            this.dataGridUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUserList_CellContentClick);
            // 
            // comboSelecionaUserTipo
            // 
            this.comboSelecionaUserTipo.FormattingEnabled = true;
            this.comboSelecionaUserTipo.Location = new System.Drawing.Point(216, 12);
            this.comboSelecionaUserTipo.Name = "comboSelecionaUserTipo";
            this.comboSelecionaUserTipo.Size = new System.Drawing.Size(151, 28);
            this.comboSelecionaUserTipo.TabIndex = 1;
            this.comboSelecionaUserTipo.SelectedIndexChanged += new System.EventHandler(this.comboSelecionaUserTipo_SelectedIndexChanged);
            // 
            // checkApenasUserComLivro
            // 
            this.checkApenasUserComLivro.AutoSize = true;
            this.checkApenasUserComLivro.Location = new System.Drawing.Point(486, 14);
            this.checkApenasUserComLivro.Name = "checkApenasUserComLivro";
            this.checkApenasUserComLivro.Size = new System.Drawing.Size(294, 24);
            this.checkApenasUserComLivro.TabIndex = 0;
            this.checkApenasUserComLivro.Text = "Mostrar apenas usuários com livro ativo";
            this.checkApenasUserComLivro.UseVisualStyleBackColor = true;
            this.checkApenasUserComLivro.CheckedChanged += new System.EventHandler(this.checkApenasUserComLivro_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(259, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Habilitar editção no DataGridView";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxImgUrl;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxTempoExpira;
        private System.Windows.Forms.Label label5;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridUserList;
        private System.Windows.Forms.ComboBox comboSelecionaUserTipo;
        private System.Windows.Forms.CheckBox checkApenasUserComLivro;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}