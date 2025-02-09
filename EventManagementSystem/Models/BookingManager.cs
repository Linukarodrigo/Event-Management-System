using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    internal class BookingManager
    {
        // Method to fetch all booking records with related event and participant details
        public List<Booking> GetBookingList()
        {
            List<Booking> currentBookings = new List<Booking>();

            // To fetch records from the DB and show in the table
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT booking.EventID, event.EventName, booking.ParticipantID, participant.Name AS ParticipantName, organizer.Name AS OrganizerName, event.EventDate, booking.BookingDate FROM booking JOIN event ON booking.EventID = event.EventID JOIN person AS participant ON booking.ParticipantID = participant.PersonID JOIN person AS organizer ON event.OrganizerID = organizer.PersonID";

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Iterate through the response from the DB and construct booking objects
                while (reader.Read())
                {
                    int eventID = int.Parse(reader["EventID"].ToString());
                    string eventName = reader["EventName"].ToString();
                    int participantID = int.Parse(reader["ParticipantID"].ToString());
                    string participantName = reader["ParticipantName"].ToString();
                    string organizerName = reader["OrganizerName"].ToString();
                    DateTime eventDate = Convert.ToDateTime(reader["EventDate"].ToString());
                    DateTime bookingDate = Convert.ToDateTime(reader["BookingDate"].ToString());

                    // Construct the Booking object
                    Booking booking = new Booking(eventID, eventName, organizerName, participantID, participantName, eventDate, bookingDate);
                    currentBookings.Add(booking);
                }
                reader.Close();
                return currentBookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching bookings: " + ex.Message);
                return new List<Booking>();
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to fetch and display the logged-in participant's bookings in the DataGridView (EventBooking UI)
        private List<Booking> currentBookingsParticipants;
        public void FetchBookingRecords(DataGridView bookingGridView)
        {
            // Get the logged-in participant's ID
            int loggedInParticipantID = Person.GetLoggedInUserId();

            // Fetch all booking records
            currentBookingsParticipants = GetBookingList();

            // Clear the DataGridView before adding new rows
            bookingGridView.Rows.Clear();

            // Add bookings that belong to the logged-in participant
            foreach (Booking booking in currentBookingsParticipants)
            {
                string formattedEventDate = booking.GetEventDate().ToString("yyyy-MM-dd");
                if (booking.GetParticipantID() == loggedInParticipantID)
                {
                    bookingGridView.Rows.Add(booking.GetEventID(), booking.GetEventName(), booking.GetOrganizerName(), formattedEventDate, booking.GetBookingDate());
                }
            }
        }

        //Method to load event IDs into the ComboBox (EventBooking UI)
        public void LoadEventIDToComboBox(System.Windows.Forms.ComboBox eventIDCombo)
        {
            // Connect to the DB
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT EventID, EventName FROM event";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable eventTable = new DataTable();
                adapter.Fill(eventTable);   // Fill the DataTable with the query result

                // Bind the EventID to the ComboBox
                eventIDCombo.DataSource = eventTable;
                eventIDCombo.DisplayMember = "EventID";  // Display the EventID in the ComboBox
                eventIDCombo.ValueMember = "EventID";    // Use EventID as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to load the event name based on selected EventID into a TextBox (EventBooking UI)
        public void LoadEventNameToTextBox(System.Windows.Forms.ComboBox eventIDCombo, System.Windows.Forms.TextBox bookingEventNameTxt)
        {
            // Check if the selected value is not null
            if (eventIDCombo.SelectedValue != null)
            {
                // Try parsing the selected ID as an integer
                if (int.TryParse(eventIDCombo.SelectedValue.ToString(), out int selectedID))
                {
                    // Connect to the DB
                    DBConnection dbConnection = new DBConnection();
                    string query = "SELECT EventName FROM event WHERE EventID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                    cmd.Parameters.AddWithValue("@id", selectedID);

                    try
                    {
                        dbConnection.OpenConnection();
                        object result = cmd.ExecuteScalar();  // Get the event name as a scalar result

                        // If a result is found, set the TextBox value
                        if (result != null)
                        {
                            bookingEventNameTxt.Text = result.ToString();  // Automatically fill the name TextBox
                        }
                        else
                        {
                            MessageBox.Show("No event found with the selected ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading event name: " + ex.Message);
                    }
                    finally
                    {
                        dbConnection.CloseConnection();
                    }
                }
            }
            else
            {
                MessageBox.Show("No Event ID selected.");
            }
        }

        // Method to check if the event is full based on the maximum participant limit
        public bool IsEventFull(int eventID)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT COUNT(*) FROM booking WHERE EventID = @eventID";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            cmd.Parameters.AddWithValue("@eventID", eventID);

            try
            {
                dbConnection.OpenConnection();
                int currentParticipants = Convert.ToInt32(cmd.ExecuteScalar());
 
                string maxQuery = "SELECT MaxParticipants FROM event WHERE EventID = @eventID";
                MySqlCommand maxCmd = new MySqlCommand(maxQuery, dbConnection.GetConnection());
                maxCmd.Parameters.AddWithValue("@eventID", eventID);

                int maxParticipants = Convert.ToInt32(maxCmd.ExecuteScalar());

                return currentParticipants >= maxParticipants; // Returns true if the event is full
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking event capacity: " + ex.Message);
                return false; // Default to false if there's an error
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        //Method to add a new booking into the database (EventBooking UI)
        public void AddBooking(int eventID, int participantID, DateTime bookingdate)
        {
            // Check if the event is full before adding the booking
            if (IsEventFull(eventID))
            {
                MessageBox.Show("This event is full. You cannot book it.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the event is full
            }

            DBConnection dbConnection = new DBConnection();
            string query = "INSERT INTO booking (EventID, ParticipantID, BookingDate) VALUES(@eventID, @participantID, @bookingdate)";
            MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
            command.Parameters.AddWithValue("@eventID", eventID);
            command.Parameters.AddWithValue("@participantID", participantID);
            command.Parameters.AddWithValue("@bookingdate", bookingdate);

            try
            {
                dbConnection.OpenConnection();
                command.Prepare();
                command.ExecuteNonQuery();
                MessageBox.Show("Booking created successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                // Check for duplicate entry error
                if (ex.Number == 1062) // MySQL error code for duplicate entry
                {
                    MessageBox.Show("You have already booked this event.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error creating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to check if the event is still active (not past)
        public bool IsEventStillActive(int eventID)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT EventDate FROM event WHERE EventID = @eventID";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            cmd.Parameters.AddWithValue("@eventID", eventID);

            try
            {
                dbConnection.OpenConnection();
                DateTime eventDate = Convert.ToDateTime(cmd.ExecuteScalar());

                // If today's date is greater than the event date, the event is over
                return DateTime.Today <= eventDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking event status: " + ex.Message);
                return false;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to load the participant's name into the TextBox based on selected ParticipantID (EventBooking UI)
        public void LoadparticipantNameToTextBox(System.Windows.Forms.ComboBox participantIDCombo, System.Windows.Forms.TextBox bookingParticipantNameTxt)
        {
            
            if (!string.IsNullOrWhiteSpace(participantIDCombo.Text) && int.TryParse(participantIDCombo.Text, out int selectedID))
            {
                // Connect to the DB
                DBConnection dbConnection = new DBConnection();
                string query = "SELECT Name FROM person WHERE PersonID = @id AND LOWER(Role) = 'participant'";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@id", selectedID);

                try
                {
                    dbConnection.OpenConnection();
                    object result = cmd.ExecuteScalar();  // Get the participant's name as a scalar result

                    // If a result is found, set the TextBox value
                    if (result != null)
                    {
                        bookingParticipantNameTxt.Text = result.ToString();  // Automatically fill the name TextBox
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading participant name: " + ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }

        // Method to cancel a booking based on EventID, ParticipantID and bookingDate (AdminManageBookings UI, OrganizerManageBookings UI, EventBooking UI)
        public void bookingCancel(int eventID, int participantID, DateTime bookingdate)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "DELETE FROM booking WHERE EventID= @eventid AND ParticipantID = @participantid AND BookingDate = @bookdate";
            MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
            command.Parameters.AddWithValue("@eventid", eventID);
            command.Parameters.AddWithValue("@participantid", participantID);
            command.Parameters.AddWithValue("@bookdate", bookingdate);

            try
            {
                dbConnection.OpenConnection();
                command.Prepare();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Booking has been successfully cancelled.");
                }
                else
                {
                    MessageBox.Show("No matching booking found to cancel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling booking: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        

        // Method to fetch booking data into the admin booking grid (AdminManageBookings UI)
        private List<Booking> currentBookingsAdmin;
        public void FetchAdminBookingRecords(DataGridView bookingGridView)
        {
            // Fetch the booking list
            currentBookingsAdmin = GetBookingList();

            // Clear any existing rows in the grid before adding new data
            bookingGridView.Rows.Clear();

            foreach (Booking booking in currentBookingsAdmin)
            {
                string formattedEventDate = booking.GetEventDate().ToString("yyyy-MM-dd");
                bookingGridView.Rows.Add(booking.GetEventID(), booking.GetEventName(), booking.GetOrganizerName(), booking.GetParticipantID(), booking.GetParticipantName(), formattedEventDate, booking.GetBookingDate());
            }
        }

        // Method to fetch bookings for a specific organizer's events
        public List<Booking> GetOrganizerBookingsList(int organizerID)
        {
            List<Booking> organizerBookings = new List<Booking>();

            // To fetch records from the DB and show in the table
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT booking.EventID, event.EventName, booking.ParticipantID, person.Name as ParticipantName, event.EventDate, booking.BookingDate FROM booking JOIN event ON booking.EventID = event.EventID JOIN person ON booking.ParticipantID = person.PersonID WHERE event.OrganizerID = @organizerID"; // Query to join bookings with events and participants based on the organizer ID

            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
            cmd.Parameters.AddWithValue("@organizerID", organizerID);

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Iterate through the response from the DB
                while (reader.Read())
                {
                    int eventID = int.Parse(reader["EventID"].ToString());
                    string eventName = reader["EventName"].ToString();
                    int participantID = int.Parse(reader["ParticipantID"].ToString());
                    string participantName = reader["ParticipantName"].ToString();
                    DateTime eventDate = Convert.ToDateTime(reader["EventDate"].ToString());
                    DateTime bookingDate = Convert.ToDateTime(reader["BookingDate"].ToString());

                    // Construct the Booking object
                    Booking booking = new Booking(eventID, eventName, participantID, participantName, eventDate, bookingDate);
                    organizerBookings.Add(booking);
                }
                reader.Close();
                return organizerBookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return new List<Booking>();
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to fetch booking data into the organizer booking grid (OrganizerManageBookings UI)
        private List<Booking> BookingsOfOrganizer;
        public void FetchOrganizerBookings(DataGridView bookingsGridView)
        {
            // Get the logged-in organizer's ID
            int loggedInOrganizerID = Person.GetLoggedInUserId();

            // Fetch the booking list
            BookingsOfOrganizer = GetOrganizerBookingsList(loggedInOrganizerID);

            // Clear the DataGridView before loading new data
            bookingsGridView.Rows.Clear();

            // Add only the bookings for the logged-in participant to the grid
            foreach (Booking booking in BookingsOfOrganizer)
            {
                string formattedEventDate = booking.GetEventDate().ToString("yyyy-MM-dd");
                bookingsGridView.Rows.Add(booking.GetEventID(), booking.GetEventName(), booking.GetParticipantID(), booking.GetParticipantName(), formattedEventDate, booking.GetBookingDate());
            }
        }
    }
}
