namespace App
{
    partial class FormReg
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            submitRegBtn = new Button();
            surnameRegTxt = new TextBox();
            nameRegTxt = new TextBox();
            passwordRegTxt = new TextBox();
            loginRegTxt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(188, 41);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(submitRegBtn);
            panel2.Controls.Add(surnameRegTxt);
            panel2.Controls.Add(nameRegTxt);
            panel2.Controls.Add(passwordRegTxt);
            panel2.Controls.Add(loginRegTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 242);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Location = new Point(30, 202);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "К авторизации";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._3994371_eye_hidden_hide_invisible_private_icon;
            pictureBox2.Location = new Point(252, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._9041325_eye_fill_icon;
            pictureBox1.Location = new Point(222, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // submitRegBtn
            // 
            submitRegBtn.Cursor = Cursors.Hand;
            submitRegBtn.FlatStyle = FlatStyle.Popup;
            submitRegBtn.Location = new Point(117, 144);
            submitRegBtn.Name = "submitRegBtn";
            submitRegBtn.Size = new Size(100, 23);
            submitRegBtn.TabIndex = 8;
            submitRegBtn.Text = "Подтвердить";
            submitRegBtn.UseVisualStyleBackColor = true;
            submitRegBtn.Click += submitRegBtn_Click;
            // 
            // surnameRegTxt
            // 
            surnameRegTxt.Location = new Point(117, 106);
            surnameRegTxt.Name = "surnameRegTxt";
            surnameRegTxt.Size = new Size(100, 23);
            surnameRegTxt.TabIndex = 7;
            // 
            // nameRegTxt
            // 
            nameRegTxt.Location = new Point(117, 78);
            nameRegTxt.Name = "nameRegTxt";
            nameRegTxt.Size = new Size(100, 23);
            nameRegTxt.TabIndex = 6;
            // 
            // passwordRegTxt
            // 
            passwordRegTxt.Location = new Point(117, 50);
            passwordRegTxt.MaxLength = 10;
            passwordRegTxt.Name = "passwordRegTxt";
            passwordRegTxt.Size = new Size(100, 23);
            passwordRegTxt.TabIndex = 5;
            passwordRegTxt.UseSystemPasswordChar = true;
            // 
            // loginRegTxt
            // 
            loginRegTxt.Location = new Point(117, 22);
            loginRegTxt.MaxLength = 10;
            loginRegTxt.Name = "loginRegTxt";
            loginRegTxt.Size = new Size(100, 23);
            loginRegTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 114);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 3;
            label5.Text = "Фамилия:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 86);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 58);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Логин:";
            // 
            // FormReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(370, 371);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            FormClosed += FormReg_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox passwordRegTxt;
        private TextBox loginRegTxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox surnameRegTxt;
        private TextBox nameRegTxt;
        private Button submitRegBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}