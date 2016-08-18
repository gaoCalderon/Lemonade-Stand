using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Lemons : Inventory
    {

        public void useLemon()
        {
            lemons -= 1;
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
