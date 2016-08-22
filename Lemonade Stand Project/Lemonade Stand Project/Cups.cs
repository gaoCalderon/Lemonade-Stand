using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Cups : Inventory
    {
        public static double cupCost;
        public static int recordCupsSold;
        public static int aiRecordCupsSold;


        public void purchaseCup()
        {
            cups -= 1;
            recordCupsSold += 1;
            Cups.cupCost += Inventory.madeMoney;
        }

        public void aiPurchaseCup()
        {
            Recipe r = new Recipe();
            aiCups -= 1;
            aiRecordCupsSold += 1;
            r.aiDefaultCupCharge();
        }

        public void askCupCharge()
        {
            Console.WriteLine("Type in how much you would like to charge a cup [ENTER KEY]");
        }

        public double setCupCharge()
        {
            string costInput = Console.ReadLine();
            cupCost = double.Parse(costInput);
            return cupCost;
        }

        public void buy25Cups()
        {
            if (totalMoney > 1.00)
            {
                cups += 25;
                totalMoney -= 1.00;
                Console.WriteLine("{0} has ${1} left.", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy50Cups()
        {
            if (totalMoney > 1.50)
            {
                cups += 50;
                totalMoney -= 1.50;
                Console.WriteLine("{0} has ${1} left.", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy100Cups()
        {
            if (totalMoney > 2.80)
            {
                cups += 100;
                totalMoney -= 2.80;
                Console.WriteLine("{0} has ${1} left.", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

    }
}
