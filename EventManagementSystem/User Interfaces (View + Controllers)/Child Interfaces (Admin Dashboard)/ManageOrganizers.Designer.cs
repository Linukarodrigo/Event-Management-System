namespace EventManagementSystem
{
    partial class ManageOrganizers
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
            this.organizerUsernameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.organizerRemoveBtn = new System.Windows.Forms.Button();
            this.organizerPhoneNoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.organizerNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.organizerIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.organizerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.organizerUsernameTxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.organizerRemoveBtn);
            this.panel1.Controls.Add(this.organizerPhoneNoTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.organizerNameTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.organizerIDTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 534);
            this.panel1.TabIndex = 0;
            // 
            // organizerUsernameTxt
            // 
            this.organizerUsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerUsernameTxt.Location = new System.Drawing.Point(23, 208);
            this.organizerUsernameTxt.Multiline = true;
            this.organizerUsernameTxt.Name = "organizerUsernameTxt";
            this.organizerUsernameTxt.ReadOnly = true;
            this.organizerUsernameTxt.Size = new System.Drawing.Size(239, 25);
            this.organizerUsernameTxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "retrieve organizer information.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Please click a row in the table to";
            // 
            // organizerRemoveBtn
            // 
            this.organizerRemoveBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.organizerRemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizerRemoveBtn.FlatAppearance.BorderSize = 0;
            this.organizerRemoveBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerRemoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerRemoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(138)))));
            this.organizerRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizerRemoveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerRemoveBtn.ForeColor = System.Drawing.Color.White;
            this.organizerRemoveBtn.Location = new System.Drawing.Point(86, 398);
            this.organizerRemoveBtn.Name = "organizerRemoveBtn";
            this.organizerRemoveBtn.Size = new System.Drawing.Size(102, 43);
            this.organizerRemoveBtn.TabIndex = 12;
            this.organizerRemoveBtn.Text = "Remove";
            this.organizerRemoveBtn.UseVisualStyleBackColor = false;
            this.organizerRemoveBtn.Click += new System.EventHandler(this.organizerRemoveBtn_Click);
            // 
            // organizerPhoneNoTxt
            // 
            this.organizerPhoneNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerPhoneNoTxt.Location = new System.Drawing.Point(25, 337);
            this.organizerPhoneNoTxt.Multiline = true;
            this.organizerPhoneNoTxt.Name = "organizerPhoneNoTxt";
            this.organizerPhoneNoTxt.ReadOnly = true;
            this.organizerPhoneNoTxt.Size = new System.Drawing.Size(239, 25);
            this.organizerPhoneNoTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone No:";
            // 
            // organizerNameTxt
            // 
            this.organizerNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerNameTxt.Location = new System.Drawing.Point(25, 277);
            this.organizerNameTxt.Multiline = true;
            this.organizerNameTxt.Name = "organizerNameTxt";
            this.organizerNameTxt.ReadOnly = true;
            this.organizerNameTxt.Size = new System.Drawing.Size(239, 25);
            this.organizerNameTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Organizer\'s Name:";
            // 
            // organizerIDTxt
            // 
            this.organizerIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerIDTxt.Location = new System.Drawing.Point(25, 139);
            this.organizerIDTxt.Multiline = true;
            this.organizerIDTxt.Name = "organizerIDTxt";
            this.organizerIDTxt.ReadOnly = true;
            this.organizerIDTxt.Size = new System.Drawing.Size(93, 25);
            this.organizerIDTxt.TabIndex = 10;
            this.organizerIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Organizer ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.organizerGridView);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(303, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 534);
            this.panel2.TabIndex = 1;
            // 
            // organizerGridView
            // 
            this.organizerGridView.AllowUserToAddRows = false;
            this.organizerGridView.AllowUserToDeleteRows = false;
            this.organizerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.organizerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.organizerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizerGridView.EnableHeadersVisualStyles = false;
            this.organizerGridView.Location = new System.Drawing.Point(13, 54);
            this.organizerGridView.Name = "organizerGridView";
            this.organizerGridView.ReadOnly = true;
            this.organizerGridView.RowHeadersVisible = false;
            this.organizerGridView.RowHeadersWidth = 51;
            this.organizerGridView.RowTemplate.Height = 24;
            this.organizerGridView.Size = new System.Drawing.Size(534, 464);
            this.organizerGridView.TabIndex = 2;
            this.organizerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.organizerGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organizers";
            // 
            // ManageOrganizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageOrganizers";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView organizerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button organizerRemoveBtn;
        private System.Windows.Forms.TextBox organizerPhoneNoTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox organizerNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox organizerIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox organizerUsernameTxt;
        private System.Windows.Forms.Label label7;
    }
}
