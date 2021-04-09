using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCommissionApp
{
    public static class Consolefunctions
    {

        public static bool startMenu()
        {

            Console.WriteLine("\n 1. Offer packages \n 2. Organize orders \n 3. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("you'll offer some packages.");
                    ArtPackage newPackage = new ArtPackage();
                    newPackage.CreateNewPackage();
                    return false;
                case "2":
                    Console.WriteLine("you'll organize your orders.");
                    Console.WriteLine("this feature is not available yet!");
                    return true;
                case "3":
                    Console.WriteLine("are you sure you want to exit?");
                    bool input = Consolefunctions.Confirm(" ");
                        if (input == true)
                        {
                            Console.WriteLine("Goodbye!");
                            return false;
                        } else {
                            return true;
                        }
                default:
                    return true;
            }
        }


        public static bool Confirm(string title)
        {
            ConsoleKey response;
            do
            {
                Console.Write($"{ title } [y/n] ");
                response = Console.ReadKey(false).Key;
                if (response != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }
            } while (response != ConsoleKey.Y && response != ConsoleKey.N);

            return (response == ConsoleKey.Y);
        }


    }
}