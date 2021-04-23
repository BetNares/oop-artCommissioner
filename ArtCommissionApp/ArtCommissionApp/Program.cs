using System;

namespace ArtCommissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Art Commissioner!");
            Console.WriteLine("\nThis console application simulates the process of offering and ordering an artwork from an artist.");
            Console.WriteLine("in this version, we are only helping the artist's side of business. As an organizer, of sorts.");
            Console.WriteLine("Artists are unorganized creatures after all, particularly THIS artist (the creator of this app).");
            Console.WriteLine("So anyway,");
 
            Console.WriteLine("How shall you start conducting your business?");
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Consolefunctions.startMenu();
            }



        }
    }
}
