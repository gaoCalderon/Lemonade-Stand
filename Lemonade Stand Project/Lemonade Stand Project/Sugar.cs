using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Sugar : Inventory
    {

        public void buy8cupSugar()
        {
            if (getMoney() > 0.80m)
            {
                sugar += 8;
                money -= 0.80m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy20cupSugar()
        {
            if (getMoney() > 1.60m)
            {
                sugar += 20;
                money -= 1.60m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy48cupSugar()
        {
            if (getMoney() > 4.32m)
            {
                sugar += 48;
                money -= 4.32m;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
