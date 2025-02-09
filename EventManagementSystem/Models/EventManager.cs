using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    internal class EventManager
    {
        // Method to fetch events and return them as a list
        public List<Event> GetEventList()
        {
            List<Event> currentEvents = new List<Event>();

            //To fetch records from the DB and show in the table
            DBConnection dbConnection = new DBConnection();
            string query = @"SELECT event.EventID, event.EventName, event.Description, event.Venue, event.EventDate, event.OrganizerID, person.Name AS OrganizerName, event.MaxParticipants FROM event JOIN person ON event.OrganizerID = person.PersonID"; // Join event with person to get organizer's name
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader(); // Execute query and get data

                // Iterate through the records returned from the database
                while (reader.Read())
                {
                    // Read data from the reader
                    int eventID = int.Parse(reader["EventID"].ToString());
                    string eventName = reader["EventName"].ToString();
                    string description = reader["Description"].ToString();
                    string venue = reader["Venue"].ToString();
                    DateTime eventDate = Convert.ToDateTime(reader["EventDate"]);
                    int organizerID = int.Parse(reader["OrganizerID"].ToString());
                    string organizerName = reader["OrganizerName"].ToString();
                    int maxParticipants = int.Parse(reader["MaxParticipants"].ToString());


                    //Construct the Event object
                    Event events = new Event(eventID, eventName, description, venue, organizerID, organizerName, maxParticipants, eventDate);
                    currentEvents.Add(events);
                }
                reader.Close();
                return currentEvents;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return new List<Event>(); // Return an empty list if an error occurs
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to fetch event data and populate the event grid view (AdminManageEvents UI, AvailableEvents UI)
        private List<Event> currentEvents;
        public void fetchEventRecords(DataGridView eventGridView) 
        {        
            currentEvents = GetEventList();

            // Loop through each event and add it to the DataGridView 
            foreach (Event allEvents in currentEvents)
            {
                string formattedEventDate = allEvents.GetEventDate().ToString("yyyy-MM-dd");

                eventGridView.Rows.Add(allEvents.GetEventID(), allEvents.GetEventName(), allEvents.GetEventDescription(), allEvents.GetEventVenue(), formattedEventDate, allEvents.GetOrganizerID(), allEvents.GetOrganizerName(), allEvents.GetMaxParticipants());
            }
        }

        // Method to fetch events created by a specific organizer and populate the organizer's event grid view (OrganizerManageEvents UI)
        private List<Event> currentCreatedEvents;
        public void fetchOrganizerEventRecords(DataGridView organizerEventGridView)
        {
            // Get the logged-in participant's ID
            int loggedInOrganizerID = Person.GetLoggedInUserId();

            // Fetch the event list for all organizers
            currentCreatedEvents = GetEventList();

            // Filter and add only the events for the logged-in organizer to the grid
            foreach (Event Events in currentCreatedEvents)
            {
                string formattedEventDate = Events.GetEventDate().ToString("yyyy-MM-dd");
                if (Events.GetOrganizerID() == loggedInOrganizerID)
                {
                    organizerEventGridView.Rows.Add(Events.GetEventID(), Events.GetEventName(), Events.GetEventDescription(), Events.GetEventVenue(), formattedEventDate, Events.GetMaxParticipants());
                }
                
            }
        }

        // Method to load organizer IDs into a combo box for selection (AdminManageEvents UI)
        public void LoadOrganizersIDToComboBox(System.Windows.Forms.ComboBox eventOrganizerIDCombo)
        {
            // Connect to the DB
            DBConnection dbConnection = new DBConnection();
            string query = "SELECT PersonID, Name FROM person WHERE Role = 'Organizer'"; // Get organizer ID and name
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable organizerTable = new DataTable();
                adapter.Fill(organizerTable);   // Fill the DataTable with query results

                // Bind the organizer ID to the ComboBox
                eventOrganizerIDCombo.DataSource = organizerTable;
                eventOrganizerIDCombo.DisplayMember = "PersonID";  // Display the PersonID in the ComboBox
                eventOrganizerIDCombo.ValueMember = "PersonID";    // Use PersonID as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organizers: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to load the name of the selected organizer from the Organizer ID combo box into a text box (AdminManageEvents UI, OrganizerManageEvents UI)
        public void LoadOrganizerNameToTextBox(System.Windows.Forms.ComboBox eventOrganizerIDCombo, System.Windows.Forms.TextBox eventOrganizerNameTextBox)
        {
            // Check if a valid organizer ID is selected
            if (!string.IsNullOrWhiteSpace(eventOrganizerIDCombo.Text) && int.TryParse(eventOrganizerIDCombo.Text, out int selectedID))
            {
                // Connect to the DB
                DBConnection dbConnection = new DBConnection();
                string query = "SELECT Name FROM person WHERE PersonID = @id AND Role = 'Organizer'"; // Get organizer name
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
                cmd.Parameters.AddWithValue("@id", selectedID);

                try
                {
                    dbConnection.OpenConnection();
                    object result = cmd.ExecuteScalar();  // Execute the query and get the organizer's name

                    // If a result is found, set the TextBox value
                    if (result != null)
                    {
                        eventOrganizerNameTextBox.Text = result.ToString();  // Automatically fill the name TextBox
                    }                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading organizer name: " + ex.Message);
                }
                finally
                {
                    dbConnection.CloseConnection();
                }

            }                     
        }

        // Method to add a new event to the database (AdminManageEvents UI, OrganizerManageEvents UI)
        public void AddEvents(string eventName, string description, string venue, DateTime eventdate, int organizerID, string maxParticipantsString)
        {
            // Validate that the maxParticipants are valid integers
            if (!int.TryParse(maxParticipantsString, out int maxParticipants))
            {
                MessageBox.Show("Maximum Participants must be valid integer values.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate input parameters
            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(venue) || organizerID <= 0 )
            {
                MessageBox.Show("All fields must be completed before creating an event.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if validation fails
            }

            DBConnection dbConnection = new DBConnection();

            try
            {
                dbConnection.OpenConnection();

                // Check for duplicate events with the same name and date
                string checkQuery = "SELECT COUNT(*) FROM event WHERE EventName = @eventname AND EventDate = @eventdate";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, dbConnection.GetConnection());
                checkCommand.Parameters.AddWithValue("@eventname", eventName);
                checkCommand.Parameters.AddWithValue("@eventdate", eventdate);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0) // If a duplicate is found
                {
                    MessageBox.Show("An event with the same name and date already exists.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if a duplicate is found
                }

                // Proceed to insert the new event if no duplicate found
                string query = "INSERT INTO event (EventName, Description, Venue, EventDate, OrganizerID, MaxParticipants) VALUES(@eventname, @desc, @venue, @eventdate, @orgID, @maxParticipants)";
                MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                command.Parameters.AddWithValue("@eventname", eventName);
                command.Parameters.AddWithValue("@desc", description);
                command.Parameters.AddWithValue("@venue", venue);
                command.Parameters.AddWithValue("@eventdate", eventdate);
                command.Parameters.AddWithValue("@orgID", organizerID);
                command.Parameters.AddWithValue("@maxParticipants", maxParticipants);

                command.Prepare();
                command.ExecuteNonQuery(); // Execute the insert command
                MessageBox.Show("Event created successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to remove Events from Database (AdminManageEvents UI, OrganizerManageEvents UI)
        public void RemoveEvents(string eventName, string venue, DateTime eventdate, int organizerID)
        {
            DBConnection dbConnection = new DBConnection();
            string query = "DELETE FROM event WHERE EventName= @eventName AND Venue = @eventVenue AND DATE(EventDate) = @eventdate AND OrganizerID = @orgID";
            MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());

            // Trim input parameters to avoid issues with extra spaces
            command.Parameters.AddWithValue("@eventName", eventName.Trim());
            command.Parameters.AddWithValue("@eventVenue", venue.Trim());
            command.Parameters.AddWithValue("@eventdate", eventdate);
            command.Parameters.AddWithValue("@orgID", organizerID);


            try
            {
                dbConnection.OpenConnection();
                command.Prepare();
                int rowsAffected = command.ExecuteNonQuery(); // Execute the command and get the number of affected rows

                // Show a message based on whether the deletion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Event Name: {eventName}\nEvent Venue: {venue}\nhas been successfully removed.");
                }
                else
                {
                    MessageBox.Show("No matching event found to delete. Please check the event details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        // Method to edit Events in the Database (AdminManageEvents UI, OrganizerManageEvents UI)
        public void UpdateEvent(string eventID, string eventName, string description, string venue, DateTime eventDate, int organizerID, string maxParticipantsString)
        {
            // Validate that maxParticipants is a valid integer
            if (!int.TryParse(maxParticipantsString, out int maxParticipants))
            {
                MessageBox.Show("Maximum Participants must be valid integer values.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate that all required fields are filled
            if (string.IsNullOrWhiteSpace(eventName) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(venue) || organizerID <= 0)
            {
                MessageBox.Show("All fields must be completed before editing an event.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            
            DBConnection dbConnection = new DBConnection();

            try
            {
                dbConnection.OpenConnection();

                // Update query to modify event details in the database
                string query = "UPDATE event SET EventName = @eventname, Description = @desc, Venue = @venue, EventDate = @eventdate, OrganizerID = @orgID, MaxParticipants = @maxParticipants WHERE EventID = @eventID";

                MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                command.Parameters.AddWithValue("@eventID", eventID);
                command.Parameters.AddWithValue("@eventname", eventName);
                command.Parameters.AddWithValue("@desc", description);
                command.Parameters.AddWithValue("@venue", venue);
                command.Parameters.AddWithValue("@eventdate", eventDate);
                command.Parameters.AddWithValue("@orgID", organizerID);
                command.Parameters.AddWithValue("@maxParticipants", maxParticipants);

                command.Prepare();

                int rowsAffected = command.ExecuteNonQuery(); // Execute the command and get the number of affected rows

                // Show a message based on whether the update was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event updated successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching event found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }        
    }
}    









