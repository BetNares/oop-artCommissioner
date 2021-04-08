using System;

namespace ArtCommissionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Art Commissioner!");
            Console.WriteLine("\nThis console application simulates the process of offering and ordering an artwork from an artist.");
            Console.WriteLine("\nin this version, we are only helping the artist's side of business. As an organizer, of sorts.");
            Console.WriteLine("\nArtists are unorganized creatures after all, particularly THIS artist (the creator of this app).");
            Console.WriteLine("\nSo anyway,");
 
            //if artist:
            Console.WriteLine("How shall you start conducting your business?");
            Console.WriteLine("\n 1. Offer packages \n 2. Organize orders \n 3. Exit");

            //if package
            Console.WriteLine("\nPackages makes it easy for your client to see what kind of artwork you are capable of making, and help them choose.");
            //if no package
            Console.WriteLine("\nYou haven't set up any packages. Let's make a new one.");
            //if else
            Console.WriteLine("\nYou are offering (number) packages. Make a new one? (y/n)");


            //new package
            Console.WriteLine("\nWhat's the package name?");
            //input
            Console.WriteLine("\nHow complete would the art be in this package you're offering?");
            Console.WriteLine("\n 1. Just the sketching, conceptual stage \n 2. Fully inked, black-and-white colored \n 3. Fully colored, finished illustration");
            //input
            Console.WriteLine("\nWhat type of artwork will it be? \n (1) portrait character art \n (2) half-body character \n (3) full-body character");
            //if portrait, create portrait object, etc etc
            Console.WriteLine("\nblablablabal");











            //// tampilan UI
            //Console.WriteLine("Enter package name: ");
            //string nama = Console.ReadLine();

            //Console.WriteLine("\nEnter the category number: ");
            //Console.WriteLine("(1) portrait \n(2) half-body \n(3) full-body");
            //string myKategori = Console.ReadLine();
            //int kategori = int.Parse(myKategori);

            //Console.WriteLine("Have background in the art?(yes = 1/ no = 0)");
            //string myBackground = Console.ReadLine();
            //int isBackground = int.Parse(myKategori);

            ////OOP
            //ArtPackage fullPortrait = new ArtPackage(nama, kategori, isBackground);

            ////ini call function
            //double price = fullPortrait.CalculatePrice(kategori, isBackground);

            ////ini call procedure
            //fullPortrait.ShowPriceInformation();

            //Console.ReadLine();



        }
    }
}
