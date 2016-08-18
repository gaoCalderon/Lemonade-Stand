using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Ice : Inventory
    {

        public void buy100iceCube()
        {
            if (getMoney() > 0.75m)
            {
                iceCubes += 100;
                money -= 0.75m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy250iceCube()
        {
            if (getMoney() > 2.00m)
            {
                iceCubes += 250;
                money -= 2.00m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy500iceCubes()
        {
            if (getMoney() > 3.55m)
            {
                iceCubes += 500;
                money -= 3.55m;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
