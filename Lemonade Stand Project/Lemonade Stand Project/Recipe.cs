using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Recipe : Inventory
    {


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
