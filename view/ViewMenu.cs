using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClone.view
{
    class ViewMenu
    {
        public static void MainMenu()
        {
            bool isCheck = true;

            while (isCheck) {
       
                string input;

                Console.Clear();
                Console.WriteLine("==BASIC AUTHENTICATION==");
                Console.WriteLine("1. Create User");
                Console.WriteLine("2. Show User");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Login");
                Console.WriteLine("5. Exit");
                Console.Write("Input : ");
                input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        ViewAccount.Register();
                        break;

                    case "2":
                        ViewAccount.ViewUser();
                        break;

                    case "3":
                        ViewAccount.Searching();
                        break;

                    case "4":
                        ViewAccount.Login();
                        break;

                    case "5":
                        isCheck = false;
                        break;

                    default:
                        Console.WriteLine("ERROR: Input not valid");
                        System.Threading.Thread.Sleep(1500);
                        Console.ReadLine();
                        isCheck = true;
                        break;
                }
            }
            
                
        }


    }
}
