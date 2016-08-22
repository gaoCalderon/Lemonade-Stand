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

        public void useRecipeMakePitcher()
        {
            l.useLemon();
            s.useSugar();
        }

        public void showRecipe()
        {
            Console.WriteLine("Price & Quality of Lemonade Stand");
            Console.WriteLine("set cup charge: {0}", Cups.cupCost);
            Console.WriteLine("Lemons per Pictcher: {0}", l.getLemonPerPitcher());
            Console.WriteLine("Sugar cup per picture: {0}", s.getSugarPerPitcher());
            Console.WriteLine("Ice Cube per cup: {0}", Ice.IceRecipiCount);
        }

        public void defaultRecipe()
        {
            Console.WriteLine("Price & Quality of Lemonade Stand");
            Console.WriteLine("set cup charge: $0.25");
            Console.WriteLine("Lemons per Pitcher: 4");
            Console.WriteLine("Sugar cup per pitcher: 2");
            Console.WriteLine("Ice Cube per cup: 10");
            setDefaultRecipe();
        }

        public void setDefaultRecipe()
        {
            // insert math here of defaultCupCharge X random # of customers that actually purchased a cup in day
            defaultUseLemon();
            defaultUseSugar();
            // insert math here of defaultUseIce X # of cups actually sold
        }

        public void defaultCupCharge()
        {
            totalMoney += 0.25;
        }

        public void defaultUseLemon()
        {
            lemons -= 4;
        }

        public void defaultUseSugar()
        {
            sugar -= 2;
        }

        public void defaultUseIce()
        {
            iceCubes -= 10;
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
            defaultRecipe();
            Console.WriteLine("How do you want to set your Price & Quality?");
            Console.WriteLine("Do you want to use the defualt settings above or make changes?");
            Console.WriteLine("Please type in one: keep /change [ENTER KEY]");
            keepChange();
        }

        public void keepChange()
        {
            choice = Console.ReadLine();
            if (choice == "keep")
            {
                setDefaultRecipe();
            }
            else if (choice == "change")
            {
                setChangeLemonRecipe();
            }
            else
            {
                Console.WriteLine("INVALID, Please type in either choice: keep / change [ENTER KEY]");
                keepChange();
            }
        }

        public void showInventory()
        {
            Player person = new Player();
            Console.WriteLine("{0} currently have ${1} avaialbe", Player.name, Inventory.totalMoney);
            Console.WriteLine("{0} number of Cups", getCups());
            Console.WriteLine("{0} number of Lemons", getLemons());
            Console.WriteLine("{0} number cups of Sugar", getSugar());
            Console.WriteLine("{0} number of Ice Cubes", getIceCubes());
            Console.WriteLine("[ENTER]");
            Console.Read();
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
                Console.WriteLine("e.)done buying / f.) get weather prediction / g.)exit [ENTER KEY]");
                addInventory();
            }
            else if (choice == "no")
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
            string buyItem = Console.ReadLine();
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
                    Console.WriteLine("Begin Day {0}", d.day);
                    break;
                case "f":
                    w.getPrdictWeather();
                    Console.WriteLine("[ENTER]");
                    Console.ReadLine();
                    shopping.noMoreBuying();
                    break;
                case "g":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("INVALID - choices are: cups, lemons, sugar, ice, bankrupt, help");
                    break;
            }
        }
    }
}
