using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace App
{
    public partial class FormMain : Form
    {
        // Параметр для экспоненциального сглаживания (0 < alpha < 1), чем меньше значение, тем больше влияние прошлых продаж
        private double alpha = 0.5;

        private List<double> salesHistory = new List<double>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Продажи";
            column.Name = "SalesColumn";
            dataGridView.Columns.Add(column);

        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            if (tbLastSale.Text == "" || dataGridView.Rows.Count <= 1)
            {
                MessageBox.Show("Заполните  все поля!");
                return;
            }

            double lastSale = Convert.ToDouble(tbLastSale.Text);

            // Применяем формулу экспоненциального сглаживания
            double forecast = alpha * lastSale + (1 - alpha) * salesHistory[salesHistory.Count - 1];


            tbForecast.Text = forecast.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            double sale = Convert.ToDouble(tbSale.Text);
            salesHistory.Add(sale);
            dataGridView.Rows.Add(sale);
            tbSale.Text = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            tbForecast.Text = "";
            tbLastSale.Text = "";
            tbSale.Text = "";
            tbProductName.Text = "";
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.Visible = true;
            this.Visible = false;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Руководство по программе:\n\n" +
            "1. Введите исторические данные продаж в таблицу,\n" +
            "при помощи соотыетствующих поля и кнопки\n" +
            "2. Введите последнюю продажу в соответвующее поле.\n" +
            "3. Нажмите на кнопку 'Рассчитать'.\n" +
            "4. Используйте прогноз для принятия решений.\n\n" +
            "Удачи в использовании программы!";

            MessageBox.Show(message, "Справка");
        }


        private void btnAddToDB_Click(object sender, EventArgs e)
        {

            db db = new db();

            db.openConnection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `productName` = @pName", db.GetConnection());
            command.Parameters.Add("@pName", MySqlDbType.VarChar).Value = tbProductName.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //есть такой продукт
                string message = "Такой продукт уже есть. Хотите обновить информацию о продукте?";
                DialogResult result = MessageBox.Show(message, "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //обновить продукт
                    MessageBox.Show("Информация о продукте успешно обновлена!");
                    MySqlCommand update = new MySqlCommand("UPDATE `products` SET `productForecast` = @pForecast WHERE `productName` = @pName", db.GetConnection());
                    update.Parameters.Add("@pForecast", MySqlDbType.VarChar).Value = tbForecast.Text;
                    update.Parameters.Add("@pName", MySqlDbType.VarChar).Value = tbProductName.Text;
                    update.ExecuteNonQuery();

                    dataGridView.Rows.Clear();
                    tbForecast.Text = "";
                    tbLastSale.Text = "";
                    tbSale.Text = "";
                    tbProductName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Продукт успешно внесен в БД!");
                //нет такого продукта
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO `products` (`productName`, `productForecast`) VALUES (@pName, @pForecast)", db.GetConnection());
                insertCommand.Parameters.Add("@pName", MySqlDbType.VarChar).Value = tbProductName.Text;
                insertCommand.Parameters.Add("@pForecast", MySqlDbType.VarChar).Value = tbForecast.Text;
                insertCommand.ExecuteNonQuery();

                dataGridView.Rows.Clear();
                tbForecast.Text = "";
                tbLastSale.Text = "";
                tbSale.Text = "";
                tbProductName.Text = "";
            }
            db.closeConnection();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDB formDB = new FormDB();
            formDB.Visible = true;
            this.Visible = false;
        }
    }
}
