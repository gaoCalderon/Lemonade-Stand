using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Recipe : Inventory
    {
        Cups cp = new Cups();
        Lemons l = new Lemons();
        Sugar s = new Sugar();
        Ice i = new Ice();

        string choice;
        string buyItem;

        public void useRecipeMakePitcher()
        {
            l.useLemon();
            s.useSugar();
        }

        public void showRecipe()
        {
            Console.WriteLine("Price & Quality of Lemonade Stand");
            Console.WriteLine("set cup charge: {0}", Cups.cupCost);
            Console.WriteLine("Lemons per Pictcher: {0}", Lemons.lemonRecipiCount);
            Console.WriteLine("Sugar cup per picture: {0}", Sugar.SugarRecipiCount);
            Console.WriteLine("Ice Cube per cup: {0}", Ice.IceRecipiCount);
        }

        public void aiDefaultRecipe()
        {
            Console.WriteLine("Price & Quality of Lemonade Stand");
            Console.WriteLine("set cup charge: $0.25");
            Console.WriteLine("Lemons per Pitcher: 4");
            Console.WriteLine("Sugar cup per pitcher: 2");
            Console.WriteLine("Ice Cube per cup: 10");
        }


        public void aiDefaultCupCharge()
        {
            aiTotalMoney += 0.25;
        }

        public void aiDefaultUseRecipe()
        {
            aiLemons -= 4;
            aiSugar -= 2;
        }

        public void aiDefaultUseIce()
        {
            aiIceCubes -= 10;
        }

        public void setChangeLemonRecipe()
        {
            l.askNumberOfLemons();
            l.setNumberOfLemons();
        }

        public void setChangeSugarRecipe()
        {
            s.askCupOfSugar();
            s.setCupsOfSugar();
        }

        public void setChangeIceRecipe()
        {
            i.askNumberofCubes();
            i.setNumberCubesToCup();
        }

        public void setChangeCupCharges()
        {
            cp.askCupCharge();
            cp.setCupCharge();
        }

        public void playerSetRecipe()
        {
            Console.WriteLine("Please set Price & Quality?");
            setChangeCupCharges();
            setChangeLemonRecipe();
            setChangeSugarRecipe();
            setChangeIceRecipe();
        }

        public void showInventory()
        {
            Player person = new Player();
            Console.WriteLine("{0} currently have ${1} avaialbe", Player.name, Inventory.totalMoney);
            Console.WriteLine("{0} number of Cups", Inventory.cups);
            Console.WriteLine("{0} number of Lemons", Inventory.lemons);
            Console.WriteLine("{0} number cups of Sugar", Inventory.sugar);
            Console.WriteLine("{0} number of Ice Cubes", Inventory.iceCubes);
            Console.WriteLine("[ENTER]");
            Console.Read();
        }

        public void aiShowInventory()
        {
            Player person = new Player();
            Console.WriteLine("{0} currently have ${1} avaialbe", Player.aiName, Inventory.aiTotalMoney);
            Console.WriteLine("{0} number of Cups", Inventory.aiCups);
            Console.WriteLine("{0} number of Lemons", Inventory.aiLemons);
            Console.WriteLine("{0} number cups of Sugar", Inventory.aiSugar);
            Console.WriteLine("{0} number of Ice Cubes", Inventory.aiIceCubes);
            Console.WriteLine("[ENTER]");
            Console.Read();
        }

        public void aiStockInventory()
        {
            aiCups += 100;
            aiTotalMoney -= 2.80;
            aiLemons += 75;
            aiTotalMoney -= 3.75;
            aiSugar += 48;
            aiTotalMoney -= 4.32;
            aiIceCubes += 100;
            aiTotalMoney -= 0.75;
            aiIceCubes += 100;
            aiTotalMoney -= 0.75;
            aiIceCubes += 100;
            aiTotalMoney -= 0.75;
        }

        public void stockInventory()
        {
            Day day = new Day();
            Console.WriteLine("Would you like to stock items in your inventory? Yes/No [ENTER]");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                Console.WriteLine("What would you like to purchase?");
                Console.WriteLine("Type in a letter: a.) cups / b.) lemons / c) sugar / d.) ice");
                Console.WriteLine("Other Options:");
                Console.WriteLine("e.)done buying / f.)exit [ENTER KEY]");
                addInventory();
            }
            else if (choice == "y")
            {
                Console.WriteLine("What would you like to purchase?");
                Console.WriteLine("Type in a letter: a.) cups / b.) lemons / c) sugar / d.) ice");
                Console.WriteLine("Other Options:");
                Console.WriteLine("e.)done buying / f.)exit [ENTER KEY]");
                addInventory();
            }
            else if (choice == "no")
            {
                Console.WriteLine("[ENTER]");
                Console.Read();
                showInventory();
            }
            else if (choice == "n")
            {
                Console.WriteLine("[ENTER]");
                Console.Read();
                showInventory();
            }
            else
            {
                Console.WriteLine("yes/no [ENTER KEY]");
                stockInventory();
            }
        }

        public void addInventory()
        {
            buyItem = Console.ReadLine();
            Store shopping = new Store();
            Weather w = new Weather();
            Day d = new Day();

            switch (buyItem)
            {
                case "a":
                    shopping.purchaseCups();
                    break;
                case "b":
                    shopping.purchaseLemons();
                    break;
                case "c":
                    shopping.purchaseSugar();
                    break;
                case "d":
                    shopping.purchaseIceCubes();
                    break;
                case "e":
                    aiStockInventory();
                    playerSetRecipe();
                    break;
                case "f":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("INVALID - choices are: cups, lemons, sugar, ice, bankrupt, help");
                    addInventory();
                    break;
            }
        }
    }
}
