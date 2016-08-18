using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Lemons : Inventory
    {

        int lemonNumber;

        public void useLemon()
        {
            lemons -= 1;
        }

        public void askNumberOfLemons()
        {
            Console.WriteLine("# of lemons in a pitcher?");
        }

        public int setNumberOfLemons()
        {
            string lemonInput = Console.ReadLine();
            lemonNumber = int.Parse(lemonInput);
            return lemonNumber;
        }

        public int getLemonPerPitcher()
        {
            return lemonNumber;
        }

        public void buy10Lemons()
        {
            if (getMoney() > 1.00m)
            {
                lemons += 10;
                money -= 1.00m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy30Lemons()
        {
            if (getMoney() > 2.40m)
            {
                lemons += 30;
                money -= 2.40m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy75Lemons()
        {
            if (getMoney() > 3.75m)
            {
                lemons += 75;
                money -= 3.75m;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
