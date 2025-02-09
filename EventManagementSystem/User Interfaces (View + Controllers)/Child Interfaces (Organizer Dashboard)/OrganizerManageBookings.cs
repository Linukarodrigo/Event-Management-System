﻿using System;
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
    public partial class OrganizerManageBookings : UserControl
    {
        public OrganizerManageBookings()
        {
            InitializeComponent();

            bookingsGridView.ColumnCount = 6;
            bookingsGridView.Columns[0].Name = "EventID";
            bookingsGridView.Columns[1].Name = "EventName";
            bookingsGridView.Columns[2].Name = "PaticipantID";
            bookingsGridView.Columns[3].Name = "PaticipantName";
            bookingsGridView.Columns[4].Name = "EventDate";
            bookingsGridView.Columns[5].Name = "BookingDate";

            BookingManager fetchOrganizerBooking = new BookingManager();
            fetchOrganizerBooking.FetchOrganizerBookings(bookingsGridView);
            
        }

        private void bookingsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = bookingsGridView.Rows[e.RowIndex];
                bookingeventIDTxt.Text = row.Cells[0].Value.ToString();
                bookingParticipantIDTxt.Text = row.Cells[2].Value.ToString();
                bookingDate.Text = row.Cells[5].Value.ToString();
            }
        }

        private void bookingCancelBtn_Click(object sender, EventArgs e)
        {
            int eventID;
            int participantID;
            DateTime bookingdate = DateTime.Now;

            // Try parsing inputs
            bool isEventIDValid = int.TryParse(bookingeventIDTxt.Text, out eventID);
            bool isParticipantIDValid = int.TryParse(bookingParticipantIDTxt.Text, out participantID);

            // Check if any field is invalid
            if (!isEventIDValid || !isParticipantIDValid)
            {
                MessageBox.Show("All fields must be filled correctly before canceling a booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure a row is selected
            if (bookingsGridView.CurrentRow == null || bookingsGridView.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a valid booking from the table.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch the BookingDate from the selected row
            DataGridViewRow selectedRow = bookingsGridView.CurrentRow;
            bookingdate = Convert.ToDateTime(selectedRow.Cells["BookingDate"].Value);

            // Proceed with booking cancellation
            BookingManager cancelBooking = new BookingManager();
            cancelBooking.bookingCancel(eventID, participantID, bookingdate);

            // Clear form fields and refresh the grid
            ClearFormFields();
            RefreshBookingGrid();
        }

        private void ClearFormFields()
        {
            bookingeventIDTxt.Text = "";
            bookingParticipantIDTxt.Text = "";
        }

        private void RefreshBookingGrid()
        {
            // Clear the current rows in the DataGridView
            bookingsGridView.Rows.Clear();

            // Fetch the updated booking records
            BookingManager fetchOrganizerBooking = new BookingManager();
            fetchOrganizerBooking.FetchOrganizerBookings(bookingsGridView);
        }
    }
}
