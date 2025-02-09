using EventManagementSystem;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Mysqlx.Prepare;

internal class PersonManager : IUserAuthentication
{
    // Hashes the given password using SHA256 for secure storage in database
    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString(); // returns the hashed password
        }
    }

    // User login method which validates user credentials
    public Person Login(string username, string password)
    {
        // Hash the entered password for comparison with the database
        string hashedPassword = HashPassword(password);

        // Connect to the DB
        DBConnection dbConnection = new DBConnection();
        string query = "SELECT * FROM person WHERE Username = @username";
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@username", username);

        Person person = null; // Initialize the person object

        try
        {
            dbConnection.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            // If user exists in the database (Validate the reader object) 
            if (reader.Read())
            {
                // Retrieve the hashed password from the database
                string storedHashedPassword = reader["Password"].ToString();
                if (storedHashedPassword == hashedPassword) // Compare passwords
                {
                    // Successful authentication
                    int personID = int.Parse(reader["PersonID"].ToString());
                    string name = reader["Name"].ToString();
                    string phoneNo = reader["PhoneNo"].ToString();
                    string role = reader["Role"].ToString().ToLower();

                    // Determine the user's role and create the appropriate object
                    if (role == "admin")
                    {
                        person = new Admin(personID, username, password, name, phoneNo, role);
                    }
                    else if (role == "organizer")
                    {
                        person = new Organizer(personID, username, password, name, phoneNo, role);
                        Person.SetLoggedInUserId(personID); // Set organizer ID
                    }
                    else if (role == "participant")
                    {
                        person = new Participant(personID, username, password, name, phoneNo, role);
                        Person.SetLoggedInUserId(personID); // Set participant ID
                    }
                    return person; // Return the authenticated person object
                }
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
        return null; // Return null if authentication fails
    }

    // Method to check if the username already exists in the database
    public bool IsUserAlreadyRegistered(string username)
    {
        DBConnection dbConnection = new DBConnection();
        string query = "SELECT COUNT(*) FROM person WHERE Username = @username";
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());
        cmd.Parameters.AddWithValue("@username", username);

        try
        {
            dbConnection.OpenConnection(); 
            int count = Convert.ToInt32(cmd.ExecuteScalar()); // Get the count of records with the same username
            return count > 0;  // Return true if user already exists
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while checking registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    // Method to add a new user to the database
    public bool AddUser(string username, string password,string name, string phoneNoString, string role)
    {
        // Check for null or empty fields
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role))
        {
            MessageBox.Show("All fields must be completed before registration.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Validate that maxParticipants is a valid integer
        if (!int.TryParse(phoneNoString, out int phoneNo))
        {
            MessageBox.Show("Please enter a valid phone number (only integers allowed)", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false; // Exit the method if validation fails
        }

        // Check if the user is already registered
        if (IsUserAlreadyRegistered(username))
        {
            MessageBox.Show("This username is already registered. Please use a different username.", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Hash the password for secure storage in database
        string hashedPassword = HashPassword(password);

        DBConnection dbConnection = new DBConnection();
        string query = "INSERT INTO person (Username, Password, Name, PhoneNo, Role) VALUES(@username, @pwd, @name, @phoneNo, @role)";
        MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@pwd", hashedPassword);
        command.Parameters.AddWithValue("@name", name);
        command.Parameters.AddWithValue("@phoneNo", phoneNo);
        command.Parameters.AddWithValue("@role", role);

        try
        {
            dbConnection.OpenConnection();
            command.Prepare(); // Prepare the SQL command
            command.ExecuteNonQuery(); // Execute the query
            MessageBox.Show("You are successfully registered.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            dbConnection.CloseConnection();
        }

    }

    // Retrieves a list of all participants from the database
    public List<Participant> GetParticipantList()
    {
        List<Participant> currentParticipants = new List<Participant>();

        DBConnection dbConnection = new DBConnection();
        string query = "SELECT * FROM person WHERE Role = 'Participant'";
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

        try
        {
            dbConnection.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            // Loop through the results and add them to the participant list
            while (reader.Read())
            {
                int participantID = int.Parse(reader["PersonID"].ToString());
                string participantUsername = reader["Username"].ToString();
                string participantName = reader["Name"].ToString();
                string participantPhoneNo = reader["PhoneNo"].ToString();

                // Create a new Participant object and add it to the list
                Participant participant = new Participant(participantID, participantUsername, participantName, participantPhoneNo);
                currentParticipants.Add(participant);
            }
            reader.Close();
            return currentParticipants;
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while fetching participants: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<Participant>(); // Return an empty list on error
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    //Fetch Participant records to the Participant data grid (ManageParticipants UI)
    private List<Participant> currentParticipants;
    public void fetchParticipantRecords(DataGridView participantGridView)
    {
        currentParticipants = GetParticipantList();

        // Loop through participants and add them to the Participant DataGridView
        foreach (Participant participant in currentParticipants)
        {
            participantGridView.Rows.Add(participant.GetPersonID(),participant.GetUsername(), participant.GetName(), participant.GetPhoneNo());
        }
    }

    // Retrieves a list of all organizers from the database
    public List<Organizer> GetOrganizerList()
    {
        List<Organizer> currentOrganizers = new List<Organizer>();

        DBConnection dbConnection = new DBConnection();
        string query = "SELECT * FROM person WHERE Role = 'Organizer'";
        MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

        try
        {
            dbConnection.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            // Loop through the results and add them to the organizer list
            while (reader.Read())
            {
                int organizerID = int.Parse(reader["PersonID"].ToString());
                string organizerUsername = reader["Username"].ToString();
                string organizerName = reader["Name"].ToString();
                string organizerPhoneNo = reader["PhoneNo"].ToString();

                // Create a new Organizer object and add it to the list
                Organizer organizer = new Organizer(organizerID, organizerUsername, organizerName, organizerPhoneNo);
                currentOrganizers.Add(organizer);
            }
            reader.Close();
            return currentOrganizers;

        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while fetching organizers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<Organizer>(); // Return an empty list on error
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    //Fetch Organizers records to the Organizer data grid (ManageOrganizers UI)
    private List<Organizer> currentOrganizers;
    public void fetchOrganizerRecords(DataGridView organizerGridView)
    {
        currentOrganizers = GetOrganizerList();

        // Loop through organizers and add them to the Organizer DataGridView
        foreach (Organizer organizer in currentOrganizers)
        {
            organizerGridView.Rows.Add(organizer.GetPersonID(),organizer.GetUsername(), organizer.GetName(), organizer.GetPhoneNo());
        }
    }

    // Method to remove participants from the database (ManageParticipants UI)
    public void RemoveParticipants(int participantID, string participantName)
    {
        DBConnection dbConnection = new DBConnection();
        string query = "DELETE FROM person WHERE PersonID= @id";
        MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
        command.Parameters.AddWithValue("@id", participantID);

        try
        {
            dbConnection.OpenConnection();
            command.Prepare(); // Prepare the query before execution
            int result = command.ExecuteNonQuery();  // Execute the query and get the number of affected rows

        if (result > 0)
        {
            // If the participant was successfully removed, show a confirmation message
            MessageBox.Show($"Participant with ID: {participantID}\nName: {participantName}\nhas been successfully removed.", "Removal Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // If no rows were affected, it means the participant does not exist
            MessageBox.Show($"Participant with ID: {participantID} could not be found.", "Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while trying to remove participant: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            dbConnection.CloseConnection();
        }
    }

    // Method to remove organizers from the database (ManageOrganizers UI)
    public void RemoveOrganizers(int organizerID, string organizerName)
    {
        DBConnection dbConnection = new DBConnection();
        string query = "DELETE FROM person WHERE PersonID= @id";
        MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
        command.Parameters.AddWithValue("@id", organizerID);

        try
        {
            dbConnection.OpenConnection();
            command.Prepare();
            int result = command.ExecuteNonQuery();  // Execute the query and get the number of affected rows

            if (result > 0)
            {
                // If the organizer was successfully removed, show a confirmation message
                MessageBox.Show($"Organizer with ID: {organizerID}\nName: {organizerName}\nhas been successfully removed.", "Removal Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If no rows were affected, it means the organizer does not exist
                MessageBox.Show($"Organizer with ID: {organizerID} could not be found.", "Removal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (MySqlException ex)
        {
            // Check for the foreign key constraint error (MySQL error code 1451)
            if (ex.Number == 1451)
            {
                MessageBox.Show($"The organizer '{organizerName}' has created events. Please remove all events created by this organizer before attempting to remove them.",
                                "Foreign Key Constraint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // For any other MySQL exceptions, show a general error message
                MessageBox.Show($"An error occurred while trying to remove organizer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        finally
        {
            dbConnection.CloseConnection();
        }

    }
}


