namespace App
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            tbProductName = new TextBox();
            label6 = new Label();
            btnAddToDB = new Button();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbForecast = new TextBox();
            dataGridView = new DataGridView();
            tbLastSale = new TextBox();
            tbSale = new TextBox();
            btnAdd = new Button();
            btnForecast = new Button();
            linkLabel2 = new LinkLabel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(454, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 20);
            toolStripMenuItem1.Text = "Отчистить";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(151, 15);
            label1.Name = "label1";
            label1.Size = new Size(140, 45);
            label1.TabIndex = 0;
            label1.Text = "Расчеты";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(tbProductName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnAddToDB);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbForecast);
            panel2.Controls.Add(dataGridView);
            panel2.Controls.Add(tbLastSale);
            panel2.Controls.Add(tbSale);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnForecast);
            panel2.Location = new Point(12, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 334);
            panel2.TabIndex = 2;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(18, 30);
            tbProductName.MaxLength = 100;
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(396, 23);
            tbProductName.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 13);
            label6.Name = "label6";
            label6.Size = new Size(190, 15);
            label6.TabIndex = 12;
            label6.Text = "Введите наименование продукта:";
            // 
            // btnAddToDB
            // 
            btnAddToDB.BackColor = SystemColors.Highlight;
            btnAddToDB.Cursor = Cursors.Hand;
            btnAddToDB.FlatStyle = FlatStyle.Popup;
            btnAddToDB.Location = new Point(277, 270);
            btnAddToDB.Name = "btnAddToDB";
            btnAddToDB.Size = new Size(137, 23);
            btnAddToDB.TabIndex = 11;
            btnAddToDB.Text = "Внести в БД";
            btnAddToDB.UseVisualStyleBackColor = false;
            btnAddToDB.Click += btnAddToDB_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(18, 305);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "К авторизации";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 140);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 9;
            label5.Text = "Последняя продажа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 56);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 8;
            label4.Text = "Добавить продажу:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 56);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 7;
            label3.Text = "Количество проданного товара по месяцам:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 194);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Результат:";
            // 
            // tbForecast
            // 
            tbForecast.Location = new Point(277, 212);
            tbForecast.Name = "tbForecast";
            tbForecast.ReadOnly = true;
            tbForecast.Size = new Size(137, 23);
            tbForecast.TabIndex = 5;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(18, 74);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(253, 219);
            dataGridView.TabIndex = 4;
            // 
            // tbLastSale
            // 
            tbLastSale.Location = new Point(277, 158);
            tbLastSale.Name = "tbLastSale";
            tbLastSale.Size = new Size(137, 23);
            tbLastSale.TabIndex = 3;
            // 
            // tbSale
            // 
            tbSale.Location = new Point(277, 74);
            tbSale.Name = "tbSale";
            tbSale.Size = new Size(137, 23);
            tbSale.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(306, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(84, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnForecast
            // 
            btnForecast.Cursor = Cursors.Hand;
            btnForecast.FlatStyle = FlatStyle.Popup;
            btnForecast.Location = new Point(306, 241);
            btnForecast.Name = "btnForecast";
            btnForecast.Size = new Size(84, 23);
            btnForecast.TabIndex = 0;
            btnForecast.Text = "Рассчитать";
            btnForecast.UseVisualStyleBackColor = true;
            btnForecast.Click += btnForecast_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Location = new Point(382, 305);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(32, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "К БД";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(454, 465);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчеты";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox tbLastSale;
        private TextBox tbSale;
        private Button btnAdd;
        private Button btnForecast;
        private DataGridView dataGridView;
        private TextBox tbForecast;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private LinkLabel linkLabel1;
        private Button btnAddToDB;
        private TextBox tbProductName;
        private Label label6;
        private LinkLabel linkLabel2;
    }
}