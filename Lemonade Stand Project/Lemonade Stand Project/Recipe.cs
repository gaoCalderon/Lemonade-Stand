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
        Customer cm = new Customer();

        public void showRecipe()
        {
            Console.WriteLine("Price & Quality of Lemonade Stand");
            Console.WriteLine("set cup charge: {0}", cp.getCupCharge());
            Console.WriteLine("Lemons per Pictcher: {0}", l.getLemonPerPitcher());
            Console.WriteLine("Sugar cup per picture: {0}", s.getSugarPerPitcher());
            Console.WriteLine("Ice Cube per cup: {0}", i.getIceCubePerCup());
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
            money += 0.25m;
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

        public void setChangeRecipe()
        {

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
            string choice = Console.ReadLine();
            if (choice == "keep")
            {
                setDefaultRecipe();
            }
            else if (choice == "change")
            {
                setChangeRecipe();
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
            Console.WriteLine("{0} currently have ${1} avaialbe", person.getName(), getMoney());
            Console.WriteLine("{0} number of Cups", getCups());
            Console.WriteLine("{0} number of Lemons", getLemons());
            Console.WriteLine("{0} number cups of Sugar", getSugar());
            Console.WriteLine("{0} number of Ice Cubes", getIceCubes());
        }

        public void stockInventory()
        {
            Console.WriteLine("Would you like to stock items in your inventory? Yes/No [ENTER]");
            Day day = new Day();
            string userchoice = Console.ReadLine();
            if (userchoice == "yes")
            {
                Console.WriteLine("What would you like to purchase?");
                Console.WriteLine("Type in a letter: a.) cups / b.) lemons / c) sugar / d.) ice");
                Console.WriteLine("Other Options: e.) bankrupt / f.) help / g.)exit [ENTER KEY]");
                addInventory();
            }
            else if (userchoice == "no")
            {
                Console.WriteLine("OK,");
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
                    //add link to end of game + results here
                    break;
                case "f":
                    //add link tips/rule page at introductory
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
