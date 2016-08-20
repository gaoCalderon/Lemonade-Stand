using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Day
    {

        public int day;
        public int week;
        public int twoWeeks;
        public int threeWeeks;
        public int fourthWeeks;


        public Day()
        {
            this.day = 1;
            this.week = 7;
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
        Stand s = new Stand();
        Player p = new Player();
        Cups c = new Cups();
        Inventory i = new Inventory();
        Ice ice = new Ice();
        Consumer cus = new Consumer("LemonadeStand", 82, 1, 0.25);

        public void plugInDayCycle()
        {
            w.weatherForecast();
            goToInventory();
            w.realDayForecast();
            w.realDayTemperature();
            s.setNumberOFCustomersPerDay();
            Console.WriteLine("{0}'s stand sold lemonade for 6 hours.", p.getName());
            Console.WriteLine("{0} possible customers past {1}'s Lemondade Stand.", s.getTotalNumberOfCustomers(), p.getName());
            cus.customerAtLemonadeStand();
            Console.WriteLine("{0} cups of Lemonade were sold today.", c.getCupsSold());
            Console.WriteLine("{0} made ${1} today.", p.getName(), i.getMadeMoney());
            i.addTotalMoneyMade();
            i.runAfterAddTotalMoneyMade();
            Console.WriteLine("{0} money total at the end of the day is ${1}", p.getName(), i.getTotalMoney());
            Console.WriteLine("All your ice melted at the end of the day.");
            ice.endDayNoIceCubes();
        } 

        public void singleDayPath()  //not done yet
        {
            Console.WriteLine("Please type in how many number of days you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            string days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.week)
                    {
                        plugInDayCycle();
                    }
                    double number = i.totalMoney;
                    if (number >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} profited ${1}", p.getName(), i.getTestAddMoney());
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} lost ${1}", p.getName(), i.getTestAddMoney());
                    }
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number1 = i.totalMoney;
                    if (number1 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} profited ${1}", p.getName(), i.getTestAddMoney());
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} lost ${1}", p.getName(), i.getTestAddMoney());
                    }
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number2 = i.totalMoney;
                    if (number2 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} profited ${1}", p.getName(), i.getTestAddMoney());
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} lost ${1}", p.getName(), i.getTestAddMoney());
                    }
                    break;
                case "28":
                    while (this.day < this.fourthWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number3 = i.totalMoney;
                    if (number3 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} profited ${1}", p.getName(), i.getTestAddMoney());
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} lost ${1}", p.getName(), i.getTestAddMoney());
                    }
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    singleDayPath();
                    break;
            }
        }

        public void doubleDayPay()
        {
            Inventory enterInventory = new Inventory();
            Player player = new Player();
            Console.WriteLine("Please type in how many number of days you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            string days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.week)
                    {

                    }
                    //create a method for two players to be called inside here {}
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;
                case "28":
                    while (this.day < this.fourthWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    singleDayPath();
                    break;
            }

        }

        public void humanAiDayPath()
        {
            Inventory enterInventory = new Inventory();
            Player player = new Player();
            Console.WriteLine("Please type in how many number of days you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            string days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.week)
                    {

                    }
                    //create a method for human & ai players to be called inside here {}
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;
                case "28":
                    while (this.day < this.fourthWeeks)
                    {

                    }
                    //use that method created for inside here{}
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    singleDayPath();
                    break;
            }
        }
    }
}
