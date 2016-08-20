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
            lemons -= getLemonPerPitcher();
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
            if (getTotalMoney() > 1.00)
            {
                lemons += 10;
                totalMoney -= 1.00;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy30Lemons()
        {
            if (getTotalMoney() > 2.40)
            {
                lemons += 30;
                totalMoney -= 2.40;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy75Lemons()
        {
            if (getTotalMoney() > 3.75)
            {
                lemons += 75;
                totalMoney -= 3.75;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
