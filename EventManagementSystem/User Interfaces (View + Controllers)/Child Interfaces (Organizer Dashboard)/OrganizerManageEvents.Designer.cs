namespace EventManagementSystem
{
    partial class OrganizerManageEvents
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
            this.organizerEventGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.organizerEventClearBtn = new System.Windows.Forms.Button();
            this.organizerEventEditBtn = new System.Windows.Forms.Button();
            this.organizerEventCreateBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.organizerNameTxt = new System.Windows.Forms.TextBox();
            this.organizerEventDeleteBtn = new System.Windows.Forms.Button();
            this.organizerEventOrganizerIDCombo = new System.Windows.Forms.ComboBox();
            this.organizerEventDate = new System.Windows.Forms.DateTimePicker();
            this.organizerMaxParticipantsTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.organizerEventVenueTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.organizerEventDescTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.organizerEventNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.organizerEventGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // organizerEventGridView
            // 
            this.organizerEventGridView.AllowUserToAddRows = false;
            this.organizerEventGridView.AllowUserToDeleteRows = false;
            this.organizerEventGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.organizerEventGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.organizerEventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizerEventGridView.EnableHeadersVisualStyles = false;
            this.organizerEventGridView.Location = new System.Drawing.Point(8, 42);
            this.organizerEventGridView.Name = "organizerEventGridView";
            this.organizerEventGridView.ReadOnly = true;
            this.organizerEventGridView.RowHeadersVisible = false;
            this.organizerEventGridView.RowHeadersWidth = 51;
            this.organizerEventGridView.RowTemplate.Height = 24;
            this.organizerEventGridView.Size = new System.Drawing.Size(824, 206);
            this.organizerEventGridView.TabIndex = 1;
            this.organizerEventGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.organizerEventGridView_CellClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.organizerEventGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 265);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(218, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "*Please click a row in the table to retrieve data into the fields (To Edit and De" +
    "lete)";
            // 
            // organizerEventClearBtn
            // 
            this.organizerEventClearBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.organizerEventClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerEventClearBtn.FlatAppearance.BorderSize = 0;
            this.organizerEventClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerEventClearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventClearBtn.ForeColor = System.Drawing.Color.White;
            this.organizerEventClearBtn.Location = new System.Drawing.Point(597, 164);
            this.organizerEventClearBtn.Name = "organizerEventClearBtn";
            this.organizerEventClearBtn.Size = new System.Drawing.Size(102, 43);
            this.organizerEventClearBtn.TabIndex = 5;
            this.organizerEventClearBtn.Text = "Clear";
            this.organizerEventClearBtn.UseVisualStyleBackColor = false;
            this.organizerEventClearBtn.Click += new System.EventHandler(this.organizerEventClearBtn_Click);
            // 
            // organizerEventEditBtn
            // 
            this.organizerEventEditBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.organizerEventEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerEventEditBtn.FlatAppearance.BorderSize = 0;
            this.organizerEventEditBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerEventEditBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventEditBtn.ForeColor = System.Drawing.Color.White;
            this.organizerEventEditBtn.Location = new System.Drawing.Point(291, 164);
            this.organizerEventEditBtn.Name = "organizerEventEditBtn";
            this.organizerEventEditBtn.Size = new System.Drawing.Size(102, 43);
            this.organizerEventEditBtn.TabIndex = 4;
            this.organizerEventEditBtn.Text = "Edit";
            this.organizerEventEditBtn.UseVisualStyleBackColor = false;
            this.organizerEventEditBtn.Click += new System.EventHandler(this.organizerEventEditBtn_Click);
            // 
            // organizerEventCreateBtn
            // 
            this.organizerEventCreateBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.organizerEventCreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerEventCreateBtn.FlatAppearance.BorderSize = 0;
            this.organizerEventCreateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerEventCreateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventCreateBtn.ForeColor = System.Drawing.Color.White;
            this.organizerEventCreateBtn.Location = new System.Drawing.Point(138, 164);
            this.organizerEventCreateBtn.Name = "organizerEventCreateBtn";
            this.organizerEventCreateBtn.Size = new System.Drawing.Size(102, 43);
            this.organizerEventCreateBtn.TabIndex = 4;
            this.organizerEventCreateBtn.Text = "Create";
            this.organizerEventCreateBtn.UseVisualStyleBackColor = false;
            this.organizerEventCreateBtn.Click += new System.EventHandler(this.organizerEventCreateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.organizerNameTxt);
            this.panel2.Controls.Add(this.organizerEventClearBtn);
            this.panel2.Controls.Add(this.organizerEventDeleteBtn);
            this.panel2.Controls.Add(this.organizerEventEditBtn);
            this.panel2.Controls.Add(this.organizerEventCreateBtn);
            this.panel2.Controls.Add(this.organizerEventOrganizerIDCombo);
            this.panel2.Controls.Add(this.organizerEventDate);
            this.panel2.Controls.Add(this.organizerMaxParticipantsTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.organizerEventVenueTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.organizerEventDescTxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.organizerEventNameTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 220);
            this.panel2.TabIndex = 2;
            // 
            // organizerNameTxt
            // 
            this.organizerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerNameTxt.Location = new System.Drawing.Point(687, 21);
            this.organizerNameTxt.Name = "organizerNameTxt";
            this.organizerNameTxt.ReadOnly = true;
            this.organizerNameTxt.Size = new System.Drawing.Size(146, 24);
            this.organizerNameTxt.TabIndex = 7;
            // 
            // organizerEventDeleteBtn
            // 
            this.organizerEventDeleteBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.organizerEventDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerEventDeleteBtn.FlatAppearance.BorderSize = 0;
            this.organizerEventDeleteBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerEventDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerEventDeleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.organizerEventDeleteBtn.Location = new System.Drawing.Point(446, 164);
            this.organizerEventDeleteBtn.Name = "organizerEventDeleteBtn";
            this.organizerEventDeleteBtn.Size = new System.Drawing.Size(102, 43);
            this.organizerEventDeleteBtn.TabIndex = 4;
            this.organizerEventDeleteBtn.Text = "Delete";
            this.organizerEventDeleteBtn.UseVisualStyleBackColor = false;
            this.organizerEventDeleteBtn.Click += new System.EventHandler(this.organizerEventDeleteBtn_Click);
            // 
            // organizerEventOrganizerIDCombo
            // 
            this.organizerEventOrganizerIDCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventOrganizerIDCombo.FormattingEnabled = true;
            this.organizerEventOrganizerIDCombo.Location = new System.Drawing.Point(437, 19);
            this.organizerEventOrganizerIDCombo.Name = "organizerEventOrganizerIDCombo";
            this.organizerEventOrganizerIDCombo.Size = new System.Drawing.Size(93, 26);
            this.organizerEventOrganizerIDCombo.TabIndex = 3;
            // 
            // organizerEventDate
            // 
            this.organizerEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventDate.Location = new System.Drawing.Point(675, 87);
            this.organizerEventDate.Name = "organizerEventDate";
            this.organizerEventDate.Size = new System.Drawing.Size(157, 24);
            this.organizerEventDate.TabIndex = 2;
            // 
            // organizerMaxParticipantsTxt
            // 
            this.organizerMaxParticipantsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerMaxParticipantsTxt.Location = new System.Drawing.Point(482, 89);
            this.organizerMaxParticipantsTxt.Name = "organizerMaxParticipantsTxt";
            this.organizerMaxParticipantsTxt.Size = new System.Drawing.Size(83, 24);
            this.organizerMaxParticipantsTxt.TabIndex = 1;
            this.organizerMaxParticipantsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // organizerEventVenueTxt
            // 
            this.organizerEventVenueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventVenueTxt.Location = new System.Drawing.Point(123, 120);
            this.organizerEventVenueTxt.Name = "organizerEventVenueTxt";
            this.organizerEventVenueTxt.Size = new System.Drawing.Size(159, 24);
            this.organizerEventVenueTxt.TabIndex = 1;
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
            // organizerEventDescTxt
            // 
            this.organizerEventDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventDescTxt.Location = new System.Drawing.Point(123, 70);
            this.organizerEventDescTxt.Name = "organizerEventDescTxt";
            this.organizerEventDescTxt.Size = new System.Drawing.Size(159, 24);
            this.organizerEventDescTxt.TabIndex = 1;
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
            // organizerEventNameTxt
            // 
            this.organizerEventNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerEventNameTxt.Location = new System.Drawing.Point(123, 21);
            this.organizerEventNameTxt.Name = "organizerEventNameTxt";
            this.organizerEventNameTxt.Size = new System.Drawing.Size(159, 24);
            this.organizerEventNameTxt.TabIndex = 1;
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
            // OrganizerManageEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrganizerManageEvents";
            this.Size = new System.Drawing.Size(857, 518);
            ((System.ComponentModel.ISupportInitialize)(this.organizerEventGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView organizerEventGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button organizerEventClearBtn;
        private System.Windows.Forms.Button organizerEventEditBtn;
        private System.Windows.Forms.Button organizerEventCreateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox organizerNameTxt;
        private System.Windows.Forms.Button organizerEventDeleteBtn;
        private System.Windows.Forms.ComboBox organizerEventOrganizerIDCombo;
        private System.Windows.Forms.DateTimePicker organizerEventDate;
        private System.Windows.Forms.TextBox organizerMaxParticipantsTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox organizerEventVenueTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox organizerEventDescTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox organizerEventNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}
