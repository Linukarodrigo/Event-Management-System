using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal class Admin : Person
    {
        //Constructor
        public Admin(int personID, string username, string password, string name, string phoneNo, string role) : base(personID, username, password, name, phoneNo, role)
        {
        }
    }
}
