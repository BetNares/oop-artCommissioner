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
