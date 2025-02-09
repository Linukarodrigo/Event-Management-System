﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    internal interface IUserAuthentication
    {
        Person Login(string username, string password);
        bool AddUser(string username, string password, string name, string phoneNo, string role);
    }
}

