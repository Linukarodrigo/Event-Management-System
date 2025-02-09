using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    public abstract class Person
    {
        //Attributes
        private int personID;
        private string username;
        private string password;
        private string name;
        private string phoneNo;
        private string role;

        // Static field for logged-in user ID
        private static int loggedInUserId;

        //Constructor
        public Person(int personID, string username, string password, string name, string phoneNo, string role)
        {
            this.personID = personID;
            this.username = username;
            this.password = password;
            this.name = name;
            this.phoneNo = phoneNo;
            this.role = role;     
        }

        //Getters and setters
        public int GetPersonID()
        {
            return personID;
        }

        public void SetPersonID(int personID)
        {
            this.personID = personID;           
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetPhoneNo()
        {
            return phoneNo;
        }

        public void SetPhoneNo(string phoneNo)
        {
            this.phoneNo = phoneNo;
        }

        public string GetRole()
        {
            return role;
        }

        public void SetRole(string role)
        {
            this.role = role;
        }

        public static int GetLoggedInUserId()
        {
            return loggedInUserId;
        }

        public static void SetLoggedInUserId(int id)
        {
            loggedInUserId = id;          
        }




    }
}
