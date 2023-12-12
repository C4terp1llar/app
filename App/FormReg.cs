using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            passwordRegTxt.UseSystemPasswordChar = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordRegTxt.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormAuth formAuth = new FormAuth();
            formAuth.Visible = true;
            this.Visible = false;
        }
        public Boolean checkUser()
        {
            string login = loginRegTxt.Text;

            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @l", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginRegTxt.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void submitRegBtn_Click(object sender, EventArgs e)
        {
            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `userName`, `userSurname`) VALUES (@l, @p, @n, @s);", db.GetConnection());
            command.Parameters.Add("@l", MySqlDbType.VarChar).Value = loginRegTxt.Text;
            command.Parameters.Add("@p", MySqlDbType.VarChar).Value = passwordRegTxt.Text;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameRegTxt.Text;
            command.Parameters.Add("@s", MySqlDbType.VarChar).Value = surnameRegTxt.Text;

            if (loginRegTxt.Text == "" || passwordRegTxt.Text == "" || nameRegTxt.Text == "" || surnameRegTxt.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                if (checkUser())
                {
                    MessageBox.Show("Такой логин уже существует, придумайте другой");
                }
                else
                {
                    db.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Регистрация прошла успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                    db.closeConnection();
                }
            }
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
