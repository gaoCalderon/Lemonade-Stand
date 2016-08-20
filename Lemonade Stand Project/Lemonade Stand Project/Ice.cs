using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Ice : Inventory
    {

        int IceRecipiCount;

        public void useIceCube()
        {
            iceCubes -= getIceCubePerCup();
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

        public int getIceCubePerCup()
        {
            return IceRecipiCount;
        }

        public void buy100iceCube()
        {
            if (getTotalMoney() > 0.75)
            {
                iceCubes += 100;
                totalMoney -= 0.75;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy250iceCube()
        {
            if (getTotalMoney() > 2.00)
            {
                iceCubes += 250;
                totalMoney -= 2.00;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy500iceCubes()
        {
            if (getTotalMoney() > 3.55)
            {
                iceCubes += 500;
                totalMoney -= 3.55;
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
    }
}
