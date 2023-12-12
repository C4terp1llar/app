using MySql.Data.MySqlClient;
using System.Data;

namespace App
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (loginTxt.Text == "" || passwordTxt.Text == "")
            {
                MessageBox.Show("Заполните  все поля!");
                return;
            }

            string login = loginTxt.Text;
            string password = passwordTxt.Text;

            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l AND `password` = @p", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Авторизация прошла успешно!");
                FormMain formMain = new FormMain();
                formMain.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                loginTxt.Text = "";
                passwordTxt.Text = "";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = true;
        }

        private void linkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormReg formReg = new FormReg();
            formReg.Visible = true;
            this.Visible = false;
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

