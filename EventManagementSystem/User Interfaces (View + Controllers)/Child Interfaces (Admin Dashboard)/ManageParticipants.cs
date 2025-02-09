using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class ManageParticipants : UserControl
    {
        public Person Person1;
        public ManageParticipants(Person person1)
        {
            InitializeComponent();
            this.Person1 = person1;
        }

        
        public ManageParticipants()
        {
            InitializeComponent();

            participantGridView.ColumnCount = 4;
            participantGridView.Columns[0].Name = "ParticipantID";
            participantGridView.Columns[1].Name = "Username";
            participantGridView.Columns[2].Name = "Name";
            participantGridView.Columns[3].Name = "PhoneNo";

            PersonManager fetchParticipantToGrid = new PersonManager();
            fetchParticipantToGrid.fetchParticipantRecords(participantGridView);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void participantRemoveBtn_Click(object sender, EventArgs e)
        {
            // Check if the text fields are empty (meaning no row was selected)
            if (string.IsNullOrEmpty(ParticipantIDTxt.Text) || string.IsNullOrEmpty(ParticipantUsernameTxt.Text) || string.IsNullOrEmpty(ParticipantNameTxt.Text) || string.IsNullOrEmpty(participantPhoneNoTxt.Text))
            {
                
                MessageBox.Show("Please click a row in the table to select a participant.", "No Participant Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            PersonManager participantRemove = new PersonManager();

            int ParticipantID = int.Parse(ParticipantIDTxt.Text);
            string ParticipantName = ParticipantNameTxt.Text;
            

            participantRemove.RemoveParticipants(ParticipantID, ParticipantName);

            ClearFormFields();

            RefreshParticipantGrid();
        }

        private void ClearFormFields()
        {
            ParticipantIDTxt.Text = "";
            ParticipantUsernameTxt.Text = "";
            ParticipantNameTxt.Text = "";
            participantPhoneNoTxt.Text = "";        
        }

        private void RefreshParticipantGrid()
        {
            // Clear the current rows in the DataGridView
            participantGridView.Rows.Clear();

            // Fetch the updated event records
            PersonManager fetchParticipantsToGrid = new PersonManager();
            fetchParticipantsToGrid.fetchParticipantRecords(participantGridView);
        }

        private void participantIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void participantGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = participantGridView.Rows[e.RowIndex];
                ParticipantIDTxt.Text = row.Cells[0].Value.ToString();
                ParticipantUsernameTxt.Text = row.Cells[1].Value.ToString();
                ParticipantNameTxt.Text = row.Cells[2].Value.ToString();
                participantPhoneNoTxt.Text = row.Cells[3].Value.ToString();

            }
            
        }
    }
}
