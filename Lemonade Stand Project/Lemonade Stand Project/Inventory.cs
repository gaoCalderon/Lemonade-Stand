using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Inventory
    {
        public double totalMoney;
        public double madeMoney;
        public double testAddMoney;
        public int cups;
        public int lemons;
        public int sugar;
        public int iceCubes;

        public void inventoryProducts()
        {
            this.totalMoney = 20;
            this.madeMoney = 0;
            this.testAddMoney = 0;
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.iceCubes = 0;
        }

        public double getTotalMoney()
        {
            return this.totalMoney;
        }

        public double getMadeMoney()
        {
            return this.madeMoney;
        }

        public double getTestAddMoney()
        {
            return this.testAddMoney;
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
            checkMoney();
        }

        public double addTotalMoneyMade()
        {
            double acc1 = totalMoney;
            double acc2 = madeMoney;
            double total = acc1 + acc2;
            totalMoney = total;
            return totalMoney;
        }

        public double runAfterAddTotalMoneyMade()
        {
            double acc2 = madeMoney;
            double total = madeMoney - acc2;
            madeMoney = total;
            return madeMoney;
        }

        public double mathToCheckMoney()
        {
            double check1 = totalMoney;
            double check2 = madeMoney;
            double check3 = check1 + check2;
            testAddMoney = check3;
            return testAddMoney;
        }

        public void checkMoney()
        {
            mathToCheckMoney();
            Console.WriteLine("Money: {0}", getTestAddMoney());
        }

        public double profit()
        {
            double start = 20;
            double value = totalMoney - start;
            testAddMoney = value;
            return testAddMoney;
        }
    }
}
