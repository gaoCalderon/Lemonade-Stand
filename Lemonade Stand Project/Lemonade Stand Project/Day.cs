using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Day
    {

        int day;
        int numberOfDays;
        int twoWeeks;
        int threeWeeks;
        int fourthWeeks;


        public Day()
        {
            this.day = 1;
            this.numberOfDays = 7;
            this.twoWeeks = 14;
            this.threeWeeks = 21;
            this.fourthWeeks = 28;

        }

        public void goToInventory()
        {
            Recipe goIntoInventory = new Recipe();
            goIntoInventory.showInventory();
            goIntoInventory.stockInventory();
        }

        Weather w = new Weather();

        public void choiceOfDays()  //not done yet
        {
            Inventory enterInventory = new Inventory();
            Console.WriteLine("Please type in how many number of days you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            string days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.numberOfDays)
                    {
                        w.weatherForecast();
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {
                        w.weatherForecast();
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {
                        w.weatherForecast();
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                case "28":
                    while (this.day < this.twoWeeks)
                    {
                        w.weatherForecast();
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    choiceOfDays();
                    break;
            }
        }
        
      }
}
