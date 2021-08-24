using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppClone.entity;
using System.Text.RegularExpressions;

namespace ConsoleAppClone.service
{
    class ServiceAccount
    {

        public static bool Create(string password, string firstname, string lastname)
        {
            var accounts = ImplementAccount.GetAll();
            string username = firstname.Substring(0, 2) + lastname.Substring(0, 2);
            
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == username)
                {
                    var random = new Random();
                    username = username+random.Next(10, 99);
                }  
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            ImplementAccount.Insert( username, hashedPassword, firstname, lastname);
            return true;
        }

        public static bool CheckPassword(string username, string password)
        {
            if (username != "" && password != "")
            {
                var accounts = ImplementAccount.GetAll();
                
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].Username == username)
                    {
                        if (BCrypt.Net.BCrypt.Verify(password, accounts[i].Password))
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }

        public static bool CheckUsername(string username)
        {
            if (username != "")
            {
                var accounts = ImplementAccount.GetAll();

                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].Username == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
