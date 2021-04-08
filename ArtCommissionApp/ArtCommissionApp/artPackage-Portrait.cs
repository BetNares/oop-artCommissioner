using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCommissionApp
{
    public class Portrait : ArtPackage
    {
        //attribute, field, variables
        int process;

        public Portrait(string name, int process)
        {
            packageName = name;
            this.process = process;
        }
        public void newPortrait()
        {
            Console.WriteLine("So it will be a character portrait commission. Will you accept drawing the background also? (y/n)");
            //input
            Console.WriteLine("What about detailed clothing, accessories, and the other extras? (y/n)");
            //input

            price = CalculatePrice(isBackground, isExtra);
            duration = CalculateDuration(isBackground, isExtra);

        }

        public virtual double CalculatePrice(int isBackground, int isExtra)
        {
            double total = 20;

            if (isBackground == 1)
            {
                total = total + 20;
            }

            if (isExtra == 1)
            {
                total = total + 20;
            }

            return total;
        }

        public virtual double CalculateDuration(int isBackground, int isExtra)
        {
            double total = 2;

            if (isBackground == 1)
            {
                total = total + 2;
            }

            if (isExtra == 1)
            {
                total = total + 1;
            }

            return total;
        }
    }
}
