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
    public partial class OrganizerManageEvents : UserControl
    {
        public OrganizerManageEvents()
        {
            InitializeComponent();

            organizerEventGridView.ColumnCount = 6;
            organizerEventGridView.Columns[0].Name = "EventID";
            organizerEventGridView.Columns[1].Name = "EventName";
            organizerEventGridView.Columns[2].Name = "Description";
            organizerEventGridView.Columns[3].Name = "Venue";
            organizerEventGridView.Columns[4].Name = "EventDate";  
            organizerEventGridView.Columns[5].Name = "MaxParticipants";

            EventManager fetchEventsToGrid = new EventManager();
            fetchEventsToGrid.fetchOrganizerEventRecords(organizerEventGridView);

            // Auto-fill OrganizerID with the logged-in user's ID
            organizerEventOrganizerIDCombo.Text = Person.GetLoggedInUserId().ToString();

            // Auto-fill OrganizerName based on the OrganizerID
            EventManager LoadOrganizersNames = new EventManager();
            LoadOrganizersNames.LoadOrganizerNameToTextBox(organizerEventOrganizerIDCombo, organizerNameTxt);
        }

        private void organizerEventGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = organizerEventGridView.Rows[e.RowIndex];
            organizerEventNameTxt.Text = row.Cells[1].Value.ToString();
            organizerEventDescTxt.Text = row.Cells[2].Value.ToString();
            organizerEventVenueTxt.Text = row.Cells[3].Value.ToString();
            organizerMaxParticipantsTxt.Text = row.Cells[5].Value.ToString();
            
        }

        

        private void organizerEventClearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void ClearFormFields()
        {
            organizerEventNameTxt.Text = "";
            organizerEventDescTxt.Text = "";
            organizerEventVenueTxt.Text = "";
            organizerMaxParticipantsTxt.Text = "";
        }

        private void organizerEventCreateBtn_Click(object sender, EventArgs e)
        {
            EventManager createEvent = new EventManager();

            string eventName = organizerEventNameTxt.Text;
            string description = organizerEventDescTxt.Text;
            string venue = organizerEventVenueTxt.Text;
            DateTime eventdate;
            int organizerID;
            string maxParticipants = organizerMaxParticipantsTxt.Text;

            // Try parsing inputs
            bool isOrganizerIDValid = int.TryParse(organizerEventOrganizerIDCombo.Text, out organizerID);
            bool isDateValid = DateTime.TryParse(organizerEventDate.Text, out eventdate);

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

        //Method to refresh the Event data grid after done certain actions (Create, Edit, Delete events)
        private void RefreshEventGrid()
        {
            // Clear the current rows in the DataGridView
            organizerEventGridView.Rows.Clear();

            // Fetch the updated event records
            EventManager fetchEventsToGrid = new EventManager();
            fetchEventsToGrid.fetchOrganizerEventRecords(organizerEventGridView);
        }

        private void organizerEventEditBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of the EventManager class
            EventManager eventEdit = new EventManager();

            // Gather the data from the text fields
            string eventName = organizerEventNameTxt.Text;
            string description = organizerEventDescTxt.Text;
            string venue = organizerEventVenueTxt.Text;
            DateTime eventdate;
            int organizerID;
            string maxParticipants = organizerMaxParticipantsTxt.Text;

            // Try parsing the necessary values
            bool isDateValid = DateTime.TryParse(this.organizerEventDate.Text, out eventdate);
            bool isOrganizerIDValid = int.TryParse(organizerEventOrganizerIDCombo.Text, out organizerID);

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
            

            string eventID = organizerEventGridView.CurrentRow.Cells[0].Value.ToString(); // Get EventID from selected row
            eventEdit.UpdateEvent(eventID, eventName, description, venue, eventdate, organizerID, maxParticipants);

            ClearFormFields();

            RefreshEventGrid();

        }

        private void organizerEventDeleteBtn_Click(object sender, EventArgs e)
        {
            string eventName = organizerEventNameTxt.Text;
            string description = organizerEventDescTxt.Text;
            string venue = organizerEventVenueTxt.Text;
            DateTime eventdate = DateTime.Today;
            int organizerID;
            int maxParticipants;

            // Try parsing inputs
            bool isDateValid = DateTime.TryParse(this.organizerEventDate.Text, out eventdate);
            bool isOrganizerIDValid = int.TryParse(organizerEventOrganizerIDCombo.Text, out organizerID);
            bool isMaxParticipantsValid = int.TryParse(organizerMaxParticipantsTxt.Text, out maxParticipants);

            // Check if the text fields are empty (meaning no row was selected)
            if (string.IsNullOrWhiteSpace(eventName) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(venue) ||
                organizerID <= 0 ||
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
    }
}
