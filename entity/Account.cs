using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClone.entity
{
    class Account
    {
        public string Username { get; protected internal set; }
        public string Password { get; protected internal set; }
        public string Firstname { get; protected internal set; }
        public string Lastname { get; protected internal set; }


        public Account()
        {

        }


        public Account(string username, string password, string firstname, string lastname)
        {
            Username = username;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
