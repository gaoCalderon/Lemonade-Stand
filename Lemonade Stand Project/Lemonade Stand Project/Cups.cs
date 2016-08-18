using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Cups : Inventory
    {

        public void buy25Cups()
        {
            if (getMoney() > 1.00m)
            {
                cups += 25;
                money -= 1.00m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy50Cups()
        {
            if (getMoney() > 1.50m)
            {
                cups += 50;
                money -= 1.50m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy100Cups()
        {
            if (getMoney() > 2.80m)
            {
                cups += 100;
                money -= 2.80m;
            }
        }
   
    }
}
