namespace EventManagementSystem
{
    partial class EventBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookingGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.eventIDCombo = new System.Windows.Forms.ComboBox();
            this.participantIDCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bookingEventNameTxt = new System.Windows.Forms.TextBox();
            this.bookingParticipantNameTxt = new System.Windows.Forms.TextBox();
            this.eventBookingBtn = new System.Windows.Forms.Button();
            this.eventBookingCancelBtn = new System.Windows.Forms.Button();
            this.eventClearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bookingGridView);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 322);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(183, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(549, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "*Please click a row in the table to retrieve data into the fields (To cancel a bo" +
    "oking)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bookings";
            // 
            // bookingGridView
            // 
            this.bookingGridView.AllowUserToAddRows = false;
            this.bookingGridView.AllowUserToDeleteRows = false;
            this.bookingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGridView.EnableHeadersVisualStyles = false;
            this.bookingGridView.Location = new System.Drawing.Point(19, 41);
            this.bookingGridView.Name = "bookingGridView";
            this.bookingGridView.ReadOnly = true;
            this.bookingGridView.RowHeadersVisible = false;
            this.bookingGridView.RowHeadersWidth = 51;
            this.bookingGridView.RowTemplate.Height = 24;
            this.bookingGridView.Size = new System.Drawing.Size(794, 264);
            this.bookingGridView.TabIndex = 0;
            this.bookingGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingGridView_CellClick);
            this.bookingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event ID:";
            // 
            // eventIDCombo
            // 
            this.eventIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventIDCombo.FormattingEnabled = true;
            this.eventIDCombo.Location = new System.Drawing.Point(205, 360);
            this.eventIDCombo.Name = "eventIDCombo";
            this.eventIDCombo.Size = new System.Drawing.Size(76, 24);
            this.eventIDCombo.TabIndex = 3;
            this.eventIDCombo.SelectedIndexChanged += new System.EventHandler(this.eventIDCombo_SelectedIndexChanged);
            // 
            // participantIDCombo
            // 
            this.participantIDCombo.FormattingEnabled = true;
            this.participantIDCombo.Location = new System.Drawing.Point(205, 409);
            this.participantIDCombo.Name = "participantIDCombo";
            this.participantIDCombo.Size = new System.Drawing.Size(76, 24);
            this.participantIDCombo.TabIndex = 5;
            this.participantIDCombo.SelectedIndexChanged += new System.EventHandler(this.participantIDCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Participant ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "participant Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Event Name:";
            // 
            // bookingEventNameTxt
            // 
            this.bookingEventNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingEventNameTxt.Location = new System.Drawing.Point(523, 360);
            this.bookingEventNameTxt.Name = "bookingEventNameTxt";
            this.bookingEventNameTxt.ReadOnly = true;
            this.bookingEventNameTxt.Size = new System.Drawing.Size(200, 24);
            this.bookingEventNameTxt.TabIndex = 10;
            // 
            // bookingParticipantNameTxt
            // 
            this.bookingParticipantNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingParticipantNameTxt.Location = new System.Drawing.Point(523, 409);
            this.bookingParticipantNameTxt.Name = "bookingParticipantNameTxt";
            this.bookingParticipantNameTxt.ReadOnly = true;
            this.bookingParticipantNameTxt.Size = new System.Drawing.Size(200, 24);
            this.bookingParticipantNameTxt.TabIndex = 11;
            // 
            // eventBookingBtn
            // 
            this.eventBookingBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventBookingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventBookingBtn.FlatAppearance.BorderSize = 0;
            this.eventBookingBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventBookingBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBookingBtn.ForeColor = System.Drawing.Color.White;
            this.eventBookingBtn.Location = new System.Drawing.Point(128, 458);
            this.eventBookingBtn.Name = "eventBookingBtn";
            this.eventBookingBtn.Size = new System.Drawing.Size(165, 43);
            this.eventBookingBtn.TabIndex = 12;
            this.eventBookingBtn.Text = "Create Booking";
            this.eventBookingBtn.UseVisualStyleBackColor = false;
            this.eventBookingBtn.Click += new System.EventHandler(this.eventBookingBtn_Click);
            // 
            // eventBookingCancelBtn
            // 
            this.eventBookingCancelBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventBookingCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventBookingCancelBtn.FlatAppearance.BorderSize = 0;
            this.eventBookingCancelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventBookingCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventBookingCancelBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBookingCancelBtn.ForeColor = System.Drawing.Color.White;
            this.eventBookingCancelBtn.Location = new System.Drawing.Point(350, 458);
            this.eventBookingCancelBtn.Name = "eventBookingCancelBtn";
            this.eventBookingCancelBtn.Size = new System.Drawing.Size(178, 43);
            this.eventBookingCancelBtn.TabIndex = 13;
            this.eventBookingCancelBtn.Text = "Cancel Booking";
            this.eventBookingCancelBtn.UseVisualStyleBackColor = false;
            this.eventBookingCancelBtn.Click += new System.EventHandler(this.eventBookingCancelBtn_Click);
            // 
            // eventClearBtn
            // 
            this.eventClearBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventClearBtn.FlatAppearance.BorderSize = 0;
            this.eventClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventClearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventClearBtn.ForeColor = System.Drawing.Color.White;
            this.eventClearBtn.Location = new System.Drawing.Point(589, 458);
            this.eventClearBtn.Name = "eventClearBtn";
            this.eventClearBtn.Size = new System.Drawing.Size(102, 43);
            this.eventClearBtn.TabIndex = 14;
            this.eventClearBtn.Text = "Clear";
            this.eventClearBtn.UseVisualStyleBackColor = false;
            this.eventClearBtn.Click += new System.EventHandler(this.eventClearBtn_Click);
            // 
            // EventBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventClearBtn);
            this.Controls.Add(this.eventBookingCancelBtn);
            this.Controls.Add(this.eventBookingBtn);
            this.Controls.Add(this.bookingParticipantNameTxt);
            this.Controls.Add(this.bookingEventNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.participantIDCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventIDCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "EventBooking";
            this.Size = new System.Drawing.Size(857, 518);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bookingGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eventIDCombo;
        private System.Windows.Forms.ComboBox participantIDCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookingEventNameTxt;
        private System.Windows.Forms.TextBox bookingParticipantNameTxt;
        private System.Windows.Forms.Button eventBookingBtn;
        private System.Windows.Forms.Button eventBookingCancelBtn;
        private System.Windows.Forms.Button eventClearBtn;
        private System.Windows.Forms.Label label8;
    }
}
