using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Ice : Inventory
    {

        public static int IceRecipiCount;

        public void useIceCube()
        {
            iceCubes -= IceRecipiCount;
        }

        public void askNumberofCubes()
        {
            Console.WriteLine("Type in # of cubes per cup [ENTER KEY]");
        }

        public int setNumberCubesToCup()
        {
            string iceCubeInput = Console.ReadLine();
            IceRecipiCount = int.Parse(iceCubeInput);
            return IceRecipiCount;
        }

        public void buy100iceCube()
        {
            if (totalMoney > 0.75)
            {
                iceCubes += 100;
                totalMoney -= 0.75;
                Console.WriteLine("{0} has ${1} left.", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy250iceCube()
        {
            if (totalMoney > 2.00)
            {
                iceCubes += 250;
                totalMoney -= 2.00;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy500iceCubes()
        {
            if (totalMoney > 3.55)
            {
                iceCubes += 500;
                totalMoney -= 3.55;
                Console.WriteLine("{0} has ${1} left", Player.name, totalMoney);
            }
            else
            {
                moneyNotEnough();
            }
        }

        public int endDayNoIceCubes()
        {
            int one = iceCubes;
            int two = iceCubes - one;
            iceCubes = two;
            return iceCubes;
        }

        public int aiEndDayNoIceCubes()
        {
            int one = aiIceCubes;
            int two = aiIceCubes - one;
            aiIceCubes = two;
            return aiIceCubes;
        }
    }
}
