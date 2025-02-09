namespace EventManagementSystem
{
    partial class OrganizerDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.registerClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.organizerBookingsBtn = new System.Windows.Forms.Button();
            this.oraganizerManageEventsBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.organizerLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.organizerManageEvents1 = new EventManagementSystem.OrganizerManageEvents();
            this.organizerManageBookings1 = new EventManagementSystem.OrganizerManageBookings();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizerLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.registerClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Organizer Dashboard";
            // 
            // registerClose
            // 
            this.registerClose.AutoSize = true;
            this.registerClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerClose.ForeColor = System.Drawing.Color.White;
            this.registerClose.Location = new System.Drawing.Point(1050, 7);
            this.registerClose.Name = "registerClose";
            this.registerClose.Size = new System.Drawing.Size(23, 22);
            this.registerClose.TabIndex = 12;
            this.registerClose.Text = "X";
            this.registerClose.Click += new System.EventHandler(this.registerClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.organizerLogOut);
            this.panel2.Controls.Add(this.organizerBookingsBtn);
            this.panel2.Controls.Add(this.oraganizerManageEventsBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 518);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sign Out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // organizerBookingsBtn
            // 
            this.organizerBookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerBookingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerBookingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerBookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerBookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerBookingsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerBookingsBtn.ForeColor = System.Drawing.Color.White;
            this.organizerBookingsBtn.Location = new System.Drawing.Point(7, 345);
            this.organizerBookingsBtn.Name = "organizerBookingsBtn";
            this.organizerBookingsBtn.Size = new System.Drawing.Size(210, 40);
            this.organizerBookingsBtn.TabIndex = 15;
            this.organizerBookingsBtn.Text = "Bookings";
            this.organizerBookingsBtn.UseVisualStyleBackColor = true;
            this.organizerBookingsBtn.Click += new System.EventHandler(this.organizerBookingsBtn_Click);
            // 
            // oraganizerManageEventsBtn
            // 
            this.oraganizerManageEventsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oraganizerManageEventsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.oraganizerManageEventsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.oraganizerManageEventsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.oraganizerManageEventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oraganizerManageEventsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oraganizerManageEventsBtn.ForeColor = System.Drawing.Color.White;
            this.oraganizerManageEventsBtn.Location = new System.Drawing.Point(7, 250);
            this.oraganizerManageEventsBtn.Name = "oraganizerManageEventsBtn";
            this.oraganizerManageEventsBtn.Size = new System.Drawing.Size(210, 40);
            this.oraganizerManageEventsBtn.TabIndex = 14;
            this.oraganizerManageEventsBtn.Text = "Manage Events";
            this.oraganizerManageEventsBtn.UseVisualStyleBackColor = true;
            this.oraganizerManageEventsBtn.Click += new System.EventHandler(this.oraganizerManageEventsBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.organizerManageEvents1);
            this.panel3.Controls.Add(this.organizerManageBookings1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 518);
            this.panel3.TabIndex = 2;
            // 
            // organizerLogOut
            // 
            this.organizerLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerLogOut.Image = global::EventManagementSystem.Properties.Resources.logout;
            this.organizerLogOut.Location = new System.Drawing.Point(7, 480);
            this.organizerLogOut.Name = "organizerLogOut";
            this.organizerLogOut.Size = new System.Drawing.Size(31, 34);
            this.organizerLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.organizerLogOut.TabIndex = 17;
            this.organizerLogOut.TabStop = false;
            this.organizerLogOut.Click += new System.EventHandler(this.adminLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventManagementSystem.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(62, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Welcome, Organizer";
            // 
            // organizerManageEvents1
            // 
            this.organizerManageEvents1.Location = new System.Drawing.Point(0, 0);
            this.organizerManageEvents1.Name = "organizerManageEvents1";
            this.organizerManageEvents1.Size = new System.Drawing.Size(857, 518);
            this.organizerManageEvents1.TabIndex = 1;
            // 
            // organizerManageBookings1
            // 
            this.organizerManageBookings1.Location = new System.Drawing.Point(0, 0);
            this.organizerManageBookings1.Name = "organizerManageBookings1";
            this.organizerManageBookings1.Size = new System.Drawing.Size(857, 518);
            this.organizerManageBookings1.TabIndex = 0;
            // 
            // OrganizerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrganizerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizerDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organizerLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registerClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button oraganizerManageEventsBtn;
        private System.Windows.Forms.Button organizerBookingsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox organizerLogOut;
        private System.Windows.Forms.Panel panel3;
        private OrganizerManageEvents organizerManageEvents1;
        private OrganizerManageBookings organizerManageBookings1;
        private System.Windows.Forms.Label label2;
    }
}