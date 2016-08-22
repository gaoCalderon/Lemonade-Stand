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
        public static double aiTotalMoney;
        public static double madeMoney;
        public static double aiMadeMoney;
        public static double testAddMoney;
        public static double aiTestAddMoney;
        public static int cups;
        public static int aiCups;
        public static int lemons;
        public static int aiLemons;
        public static int sugar;
        public static int aiSugar;
        public static int iceCubes;
        public static int aiIceCubes;
        public static double humanScore;
        public static double computerScore;
        

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

        public double aiAddTotalMoneyMade()
        {
            double acc1 = aiTotalMoney;
            double acc2 = aiMadeMoney;
            double total = acc1 + acc2;
            aiTotalMoney = total;
            return aiTotalMoney;
        }

        public double runAfterAddTotalMoneyMade()
        {
            double acc2 = madeMoney;
            double total = madeMoney - acc2;
            madeMoney = total;
            return madeMoney;
        }

        public double aiRunAfterAddTotalMoneyMade()
        {
            double acc2 = aiMadeMoney;
            double total = aiMadeMoney - acc2;
            aiMadeMoney = total;
            return aiMadeMoney;
        }

        public double mathToCheckMoney()
        {
            double check1 = totalMoney;
            double check2 = madeMoney;
            double check3 = check1 + check2;
            testAddMoney = check3;
            return testAddMoney;
        }

        public double aiMathToCheckMoney()
        {
            double check1 = aiTotalMoney;
            double check2 = aiMadeMoney;
            double check3 = check1 + check2;
            aiTestAddMoney = check3;
            return aiTestAddMoney;
        }

        public void checkMoney()
        {
            mathToCheckMoney();
            Console.WriteLine("Money: {0}", testAddMoney);
        }

        public void aiCheckMoney()
        {
            aiMathToCheckMoney();
            Console.WriteLine("Money: {0}", aiTestAddMoney);
        }

        public double profit()
        {
            double start = 20;
            double value = totalMoney - start;
            testAddMoney = value;
            return testAddMoney;
        }

        public double aiProfit()
        {
            double start = 20;
            double value = aiTotalMoney - start;
            aiTestAddMoney = value;
            return aiTestAddMoney;
        }

        public double humanMore()
        {
            humanScore = testAddMoney - aiTestAddMoney;
            return humanScore;
        }

        public double computerMore()
        {
            computerScore = aiTestAddMoney - testAddMoney;
            return computerScore;
        }

    }
}
