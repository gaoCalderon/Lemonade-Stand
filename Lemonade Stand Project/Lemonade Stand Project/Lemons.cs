using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Lemons : Inventory
    {
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



        //Console.WriteLine("How many lemons do you want to buy?");
        //Console.WriteLine("a.) 10 lemons for $1.00");
        //Console.WriteLine("b.) 30 lemons for $2.40");
        //Console.WriteLine("c.) 75 of lemons for $3.75");
    }
}
