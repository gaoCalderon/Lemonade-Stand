using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Sugar : Inventory
    {

        int SugarRecipiCount;

        public void useSugar()
        {
            sugar -= 1;
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

        public int getSugarPerPitcher()
        {
            return SugarRecipiCount;
        }

        public void buy8cupSugar()
        {
            if (getMoney() > 0.80)
            {
                sugar += 8;
                money -= 0.80;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy20cupSugar()
        {
            if (getMoney() > 1.60)
            {
                sugar += 20;
                money -= 1.60;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy48cupSugar()
        {
            if (getMoney() > 4.32)
            {
                sugar += 48;
                money -= 4.32;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
