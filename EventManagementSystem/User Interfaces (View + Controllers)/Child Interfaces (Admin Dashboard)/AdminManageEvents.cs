using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class AdminManageEvents : UserControl
    {
        public AdminManageEvents()
        {
            InitializeComponent();

            EventManager LoadOrganizerIDs = new EventManager();
            LoadOrganizerIDs.LoadOrganizersIDToComboBox(eventOrganizerIDCombo);

            eventGridView.ColumnCount = 8;
            eventGridView.Columns[0].Name = "EventID";
            eventGridView.Columns[1].Name = "EventName";
            eventGridView.Columns[2].Name = "Description";
            eventGridView.Columns[3].Name = "Venue";
            eventGridView.Columns[4].Name = "EventDate";
            eventGridView.Columns[5].Name = "OrganizerID";
            eventGridView.Columns[6].Name = "OrganizerName";
            eventGridView.Columns[7].Name = "MaxParticipants";

            EventManager fetchEventsToGrid = new EventManager(); 
            fetchEventsToGrid.fetchEventRecords(eventGridView);

        }

        private void eventOrganizerIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventManager LoadOrganizerNames = new EventManager();
            LoadOrganizerNames.LoadOrganizerNameToTextBox(eventOrganizerIDCombo, organizerNameTxt);


        }

        private void maxParticipantsTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void eventOrganizerNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eventCreateBtn_Click(object sender, EventArgs e)
        {
            EventManager createEvent = new EventManager();

            string eventName = eventNameTxt.Text;
            string description = eventDescTxt.Text;
            string venue = eventVenueTxt.Text;
            DateTime eventdate;
            int organizerID;
            string organizerName = organizerNameTxt.Text;
            string maxParticipants = maxParticipantsTxt.Text;
            
            // Try parsing inputs
            bool isOrganizerIDValid = int.TryParse(eventOrganizerIDCombo.SelectedValue?.ToString(), out organizerID);
            bool isDateValid = DateTime.TryParse(eventDate.Text, out eventdate);

            if (!isDateValid)
            {
                MessageBox.Show("Please enter a valid event date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the event date is today or in the past
            if (eventdate <= DateTime.Today)
            {
                MessageBox.Show("Event date must be in the future. Please select a date after today.", "Invalid Event Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call AddEvents with inputs
            createEvent.AddEvents(eventName, description, venue, eventdate, organizerID, maxParticipants);

            ClearFormFields();

            RefreshEventGrid();

        }

        private void eventGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void eventGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = eventGridView.Rows[e.RowIndex];
                eventNameTxt.Text = row.Cells[1].Value.ToString();
                eventDescTxt.Text = row.Cells[2].Value.ToString();
                eventVenueTxt.Text = row.Cells[3].Value.ToString();
                eventDate.Text = row.Cells[4].Value.ToString();
                eventOrganizerIDCombo.Text = row.Cells[5].Value.ToString();
                organizerNameTxt.Text = row.Cells[6].Value.ToString();
                maxParticipantsTxt.Text = row.Cells[7].Value.ToString();

            }

        }

        private void eventClearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void eventDeleteBtn_Click(object sender, EventArgs e)
        {
            string eventName = eventNameTxt.Text;
            string description = eventDescTxt.Text;
            string venue = eventVenueTxt.Text;
            DateTime eventdate;
            int organizerID;
            string organizerName = organizerNameTxt.Text;
            int maxParticipants;

            // Try parsing inputs
            bool isDateValid = DateTime.TryParse(eventDate.Text, out eventdate);
            bool isOrganizerIDValid = int.TryParse(eventOrganizerIDCombo.SelectedValue?.ToString(), out organizerID);
            bool isMaxParticipantsValid = int.TryParse(maxParticipantsTxt.Text, out maxParticipants);

            // Check if the text fields are empty (meaning no row was selected)
            if (string.IsNullOrWhiteSpace(eventName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(venue) ||
                organizerID <= 0 ||
                string.IsNullOrWhiteSpace(organizerName) ||
                maxParticipants <= 0)
            {

                MessageBox.Show("Please click a row in the table to select an event.", "No event Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EventManager eventRemove = new EventManager();
            eventRemove.RemoveEvents(eventName, venue, eventdate, organizerID);

            ClearFormFields();

            RefreshEventGrid();
        }

        private void ClearFormFields()
        {
            eventNameTxt.Text = "";
            eventDescTxt.Text = "";
            eventVenueTxt.Text = "";
            eventOrganizerIDCombo.Text = "";
            organizerNameTxt.Text = "";
            maxParticipantsTxt.Text = "";
        }

        private void eventEditBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EventManager class
            EventManager eventEdit = new EventManager();

            // Gather the data from the text fields
            string eventName = eventNameTxt.Text;
            string description = eventDescTxt.Text;
            string venue = eventVenueTxt.Text;
            DateTime eventdate;
            int organizerID;
            string organizerName = organizerNameTxt.Text;
            string maxParticipants = maxParticipantsTxt.Text;

            // Try parsing the necessary values
            bool isDateValid = DateTime.TryParse(eventDate.Text, out eventdate);
            bool isOrganizerIDValid = int.TryParse(eventOrganizerIDCombo.SelectedValue?.ToString(), out organizerID);

            if (!isDateValid)
            {
                MessageBox.Show("Please enter a valid event date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the event date is today or in the past
            if (eventdate <= DateTime.Today)
            {
                MessageBox.Show("Event date must be in the future. Please select a date after today.", "Invalid Event Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string eventID = eventGridView.CurrentRow.Cells[0].Value.ToString(); // Get EventID from selected row
            eventEdit.UpdateEvent(eventID,eventName, description, venue, eventdate, organizerID, maxParticipants);
         
            ClearFormFields();

            RefreshEventGrid();

        }

        //Method to refresh the Event data grid after done certain actions (Create, Edit, Delete events)
        private void RefreshEventGrid()
        {
            // Clear the current rows in the DataGridView
            eventGridView.Rows.Clear();

            // Fetch the updated event records
            EventManager fetchEventsToGrid = new EventManager();
            fetchEventsToGrid.fetchEventRecords(eventGridView);
        }

        private void organizerNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
