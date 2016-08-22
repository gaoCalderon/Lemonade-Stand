using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Inventory
    {
        public static double totalMoney;
        public static double madeMoney;
        public static double testAddMoney;
        public static int cups;
        public static int lemons;
        public static int sugar;
        public static int iceCubes;

        public double getTotalMoney()
        {
            return totalMoney;
        }

        public double getMadeMoney()
        {
            return madeMoney;
        }

        public double getTestAddMoney()
        {
            return testAddMoney;
        }

        public int getCups()
        {
            return cups;
        }

        public int getLemons()
        {
            return lemons;
        }

        public int getSugar()
        {
            return sugar;
        }

        public int getIceCubes()
        {
            return iceCubes;
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
