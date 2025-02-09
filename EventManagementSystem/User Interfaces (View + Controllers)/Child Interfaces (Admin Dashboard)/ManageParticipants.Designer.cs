namespace EventManagementSystem
{
    partial class ManageParticipants
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
            this.ParticipantUsernameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ParticipantIDTxt = new System.Windows.Forms.TextBox();
            this.participantRemoveBtn = new System.Windows.Forms.Button();
            this.participantPhoneNoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ParticipantNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.participantGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ParticipantUsernameTxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ParticipantIDTxt);
            this.panel1.Controls.Add(this.participantRemoveBtn);
            this.panel1.Controls.Add(this.participantPhoneNoTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ParticipantNameTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 534);
            this.panel1.TabIndex = 0;
            // 
            // ParticipantUsernameTxt
            // 
            this.ParticipantUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantUsernameTxt.Location = new System.Drawing.Point(23, 208);
            this.ParticipantUsernameTxt.Multiline = true;
            this.ParticipantUsernameTxt.Name = "ParticipantUsernameTxt";
            this.ParticipantUsernameTxt.ReadOnly = true;
            this.ParticipantUsernameTxt.Size = new System.Drawing.Size(239, 25);
            this.ParticipantUsernameTxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "retrieve participant information.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "*Please click a row in the table to";
            // 
            // ParticipantIDTxt
            // 
            this.ParticipantIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantIDTxt.Location = new System.Drawing.Point(25, 139);
            this.ParticipantIDTxt.Name = "ParticipantIDTxt";
            this.ParticipantIDTxt.ReadOnly = true;
            this.ParticipantIDTxt.Size = new System.Drawing.Size(93, 24);
            this.ParticipantIDTxt.TabIndex = 2;
            this.ParticipantIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // participantRemoveBtn
            // 
            this.participantRemoveBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.participantRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.participantRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.participantRemoveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.participantRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.participantRemoveBtn.Location = new System.Drawing.Point(86, 398);
            this.participantRemoveBtn.Name = "participantRemoveBtn";
            this.participantRemoveBtn.Size = new System.Drawing.Size(102, 43);
            this.participantRemoveBtn.TabIndex = 2;
            this.participantRemoveBtn.Text = "Remove";
            this.participantRemoveBtn.UseVisualStyleBackColor = false;
            this.participantRemoveBtn.Click += new System.EventHandler(this.participantRemoveBtn_Click);
            // 
            // participantPhoneNoTxt
            // 
            this.participantPhoneNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantPhoneNoTxt.Location = new System.Drawing.Point(25, 337);
            this.participantPhoneNoTxt.Multiline = true;
            this.participantPhoneNoTxt.Name = "participantPhoneNoTxt";
            this.participantPhoneNoTxt.ReadOnly = true;
            this.participantPhoneNoTxt.Size = new System.Drawing.Size(239, 25);
            this.participantPhoneNoTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone No:";
            // 
            // ParticipantNameTxt
            // 
            this.ParticipantNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParticipantNameTxt.Location = new System.Drawing.Point(25, 277);
            this.ParticipantNameTxt.Multiline = true;
            this.ParticipantNameTxt.Name = "ParticipantNameTxt";
            this.ParticipantNameTxt.ReadOnly = true;
            this.ParticipantNameTxt.Size = new System.Drawing.Size(239, 25);
            this.ParticipantNameTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participant\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Participant ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.participantGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(303, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 534);
            this.panel2.TabIndex = 1;
            // 
            // participantGridView
            // 
            this.participantGridView.AllowUserToAddRows = false;
            this.participantGridView.AllowUserToDeleteRows = false;
            this.participantGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.participantGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.participantGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantGridView.EnableHeadersVisualStyles = false;
            this.participantGridView.Location = new System.Drawing.Point(13, 54);
            this.participantGridView.Name = "participantGridView";
            this.participantGridView.ReadOnly = true;
            this.participantGridView.RowHeadersVisible = false;
            this.participantGridView.RowHeadersWidth = 51;
            this.participantGridView.RowTemplate.Height = 24;
            this.participantGridView.Size = new System.Drawing.Size(534, 464);
            this.participantGridView.TabIndex = 1;
            this.participantGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.participantGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Participants";
            // 
            // ManageParticipants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageParticipants";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView participantGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox participantPhoneNoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ParticipantNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button participantRemoveBtn;
        private System.Windows.Forms.TextBox ParticipantIDTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ParticipantUsernameTxt;
        private System.Windows.Forms.Label label7;
    }
}
