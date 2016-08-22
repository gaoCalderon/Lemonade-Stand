using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Sugar : Inventory
    {

        public static int SugarRecipiCount;

        public void useSugar()
        {
            sugar -= SugarRecipiCount;
        }

        public void askCupOfSugar()
        {
            Console.WriteLine("Type in # cups of Suger in pitcher [ENTER KEY]");
        }

        public int setCupsOfSugar()
        {
            string sugarInput = Console.ReadLine();
            SugarRecipiCount = int.Parse(sugarInput);
            return SugarRecipiCount;
        }

        public void buy8cupSugar()
        {
            if (totalMoney > 0.80)
            {
                sugar += 8;
                totalMoney -= 0.80;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy20cupSugar()
        {
            if (totalMoney > 1.60)
            {
                sugar += 20;
                totalMoney -= 1.60;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy48cupSugar()
        {
            if (totalMoney > 4.32)
            {
                sugar += 48;
                totalMoney -= 4.32;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
