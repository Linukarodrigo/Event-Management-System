using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class Participant : Person
    {
        //Constructor
        public Participant(int personID, string username, string password, string name, string phoneNo, string role) : base(personID, username, password, name, phoneNo, role)
        {
        }

        public Participant(int personID, string username, string name, string phoneNo) : base(personID, username, "", name, phoneNo, "Participant")
        {
            // This constructor only sets ID, name, and phoneNo, using default values for username, password, and role.
        }
    }
}
