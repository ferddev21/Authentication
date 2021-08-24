using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClone.entity
{
    class ImplementAccount : Account
    {
        public static List<Account> account = new List<Account>();

        public static bool Insert(string username, string password, string firstname, string lastname)
        {
            account.Add(
                new Account(username, password, firstname, lastname
                ));
            return true;
        }

        public static List<Account> GetAll()
        {
            return account;
        }


    }
}
