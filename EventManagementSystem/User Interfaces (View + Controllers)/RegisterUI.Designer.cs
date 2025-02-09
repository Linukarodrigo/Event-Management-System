namespace EventManagementSystem
{
    partial class RegisterUI
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
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.registerClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerName = new System.Windows.Forms.TextBox();
            this.registerPhone = new System.Windows.Forms.TextBox();
            this.registerClick = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.registerShowPwd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(5, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Event Management System";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EventManagementSystem.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(97, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 533);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "© 2024 All Rights Reserved. ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Making Event Planning Effortless";
            // 
            // registerClose
            // 
            this.registerClose.AutoSize = true;
            this.registerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerClose.Location = new System.Drawing.Point(641, 9);
            this.registerClose.Name = "registerClose";
            this.registerClose.Size = new System.Drawing.Size(23, 22);
            this.registerClose.TabIndex = 8;
            this.registerClose.Text = "X";
            this.registerClose.Click += new System.EventHandler(this.registerClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Registration Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Phone Number:";
            // 
            // registerUsername
            // 
            this.registerUsername.BackColor = System.Drawing.Color.White;
            this.registerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsername.ForeColor = System.Drawing.Color.Black;
            this.registerUsername.Location = new System.Drawing.Point(342, 128);
            this.registerUsername.Multiline = true;
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(304, 30);
            this.registerUsername.TabIndex = 11;
            // 
            // registerPassword
            // 
            this.registerPassword.BackColor = System.Drawing.Color.White;
            this.registerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPassword.ForeColor = System.Drawing.Color.Black;
            this.registerPassword.Location = new System.Drawing.Point(342, 197);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(304, 27);
            this.registerPassword.TabIndex = 11;
            this.registerPassword.UseSystemPasswordChar = true;
            // 
            // registerName
            // 
            this.registerName.BackColor = System.Drawing.Color.White;
            this.registerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerName.ForeColor = System.Drawing.Color.Black;
            this.registerName.Location = new System.Drawing.Point(342, 267);
            this.registerName.Multiline = true;
            this.registerName.Name = "registerName";
            this.registerName.Size = new System.Drawing.Size(304, 30);
            this.registerName.TabIndex = 11;
            // 
            // registerPhone
            // 
            this.registerPhone.BackColor = System.Drawing.Color.White;
            this.registerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPhone.ForeColor = System.Drawing.Color.Black;
            this.registerPhone.Location = new System.Drawing.Point(342, 330);
            this.registerPhone.Multiline = true;
            this.registerPhone.Name = "registerPhone";
            this.registerPhone.Size = new System.Drawing.Size(304, 30);
            this.registerPhone.TabIndex = 11;
            this.registerPhone.TextChanged += new System.EventHandler(this.registerPhone_TextChanged);
            // 
            // registerClick
            // 
            this.registerClick.AutoSize = true;
            this.registerClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerClick.ForeColor = System.Drawing.Color.DimGray;
            this.registerClick.Location = new System.Drawing.Point(497, 501);
            this.registerClick.Name = "registerClick";
            this.registerClick.Size = new System.Drawing.Size(90, 18);
            this.registerClick.TabIndex = 12;
            this.registerClick.Text = "Login Here";
            this.registerClick.Click += new System.EventHandler(this.registerClick_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(339, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Already Registered ?";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(342, 442);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(109, 35);
            this.RegisterBtn.TabIndex = 14;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(342, 390);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(151, 28);
            this.roleComboBox.TabIndex = 15;
            this.roleComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // registerShowPwd
            // 
            this.registerShowPwd.AutoSize = true;
            this.registerShowPwd.ForeColor = System.Drawing.Color.DimGray;
            this.registerShowPwd.Location = new System.Drawing.Point(519, 233);
            this.registerShowPwd.Name = "registerShowPwd";
            this.registerShowPwd.Size = new System.Drawing.Size(125, 20);
            this.registerShowPwd.TabIndex = 16;
            this.registerShowPwd.Text = "Show Password";
            this.registerShowPwd.UseVisualStyleBackColor = true;
            this.registerShowPwd.CheckedChanged += new System.EventHandler(this.registerShowPwd_CheckedChanged);
            // 
            // RegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 528);
            this.Controls.Add(this.registerShowPwd);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.registerClick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerPhone);
            this.Controls.Add(this.registerName);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label registerClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerName;
        private System.Windows.Forms.TextBox registerPhone;
        private System.Windows.Forms.Label registerClick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.CheckBox registerShowPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}