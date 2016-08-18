using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Inventory
    {
        public decimal money;
        public int cups;
        public int lemons;
        public int sugar;
        public int iceCubes;

        public void inventoryProducts()
        {
            this.money = 20;
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.iceCubes = 0;
        }

        public decimal getMoney()
        {
            return this.money;
        }

        public decimal checkMoney()
        {
             return getMoney();
        }

        public decimal useMoney()
        {
            Store i = new Store();

            result = getMoney +- ();
            return result;
        }

        public decimal lemonadePurchase()
        {
            //don't have this resolved yet!!! need help
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
