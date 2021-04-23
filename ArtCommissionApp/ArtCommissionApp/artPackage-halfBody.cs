using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCommissionApp
{
    class halfBody : ArtPackage
    {
        //attribute, field, variables
        int process;
        bool isBackground = false;
        bool isExtra = false;

        public halfBody(string name, int process)
        {
            packageName = name;
            this.process = process;
            this.isBackground = isBackground;
            this.isExtra = isExtra;
        }
        public void newHalfbody()
        {
            bool input = Consolefunctions.Confirm("So it will be a character halfBody commission. Will you accept drawing the background also ? ");

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

                    PackageInfo = new List<PackageInfo>
                    {
                        new PackageInfo { Name = packageName,
                            Price = (int)price,
                            Duration = (int)duration },

                    }
                };
                context.Add(Package);
                context.SaveChanges();

            }

        }

        public override double CalculatePrice(bool isBackground, bool isExtra)
        {
            double total = 40;

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

        public override double CalculateDuration(bool isBackground, bool isExtra)
        {
            double total = 3;

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
