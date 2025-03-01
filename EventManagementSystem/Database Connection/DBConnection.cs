﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class DBConnection
    {
        private string server;
        private string database;
        private string user;
        private string password;
        private MySqlConnection connection;

        public DBConnection()
        {
            // Store the database credentials here
            server = "localhost";
            database = "eventmanagement_db";
            user = "root";
            password = "";

            string connectionString = $"server={server};database={database};user={user};password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
