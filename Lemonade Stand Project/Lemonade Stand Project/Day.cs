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

        Weather weather = new Weather();

        //List<Weather> weathers = new List<Weather>();

        //Weather weather = new Weather();
        //List<string> weathers = new List<string>();
        //weathers.Add("sunny");
        //weathers.Add("partly cloudy");
        //weathers.Add("partyly cloudy with rain");
        //weathers.Add("cloudy");
        //weathers.Add("cloudy with rain");
        //weathers.Add("rainy");

        public Day()
        {
            this.day = 1;
            this.numberOfDays = 7;
            this.twoWeeks = 14;
            this.threeWeeks = 21;
            this.fourthWeeks = 28;

        }

        public int GetDayTemperature()
        {
            weather.temperature = weather.setWarmTemperature();
            return weather.temperature;
        }
        public void goToInventory()
        {
            Inventory goIntoInventory = new Inventory();
            goIntoInventory.showInventory();
            goIntoInventory.stockInventory();
        }


        public void choiceOfDays()  //not done yet
        {
            Inventory enterInventory = new Inventory();
            Console.WriteLine("Please choose how many number of days that you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            string days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.numberOfDays)
                    {
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                case "28":
                    while (this.day < this.twoWeeks)
                    {
                        goToInventory();

                        //insert cycle of game play here (will repeat for 7days)
                    }
                    break;
                default:
                    Console.WriteLine("INVALID, please choose between 7, 14, 21, or 28");
                    choiceOfDays();
                    break;
            }
        }
        
      }
}
