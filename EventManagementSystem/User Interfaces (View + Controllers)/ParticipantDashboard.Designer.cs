namespace EventManagementSystem
{
    partial class ParticipantDashboard
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
            this.paticipantDashClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.participantLogOut = new System.Windows.Forms.PictureBox();
            this.eventRegisterBtn = new System.Windows.Forms.Button();
            this.availableEventsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.availableEvents1 = new EventManagementSystem.AvailableEvents();
            this.eventBooking1 = new EventManagementSystem.EventBooking();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.paticipantDashClose);
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
            this.label1.Location = new System.Drawing.Point(460, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "participant Dashboard";
            // 
            // paticipantDashClose
            // 
            this.paticipantDashClose.AutoSize = true;
            this.paticipantDashClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paticipantDashClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paticipantDashClose.ForeColor = System.Drawing.Color.White;
            this.paticipantDashClose.Location = new System.Drawing.Point(1052, 6);
            this.paticipantDashClose.Name = "paticipantDashClose";
            this.paticipantDashClose.Size = new System.Drawing.Size(23, 22);
            this.paticipantDashClose.TabIndex = 10;
            this.paticipantDashClose.Text = "X";
            this.paticipantDashClose.Click += new System.EventHandler(this.paticipantDashClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.participantLogOut);
            this.panel2.Controls.Add(this.eventRegisterBtn);
            this.panel2.Controls.Add(this.availableEventsBtn);
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
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sign Out";
            // 
            // participantLogOut
            // 
            this.participantLogOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.participantLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participantLogOut.Image = global::EventManagementSystem.Properties.Resources.logout;
            this.participantLogOut.Location = new System.Drawing.Point(8, 477);
            this.participantLogOut.Name = "participantLogOut";
            this.participantLogOut.Size = new System.Drawing.Size(31, 34);
            this.participantLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.participantLogOut.TabIndex = 15;
            this.participantLogOut.TabStop = false;
            this.participantLogOut.Click += new System.EventHandler(this.participantLogOut_Click);
            // 
            // eventRegisterBtn
            // 
            this.eventRegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventRegisterBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventRegisterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventRegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventRegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventRegisterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventRegisterBtn.ForeColor = System.Drawing.Color.White;
            this.eventRegisterBtn.Location = new System.Drawing.Point(7, 328);
            this.eventRegisterBtn.Name = "eventRegisterBtn";
            this.eventRegisterBtn.Size = new System.Drawing.Size(210, 40);
            this.eventRegisterBtn.TabIndex = 13;
            this.eventRegisterBtn.Text = "Event Registration";
            this.eventRegisterBtn.UseVisualStyleBackColor = true;
            this.eventRegisterBtn.Click += new System.EventHandler(this.eventRegisterBtn_Click);
            // 
            // availableEventsBtn
            // 
            this.availableEventsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availableEventsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.availableEventsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.availableEventsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.availableEventsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableEventsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableEventsBtn.ForeColor = System.Drawing.Color.White;
            this.availableEventsBtn.Location = new System.Drawing.Point(7, 230);
            this.availableEventsBtn.Name = "availableEventsBtn";
            this.availableEventsBtn.Size = new System.Drawing.Size(210, 40);
            this.availableEventsBtn.TabIndex = 13;
            this.availableEventsBtn.Text = "Available Events";
            this.availableEventsBtn.UseVisualStyleBackColor = true;
            this.availableEventsBtn.Click += new System.EventHandler(this.availableEventsBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventManagementSystem.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(62, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.availableEvents1);
            this.panel3.Controls.Add(this.eventBooking1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 518);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Welcome, Participant";
            // 
            // availableEvents1
            // 
            this.availableEvents1.Location = new System.Drawing.Point(0, 0);
            this.availableEvents1.Name = "availableEvents1";
            this.availableEvents1.Size = new System.Drawing.Size(857, 518);
            this.availableEvents1.TabIndex = 1;
            // 
            // eventBooking1
            // 
            this.eventBooking1.Location = new System.Drawing.Point(0, 0);
            this.eventBooking1.Name = "eventBooking1";
            this.eventBooking1.Size = new System.Drawing.Size(857, 518);
            this.eventBooking1.TabIndex = 0;
            // 
            // ParticipantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParticipantDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParticipantDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paticipantDashClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button availableEventsBtn;
        private System.Windows.Forms.Button eventRegisterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox participantLogOut;
        private System.Windows.Forms.Panel panel3;
        private AvailableEvents availableEvents1;
        private EventBooking eventBooking1;
        private System.Windows.Forms.Label label2;
    }
}