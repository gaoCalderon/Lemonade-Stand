using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Inventory
    {
        public double money;
        public int cups;
        public int lemons;
        public int sugar;
        public int iceCubes;
        public int possibleBuy;
        public int numberOfSoldcups;

        public void inventoryProducts()
        {
            this.money = 20;
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.iceCubes = 0;
        }

        public double getMoney()
        {
            return this.money;
        }

        public void checkMoney()
        {
            Console.WriteLine("Money: {0}", getMoney());
        }

        public int getCups()
        {
            return this.cups;
        }

        public int getLemons()
        {
            return this.lemons;
        }

        public int getSugar()
        {
            return this.sugar;
        }

        public int getIceCubes()
        {
            return this.iceCubes;
        }

        public void moneyNotEnough()
        {
            Console.WriteLine("You don't have enough money.");
        }
    }
}
