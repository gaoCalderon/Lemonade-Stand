using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Lemons : Inventory
    {

        public static int lemonRecipiCount;

        public void useLemon()
        {
            lemons -= lemonRecipiCount;
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

        public void buy10Lemons()
        {
            if (totalMoney > 1.00)
            {
                lemons += 10;
                totalMoney -= 1.00;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy30Lemons()
        {
            if (totalMoney > 2.40)
            {
                lemons += 30;
                totalMoney -= 2.40;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy75Lemons()
        {
            if (totalMoney > 3.75)
            {
                lemons += 75;
                totalMoney -= 3.75;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
