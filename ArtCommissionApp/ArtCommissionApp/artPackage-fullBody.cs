using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCommissionApp
{
    class fullBody : ArtPackage
    {
        //attribute, field, variables
        int process;
        bool isBackground = false;
        bool isExtra = false;

        public fullBody(string name, int process)
        {
            packageName = name;
            this.process = process;
            this.isBackground = isBackground;
            this.isExtra = isExtra;
        }
        public void newFullbody()
        {
            bool input = Consolefunctions.Confirm("So it will be a character full-body commission. Will you accept drawing the background also ? ");

            if (input == true)
            {
                isBackground = true;
            }

            input = Consolefunctions.Confirm("What about detailed clothing, accessories, and the other extras? ");

            if (input == true)
            {
                isExtra = true;
            }

            price = CalculatePrice(isBackground, isExtra);
            duration = CalculateDuration(isBackground, isExtra);

        }

        public virtual double CalculatePrice(bool isBackground, bool isExtra)
        {
            double total = 100;

            if (isBackground == true)
            {
                total = total + 20;
            }

            if (isExtra == true)
            {
                total = total + 20;
            }

            return total;
        }

        public virtual double CalculateDuration(bool isBackground, bool isExtra)
        {
            double total = 6;

            if (isBackground == true)
            {
                total = total + 2;
            }

            if (isExtra == true)
            {
                total = total + 1;
            }

            return total;
        }
    }
}
