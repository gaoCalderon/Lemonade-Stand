using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Cups : Inventory
    {
        public double cupCost;

        public void purchaseCup()
        {
            cups -= 1;
            money += getCupCharge();
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

        public double getCupCharge()
        {
            return cupCost;
        }

        public void buy25Cups()
        {
            if (getMoney() > 1.00)
            {
                cups += 25;
                money -= 1.00;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy50Cups()
        {
            if (getMoney() > 1.50)
            {
                cups += 50;
                money -= 1.50;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy100Cups()
        {
            if (getMoney() > 2.80)
            {
                cups += 100;
                money -= 2.80;
            }
            else
            {
                moneyNotEnough();
            }
        }

    }
}
