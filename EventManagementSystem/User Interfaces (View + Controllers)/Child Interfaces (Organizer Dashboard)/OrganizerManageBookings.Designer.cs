namespace EventManagementSystem
{
    partial class OrganizerManageBookings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bookingsGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookingDate = new System.Windows.Forms.DateTimePicker();
            this.bookingCancelBtn = new System.Windows.Forms.Button();
            this.bookingParticipantIDTxt = new System.Windows.Forms.TextBox();
            this.bookingeventIDTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bookingsGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(5, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 359);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(215, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(549, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "*Please click a row in the table to retrieve data into the fields (To cancel a bo" +
    "oking)";
            // 
            // bookingsGridView
            // 
            this.bookingsGridView.AllowUserToAddRows = false;
            this.bookingsGridView.AllowUserToDeleteRows = false;
            this.bookingsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsGridView.EnableHeadersVisualStyles = false;
            this.bookingsGridView.Location = new System.Drawing.Point(13, 39);
            this.bookingsGridView.Name = "bookingsGridView";
            this.bookingsGridView.ReadOnly = true;
            this.bookingsGridView.RowHeadersVisible = false;
            this.bookingsGridView.RowHeadersWidth = 51;
            this.bookingsGridView.RowTemplate.Height = 24;
            this.bookingsGridView.Size = new System.Drawing.Size(822, 301);
            this.bookingsGridView.TabIndex = 2;
            this.bookingsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingsGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bookings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bookingDate);
            this.panel2.Controls.Add(this.bookingCancelBtn);
            this.panel2.Controls.Add(this.bookingParticipantIDTxt);
            this.panel2.Controls.Add(this.bookingeventIDTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 131);
            this.panel2.TabIndex = 2;
            // 
            // bookingDate
            // 
            this.bookingDate.Location = new System.Drawing.Point(511, 38);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Size = new System.Drawing.Size(268, 22);
            this.bookingDate.TabIndex = 7;
            // 
            // bookingCancelBtn
            // 
            this.bookingCancelBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.bookingCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingCancelBtn.FlatAppearance.BorderSize = 0;
            this.bookingCancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.bookingCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.bookingCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.bookingCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingCancelBtn.ForeColor = System.Drawing.Color.White;
            this.bookingCancelBtn.Location = new System.Drawing.Point(314, 79);
            this.bookingCancelBtn.Name = "bookingCancelBtn";
            this.bookingCancelBtn.Size = new System.Drawing.Size(184, 43);
            this.bookingCancelBtn.TabIndex = 6;
            this.bookingCancelBtn.Text = "Cancel Booking";
            this.bookingCancelBtn.UseVisualStyleBackColor = false;
            this.bookingCancelBtn.Click += new System.EventHandler(this.bookingCancelBtn_Click);
            // 
            // bookingParticipantIDTxt
            // 
            this.bookingParticipantIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingParticipantIDTxt.Location = new System.Drawing.Point(269, 38);
            this.bookingParticipantIDTxt.Multiline = true;
            this.bookingParticipantIDTxt.Name = "bookingParticipantIDTxt";
            this.bookingParticipantIDTxt.ReadOnly = true;
            this.bookingParticipantIDTxt.Size = new System.Drawing.Size(117, 25);
            this.bookingParticipantIDTxt.TabIndex = 3;
            this.bookingParticipantIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookingeventIDTxt
            // 
            this.bookingeventIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingeventIDTxt.Location = new System.Drawing.Point(46, 38);
            this.bookingeventIDTxt.Multiline = true;
            this.bookingeventIDTxt.Name = "bookingeventIDTxt";
            this.bookingeventIDTxt.ReadOnly = true;
            this.bookingeventIDTxt.Size = new System.Drawing.Size(109, 25);
            this.bookingeventIDTxt.TabIndex = 3;
            this.bookingeventIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Participant ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Booking Date:";
            // 
            // OrganizerManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrganizerManageBookings";
            this.Size = new System.Drawing.Size(857, 518);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bookingsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker bookingDate;
        private System.Windows.Forms.Button bookingCancelBtn;
        private System.Windows.Forms.TextBox bookingParticipantIDTxt;
        private System.Windows.Forms.TextBox bookingeventIDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
