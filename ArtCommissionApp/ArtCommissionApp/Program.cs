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
 
            //if artist:
            Console.WriteLine("How shall you start conducting your business?");
            Console.WriteLine("\n 1. Offer packages \n 2. Organize orders \n 3. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("you choose 1");
                    break;
                case "2":
                    Console.WriteLine("you choose 2");
                    break;
                case "3":
                    Console.WriteLine("you choose 3");
                    break;
                default:
                    break;
            }



           
            bool input = Consolefunctions.Confirm("do you wanna die?");

            if (input == true)
            {
                Console.WriteLine("hahahahah");
            } else {
                Console.WriteLine("hohohoho");
            }

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("you choose 1"); 
                    break;
                case "2":
                    Console.WriteLine("you choose 2");
                    break;
                case "3":
                    Console.WriteLine("you choose 3");
                    break;
                default:
                    break;
            }











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
