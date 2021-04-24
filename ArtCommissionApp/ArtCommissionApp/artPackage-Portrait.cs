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
        bool isBackground = false;
        bool isExtra = false;

        public Portrait(string name, int process)
        {
            packageName = name;
            this.process = process;
            this.isBackground = isBackground;
            this.isExtra = isExtra;
        }
        public void newPortrait()
        {
            bool input = Consolefunctions.Confirm("So it will be a character portrait commission. Will you accept drawing the background also ? ");

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

            ShowPriceInformation();
            ShowDurationInformation();
            InsertPack();

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Consolefunctions.startMenu();
            }

        }

        public override void InsertPack()
        {
            using (var context = new ArtPackageContext())
            {

                var Package = new Package
                {
                    Name = packageName,

                    
                };
                context.Add(Package);
                context.SaveChanges();
                Console.WriteLine(Package.Name);
            }

        }

        public override double CalculatePrice(bool isBackground, bool isExtra)
        {
            double total = 20;

            if (isBackground == true)
            {
                total = total + 20;
            }

            if (isExtra == true)
            {
                total = total + 10;
            }

            return total;
        }

        public override double CalculateDuration(bool isBackground, bool isExtra)
        {
            double total = 2;

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
