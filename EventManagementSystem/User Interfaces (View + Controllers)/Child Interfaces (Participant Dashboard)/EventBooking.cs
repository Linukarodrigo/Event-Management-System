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
    public partial class EventBooking : UserControl
    {
        public EventBooking()
        {
            InitializeComponent();

            BookingManager LoadEventIDs = new BookingManager();
            LoadEventIDs.LoadEventIDToComboBox(eventIDCombo);

            bookingGridView.ColumnCount = 5;
            bookingGridView.Columns[0].Name = "EventID";
            bookingGridView.Columns[1].Name = "EventName";
            bookingGridView.Columns[2].Name = "OrganizerName";
            bookingGridView.Columns[3].Name = "EventDate";
            bookingGridView.Columns[4].Name = "BookingDate";

            BookingManager fetchBookingsToGrid = new BookingManager();
            fetchBookingsToGrid.FetchBookingRecords(bookingGridView);


            // Auto-fill ParticipantID with the logged-in user's ID
            participantIDCombo.Text = Person.GetLoggedInUserId().ToString();

            // Auto-fill ParticipantName based on the ParticipantID
            BookingManager LoadParticipantsNames = new BookingManager();
            LoadParticipantsNames.LoadparticipantNameToTextBox(participantIDCombo, bookingParticipantNameTxt);
        
    }

        private void eventBookingBtn_Click(object sender, EventArgs e)
        {
            BookingManager createBooking = new BookingManager();

            int eventID;  
            string eventName = bookingEventNameTxt.Text;
            int participantID;
            string participantName = bookingParticipantNameTxt.Text;
            DateTime bookingdate = DateTime.Now;

            // Try parsing inputs
            bool isEventIDValid = int.TryParse(eventIDCombo.Text, out eventID);
            bool isParticipantIDValid = int.TryParse(participantIDCombo.Text, out participantID);

            // Validate inputs before proceeding
            if (!isEventIDValid || string.IsNullOrWhiteSpace(eventName) || !isParticipantIDValid || string.IsNullOrWhiteSpace(participantName))
            {
                MessageBox.Show("All fields must be completed before booking an event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the event is still active before allowing the booking
            if (!createBooking.IsEventStillActive(eventID))
            {
                MessageBox.Show("This event has already finished. You cannot book this event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            createBooking.AddBooking(eventID, participantID, bookingdate);


            ClearFormFields();

            RefreshBookingGrid();
        }

        private void eventBookingCancelBtn_Click(object sender, EventArgs e)
        {
            int eventID;
            string eventName = bookingEventNameTxt.Text;
            int participantID;
            string participantName = bookingParticipantNameTxt.Text;
            DateTime bookingdate = DateTime.Now;

            // Try parsing inputs
            bool isEventIDValid = int.TryParse(eventIDCombo.Text, out eventID);
            bool isParticipantIDValid = int.TryParse(participantIDCombo.Text, out participantID);

            // Check if any field is invalid
            if (!isEventIDValid || string.IsNullOrWhiteSpace(eventName) || !isParticipantIDValid || string.IsNullOrWhiteSpace(participantName))
            {
                MessageBox.Show("All fields must be filled correctly before canceling a booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure a row is selected
            if (bookingGridView.CurrentRow == null || bookingGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a valid booking from the table.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch the BookingDate from the selected row
            DataGridViewRow selectedRow = bookingGridView.CurrentRow;
            bookingdate = Convert.ToDateTime(selectedRow.Cells["BookingDate"].Value);

            // Proceed with booking cancellation
            BookingManager cancelBooking = new BookingManager();
            cancelBooking.bookingCancel(eventID, participantID, bookingdate);

            // Clear form fields and refresh the grid
            ClearFormFields();
            RefreshBookingGrid();
        }

        private void eventIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookingManager LoadEventNames = new BookingManager();
            LoadEventNames.LoadEventNameToTextBox(eventIDCombo, bookingEventNameTxt);
        }

        

        private void eventClearBtn_Click(object sender, EventArgs e)
        {
            ClearFormFields();

        }

        private void ClearFormFields()
        {
            eventIDCombo.Text = "";
            bookingEventNameTxt.Text = "";
        }

        private void RefreshBookingGrid()
        {
            // Clear the current rows in the DataGridView
            bookingGridView.Rows.Clear();

            // Fetch the updated booking records
            BookingManager fetchBookingsToGrid = new BookingManager();
            fetchBookingsToGrid.FetchBookingRecords(bookingGridView);
        }



        private void participantIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bookingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = bookingGridView.Rows[e.RowIndex];
                eventIDCombo.Text = row.Cells[0].Value.ToString();
                bookingEventNameTxt.Text = row.Cells[1].Value.ToString();
            }
        }

        private void bookingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
