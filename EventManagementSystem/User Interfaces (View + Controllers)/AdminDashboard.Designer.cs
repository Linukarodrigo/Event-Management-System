namespace EventManagementSystem
{
    partial class AdminDashboard
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
            this.adminClose = new System.Windows.Forms.Label();
            this.registerClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageOrganizersBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.viewBookingsBtn = new System.Windows.Forms.Button();
            this.manageParticipantsBtn = new System.Windows.Forms.Button();
            this.manageEventsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.manageEvents1 = new EventManagementSystem.AdminManageEvents();
            this.manageParticipants1 = new EventManagementSystem.ManageParticipants();
            this.manageOrganizers1 = new EventManagementSystem.ManageOrganizers();
            this.manageBookings1 = new EventManagementSystem.AdminManageBookings();
            this.adminLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminClose
            // 
            this.adminClose.Location = new System.Drawing.Point(0, 0);
            this.adminClose.Name = "adminClose";
            this.adminClose.Size = new System.Drawing.Size(100, 23);
            this.adminClose.TabIndex = 0;
            // 
            // registerClose
            // 
            this.registerClose.AutoSize = true;
            this.registerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerClose.ForeColor = System.Drawing.Color.White;
            this.registerClose.Location = new System.Drawing.Point(1067, 6);
            this.registerClose.Name = "registerClose";
            this.registerClose.Size = new System.Drawing.Size(23, 22);
            this.registerClose.TabIndex = 9;
            this.registerClose.Text = "X";
            this.registerClose.Click += new System.EventHandler(this.registerClose_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.manageOrganizersBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.adminLogOut);
            this.panel2.Controls.Add(this.viewBookingsBtn);
            this.panel2.Controls.Add(this.manageParticipantsBtn);
            this.panel2.Controls.Add(this.manageEventsBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 565);
            this.panel2.TabIndex = 11;
            // 
            // manageOrganizersBtn
            // 
            this.manageOrganizersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageOrganizersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageOrganizersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageOrganizersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageOrganizersBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.manageOrganizersBtn.ForeColor = System.Drawing.Color.White;
            this.manageOrganizersBtn.Location = new System.Drawing.Point(7, 376);
            this.manageOrganizersBtn.Name = "manageOrganizersBtn";
            this.manageOrganizersBtn.Size = new System.Drawing.Size(210, 40);
            this.manageOrganizersBtn.TabIndex = 3;
            this.manageOrganizersBtn.Text = "Manage Organizers";
            this.manageOrganizersBtn.UseVisualStyleBackColor = true;
            this.manageOrganizersBtn.Click += new System.EventHandler(this.manageOrganizersBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sign Out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // viewBookingsBtn
            // 
            this.viewBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBookingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.viewBookingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.viewBookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.viewBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBookingsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookingsBtn.ForeColor = System.Drawing.Color.White;
            this.viewBookingsBtn.Location = new System.Drawing.Point(7, 439);
            this.viewBookingsBtn.Name = "viewBookingsBtn";
            this.viewBookingsBtn.Size = new System.Drawing.Size(210, 40);
            this.viewBookingsBtn.TabIndex = 12;
            this.viewBookingsBtn.Text = "Bookings";
            this.viewBookingsBtn.UseVisualStyleBackColor = true;
            this.viewBookingsBtn.Click += new System.EventHandler(this.viewBookingsBtn_Click);
            // 
            // manageParticipantsBtn
            // 
            this.manageParticipantsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageParticipantsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageParticipantsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageParticipantsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageParticipantsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageParticipantsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageParticipantsBtn.ForeColor = System.Drawing.Color.White;
            this.manageParticipantsBtn.Location = new System.Drawing.Point(7, 316);
            this.manageParticipantsBtn.Name = "manageParticipantsBtn";
            this.manageParticipantsBtn.Size = new System.Drawing.Size(210, 40);
            this.manageParticipantsBtn.TabIndex = 12;
            this.manageParticipantsBtn.Text = "Manage Participants";
            this.manageParticipantsBtn.UseVisualStyleBackColor = true;
            this.manageParticipantsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // manageEventsBtn
            // 
            this.manageEventsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageEventsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageEventsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageEventsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.manageEventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageEventsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEventsBtn.ForeColor = System.Drawing.Color.White;
            this.manageEventsBtn.Location = new System.Drawing.Point(7, 257);
            this.manageEventsBtn.Name = "manageEventsBtn";
            this.manageEventsBtn.Size = new System.Drawing.Size(210, 40);
            this.manageEventsBtn.TabIndex = 12;
            this.manageEventsBtn.Text = "Manage Events";
            this.manageEventsBtn.UseVisualStyleBackColor = true;
            this.manageEventsBtn.Click += new System.EventHandler(this.manageEventsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome, Admin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.manageEvents1);
            this.panel3.Controls.Add(this.manageParticipants1);
            this.panel3.Controls.Add(this.manageOrganizers1);
            this.panel3.Controls.Add(this.manageBookings1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 565);
            this.panel3.TabIndex = 12;
            // 
            // manageEvents1
            // 
            this.manageEvents1.Location = new System.Drawing.Point(-2, 0);
            this.manageEvents1.Name = "manageEvents1";
            this.manageEvents1.Size = new System.Drawing.Size(877, 565);
            this.manageEvents1.TabIndex = 2;
            this.manageEvents1.Load += new System.EventHandler(this.manageEvents1_Load);
            // 
            // manageParticipants1
            // 
            this.manageParticipants1.Location = new System.Drawing.Point(-2, 0);
            this.manageParticipants1.Name = "manageParticipants1";
            this.manageParticipants1.Size = new System.Drawing.Size(875, 565);
            this.manageParticipants1.TabIndex = 2;
            // 
            // manageOrganizers1
            // 
            this.manageOrganizers1.Location = new System.Drawing.Point(0, 0);
            this.manageOrganizers1.Name = "manageOrganizers1";
            this.manageOrganizers1.Size = new System.Drawing.Size(875, 565);
            this.manageOrganizers1.TabIndex = 1;
            // 
            // manageBookings1
            // 
            this.manageBookings1.Location = new System.Drawing.Point(0, 0);
            this.manageBookings1.Name = "manageBookings1";
            this.manageBookings1.Size = new System.Drawing.Size(875, 565);
            this.manageBookings1.TabIndex = 0;
            // 
            // adminLogOut
            // 
            this.adminLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminLogOut.Image = global::EventManagementSystem.Properties.Resources.logout;
            this.adminLogOut.Location = new System.Drawing.Point(12, 513);
            this.adminLogOut.Name = "adminLogOut";
            this.adminLogOut.Size = new System.Drawing.Size(31, 34);
            this.adminLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminLogOut.TabIndex = 12;
            this.adminLogOut.TabStop = false;
            this.adminLogOut.Click += new System.EventHandler(this.adminLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventManagementSystem.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(62, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminClose;
        private System.Windows.Forms.Label registerClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manageEventsBtn;
        private System.Windows.Forms.Button viewBookingsBtn;
        private System.Windows.Forms.Button manageParticipantsBtn;
        private System.Windows.Forms.PictureBox adminLogOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private AdminManageEvents manageEvents1;
        private AdminManageBookings manageBookings1;
        private System.Windows.Forms.Button manageOrganizersBtn;
        private ManageParticipants manageParticipants1;
        private ManageOrganizers manageOrganizers1;
    }
}