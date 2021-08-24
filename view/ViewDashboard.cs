using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppClone.service;
using ConsoleAppClone.entity;

namespace ConsoleAppClone.view
{
    class ViewDashboard
    {
        public static void ChangePassword(string username)
        {
            Console.WriteLine("Mau ganti password? y/n");
            bool isCheck = (Console.ReadLine() == "y") ? true:false ;

            while(isCheck)
            {
                Console.WriteLine("Masukkan password saat ini :");
                string inputPass = Console.ReadLine();

                if (ServiceAccount.CheckPassword(username, inputPass))
                {
                    Console.WriteLine("Masukan password baru :");
                    string inputPassNew = Console.ReadLine();

                    var accounts = ImplementAccount.GetAll();

                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].Username == username)
                        {
                            accounts[i].Password = BCrypt.Net.BCrypt.HashPassword(inputPassNew);
                            Console.WriteLine("PASSWORD BERHASIL DIUBAH !");
                            System.Threading.Thread.Sleep(1500);
                            isCheck = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("WRONG PASSWORD!!!");
                }
            }
        }
    }
}
