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
            if (getMoney() > 0.75)
            {
                iceCubes += 100;
                money -= 0.75;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy250iceCube()
        {
            if (getMoney() > 2.00)
            {
                iceCubes += 250;
                money -= 2.00;
            }
            else
            {
                moneyNotEnough();
            }
        }

        public void buy500iceCubes()
        {
            if (getMoney() > 3.55)
            {
                iceCubes += 500;
                money -= 3.55;
            }
            else
            {
                moneyNotEnough();
            }
        }
    }
}
