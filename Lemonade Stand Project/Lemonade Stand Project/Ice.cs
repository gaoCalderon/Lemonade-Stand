using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Ice : Inventory
    {

        int numberOfIceCubes;

        public void useIceCube()
        {
            iceCubes -= 1;
        }

        public void askNumberofCubes()
        {
            Console.WriteLine("# of cubes per cup?");
        }

        public int setNumberCubesToCup()
        {
            string iceCubeInput = Console.ReadLine();
            numberOfIceCubes = int.Parse(iceCubeInput);
            return numberOfIceCubes;
        }

        public int getIceCubePerCup()
        {
            return numberOfIceCubes;
        }

        public void buy100iceCube()
        {
            if (getMoney() > 0.75m)
            {
                iceCubes += 100;
                money -= 0.75m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy250iceCube()
        {
            if (getMoney() > 2.00m)
            {
                iceCubes += 250;
                money -= 2.00m;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy500iceCubes()
        {
            if (getMoney() > 3.55m)
            {
                iceCubes += 500;
                money -= 3.55m;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
