namespace App
{
    partial class FormAuth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkToReg = new LinkLabel();
            submitBtn = new Button();
            passwordTxt = new TextBox();
            loginTxt = new TextBox();
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
            panel1.Size = new Size(346, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(78, 24);
            label1.Name = "label1";
            label1.Size = new Size(196, 41);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkToReg);
            panel2.Controls.Add(submitBtn);
            panel2.Controls.Add(passwordTxt);
            panel2.Controls.Add(loginTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 185);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._3994371_eye_hidden_hide_invisible_private_icon;
            pictureBox2.Location = new Point(254, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources._9041325_eye_fill_icon;
            pictureBox1.Location = new Point(224, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // linkToReg
            // 
            linkToReg.AutoSize = true;
            linkToReg.Cursor = Cursors.Hand;
            linkToReg.Location = new Point(30, 144);
            linkToReg.Name = "linkToReg";
            linkToReg.Size = new Size(157, 15);
            linkToReg.TabIndex = 5;
            linkToReg.TabStop = true;
            linkToReg.Text = "Вы не зарегистрированны?";
            linkToReg.LinkClicked += linkToReg_LinkClicked;
            // 
            // submitBtn
            // 
            submitBtn.Cursor = Cursors.Hand;
            submitBtn.FlatStyle = FlatStyle.Popup;
            submitBtn.Location = new Point(118, 90);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(100, 23);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Войти";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(118, 51);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(100, 23);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginTxt
            // 
            loginTxt.Location = new Point(118, 24);
            loginTxt.MaxLength = 10;
            loginTxt.Name = "loginTxt";
            loginTxt.Size = new Size(100, 23);
            loginTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 59);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 27);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Логин:";
            // 
            // FormAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(370, 303);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosed += FormAuth_FormClosed;
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
        private Label label3;
        private Label label2;
        private TextBox passwordTxt;
        private TextBox loginTxt;
        private LinkLabel linkToReg;
        private Button submitBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
