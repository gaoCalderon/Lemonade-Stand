using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Lemons : Inventory
    {

        int lemonRecipiCount;

        public void useLemon()
        {
            lemons -= 1;
        }

        public void askNumberOfLemons()
        {
            Console.WriteLine("Type in # of lemons a pitcher [ENTER KEY]");
        }

        public int setNumberOfLemons()
        {
            string lemonInput = Console.ReadLine();
            lemonRecipiCount = int.Parse(lemonInput);
            return lemonRecipiCount;
        }

        public int getLemonPerPitcher()
        {
            return lemonRecipiCount;
        }

        public void buy10Lemons()
        {
            if (getMoney() > 1.00)
            {
                lemons += 10;
                money -= 1.00;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy30Lemons()
        {
            if (getMoney() > 2.40)
            {
                lemons += 30;
                money -= 2.40;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy75Lemons()
        {
            if (getMoney() > 3.75)
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
