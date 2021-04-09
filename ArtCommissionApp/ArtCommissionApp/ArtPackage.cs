using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCommissionApp
{
    public class ArtPackage
    {
        //attribute, field, variables
        public string packageName;
        public double price;
        public double duration;
        public int stage;

        //constructor

        //ini procedure
        public void ShowPriceInformation()
        {
            Console.WriteLine("the {0} package will cost {1} dollars", packageName, price);
        }

        public void ShowDurationInformation()
        {
            Console.WriteLine("the {0} package will take about {1} hours", packageName, duration);
        }

        public void CreateNewPackage()
        {
            
            Console.WriteLine("\nPackages makes it easy for your client to see what kind of artwork you are capable of making, and help them choose.");
            Console.WriteLine("You haven't set up any packages. Let's make a new one.");

            //new package
            Console.WriteLine("\nWhat's the package name?");
            packageName = Console.ReadLine();
            Console.WriteLine("Ok, the package name is " + packageName);


            Console.WriteLine("\nHow complete would the art be in this package you're offering?");
            Console.WriteLine("\n 1. Just the sketching, conceptual stage \n 2. Fully inked, black-and-white colored \n 3. Fully colored, finished illustration");
    
            switch (Console.ReadLine())
            {
                case "1":
                    stage = 1;
                    break;
                case "2":
                    stage = 2;
                    break;
                case "3":
                    stage = 3;
                    break;
                default:
                    break;
            }


            Console.WriteLine("\nWhat type of artwork will it be? \n (1) portrait character art \n (2) half-body character \n (3) full-body character");
            switch (Console.ReadLine())
            {
                case "1":
                    Portrait myPortrait = new Portrait(packageName, stage);
                    myPortrait.newPortrait();
            
                    break;
                case "2":
                    halfBody myHalfbody = new halfBody(packageName, stage);
                    myHalfbody.newHalfbody();
               
                    break;
                case "3":
                    fullBody myFullbody = new fullBody(packageName, stage);
                    myFullbody.newFullbody();
             
                    break;
                default:
                    break;
            }



        }

        public virtual double CalculatePrice(bool isBackground, bool isExtra)
        {
            return 0;
        }

        public virtual double CalculateDuration(bool isBackground, bool isExtra)
        {
            return 0;
        }

        //ini function
        //public double CalculatePrice(int category, int isBackground)
        //{
        //    double total = 0;
        //    //total price
        //    if (category == 1)
        //    {
        //        total = 20;
        //    }
        //    else if (category == 2)
        //    {
        //        total = 40;
        //    }
        //    else if (category == 3)
        //    {
        //        total = 60;
        //    }

        //    if (isBackground == 1)
        //    {
        //        total = total + 20;
        //    }

        //    return total;
        //}
    }
}
