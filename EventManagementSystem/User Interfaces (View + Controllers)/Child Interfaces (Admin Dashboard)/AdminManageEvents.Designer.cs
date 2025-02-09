namespace EventManagementSystem
{
    partial class AdminManageEvents
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.eventGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.organizerNameTxt = new System.Windows.Forms.TextBox();
            this.eventClearBtn = new System.Windows.Forms.Button();
            this.eventDeleteBtn = new System.Windows.Forms.Button();
            this.eventEditBtn = new System.Windows.Forms.Button();
            this.eventCreateBtn = new System.Windows.Forms.Button();
            this.eventOrganizerIDCombo = new System.Windows.Forms.ComboBox();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.maxParticipantsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eventVenueTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventDescTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.eventGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 265);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(218, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "*Please click a row in the table to retrieve data into the fields (To Edit and De" +
    "lete)";
            // 
            // eventGridView
            // 
            this.eventGridView.AllowUserToAddRows = false;
            this.eventGridView.AllowUserToDeleteRows = false;
            this.eventGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.eventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView.EnableHeadersVisualStyles = false;
            this.eventGridView.Location = new System.Drawing.Point(8, 42);
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.RowHeadersVisible = false;
            this.eventGridView.RowHeadersWidth = 51;
            this.eventGridView.RowTemplate.Height = 24;
            this.eventGridView.Size = new System.Drawing.Size(824, 206);
            this.eventGridView.TabIndex = 1;
            this.eventGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGridView_CellClick);
            this.eventGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.organizerNameTxt);
            this.panel2.Controls.Add(this.eventClearBtn);
            this.panel2.Controls.Add(this.eventDeleteBtn);
            this.panel2.Controls.Add(this.eventEditBtn);
            this.panel2.Controls.Add(this.eventCreateBtn);
            this.panel2.Controls.Add(this.eventOrganizerIDCombo);
            this.panel2.Controls.Add(this.eventDate);
            this.panel2.Controls.Add(this.maxParticipantsTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.eventVenueTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.eventDescTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.eventNameTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 237);
            this.panel2.TabIndex = 1;
            // 
            // organizerNameTxt
            // 
            this.organizerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerNameTxt.Location = new System.Drawing.Point(687, 21);
            this.organizerNameTxt.Name = "organizerNameTxt";
            this.organizerNameTxt.ReadOnly = true;
            this.organizerNameTxt.Size = new System.Drawing.Size(146, 24);
            this.organizerNameTxt.TabIndex = 7;
            this.organizerNameTxt.TextChanged += new System.EventHandler(this.organizerNameTxt_TextChanged);
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
            this.eventClearBtn.Location = new System.Drawing.Point(597, 174);
            this.eventClearBtn.Name = "eventClearBtn";
            this.eventClearBtn.Size = new System.Drawing.Size(102, 43);
            this.eventClearBtn.TabIndex = 5;
            this.eventClearBtn.Text = "Clear";
            this.eventClearBtn.UseVisualStyleBackColor = false;
            this.eventClearBtn.Click += new System.EventHandler(this.eventClearBtn_Click);
            // 
            // eventDeleteBtn
            // 
            this.eventDeleteBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventDeleteBtn.FlatAppearance.BorderSize = 0;
            this.eventDeleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventDeleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.eventDeleteBtn.Location = new System.Drawing.Point(446, 174);
            this.eventDeleteBtn.Name = "eventDeleteBtn";
            this.eventDeleteBtn.Size = new System.Drawing.Size(102, 43);
            this.eventDeleteBtn.TabIndex = 4;
            this.eventDeleteBtn.Text = "Delete";
            this.eventDeleteBtn.UseVisualStyleBackColor = false;
            this.eventDeleteBtn.Click += new System.EventHandler(this.eventDeleteBtn_Click);
            // 
            // eventEditBtn
            // 
            this.eventEditBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventEditBtn.FlatAppearance.BorderSize = 0;
            this.eventEditBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventEditBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventEditBtn.ForeColor = System.Drawing.Color.White;
            this.eventEditBtn.Location = new System.Drawing.Point(291, 174);
            this.eventEditBtn.Name = "eventEditBtn";
            this.eventEditBtn.Size = new System.Drawing.Size(102, 43);
            this.eventEditBtn.TabIndex = 4;
            this.eventEditBtn.Text = "Edit";
            this.eventEditBtn.UseVisualStyleBackColor = false;
            this.eventEditBtn.Click += new System.EventHandler(this.eventEditBtn_Click);
            // 
            // eventCreateBtn
            // 
            this.eventCreateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.eventCreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eventCreateBtn.FlatAppearance.BorderSize = 0;
            this.eventCreateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.eventCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventCreateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventCreateBtn.ForeColor = System.Drawing.Color.White;
            this.eventCreateBtn.Location = new System.Drawing.Point(138, 174);
            this.eventCreateBtn.Name = "eventCreateBtn";
            this.eventCreateBtn.Size = new System.Drawing.Size(102, 43);
            this.eventCreateBtn.TabIndex = 4;
            this.eventCreateBtn.Text = "Create";
            this.eventCreateBtn.UseVisualStyleBackColor = false;
            this.eventCreateBtn.Click += new System.EventHandler(this.eventCreateBtn_Click);
            // 
            // eventOrganizerIDCombo
            // 
            this.eventOrganizerIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventOrganizerIDCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventOrganizerIDCombo.FormattingEnabled = true;
            this.eventOrganizerIDCombo.Location = new System.Drawing.Point(437, 19);
            this.eventOrganizerIDCombo.Name = "eventOrganizerIDCombo";
            this.eventOrganizerIDCombo.Size = new System.Drawing.Size(93, 26);
            this.eventOrganizerIDCombo.TabIndex = 3;
            this.eventOrganizerIDCombo.SelectedIndexChanged += new System.EventHandler(this.eventOrganizerIDCombo_SelectedIndexChanged);
            // 
            // eventDate
            // 
            this.eventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDate.Location = new System.Drawing.Point(675, 87);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(157, 24);
            this.eventDate.TabIndex = 2;
            // 
            // maxParticipantsTxt
            // 
            this.maxParticipantsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxParticipantsTxt.Location = new System.Drawing.Point(482, 89);
            this.maxParticipantsTxt.Name = "maxParticipantsTxt";
            this.maxParticipantsTxt.Size = new System.Drawing.Size(83, 24);
            this.maxParticipantsTxt.TabIndex = 1;
            this.maxParticipantsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxParticipantsTxt.TextChanged += new System.EventHandler(this.maxParticipantsTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maximum Participants:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Event Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(323, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Organizer ID:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Organizer\'s Name:";
            // 
            // eventVenueTxt
            // 
            this.eventVenueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventVenueTxt.Location = new System.Drawing.Point(123, 120);
            this.eventVenueTxt.Name = "eventVenueTxt";
            this.eventVenueTxt.Size = new System.Drawing.Size(159, 24);
            this.eventVenueTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Venue:";
            // 
            // eventDescTxt
            // 
            this.eventDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDescTxt.Location = new System.Drawing.Point(123, 70);
            this.eventDescTxt.Name = "eventDescTxt";
            this.eventDescTxt.Size = new System.Drawing.Size(159, 24);
            this.eventDescTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // eventNameTxt
            // 
            this.eventNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameTxt.Location = new System.Drawing.Point(123, 21);
            this.eventNameTxt.Name = "eventNameTxt";
            this.eventNameTxt.Size = new System.Drawing.Size(159, 24);
            this.eventNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event Name:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AdminManageEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminManageEvents";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView eventGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxParticipantsTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventVenueTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventDescTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventNameTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.Button eventDeleteBtn;
        private System.Windows.Forms.Button eventEditBtn;
        private System.Windows.Forms.Button eventCreateBtn;
        private System.Windows.Forms.Button eventClearBtn;
        private System.Windows.Forms.ComboBox eventOrganizerIDCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox organizerNameTxt;
        private System.Windows.Forms.Label label8;
    }
}
