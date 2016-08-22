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
        string days;



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
            w.setPredictWeather();
            Console.WriteLine("[ENTER]");
            Console.Read();
            goToInventory();
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("Begin Day {0}", this.day);
            w.setweatherForecast();
            s.setNumberOFCustomersPerDay();
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("{0}'s stand sold lemonade for 6 hours.", Player.name);
            Console.WriteLine("{0} possible customers past {1}'s Lemondade Stand.", Stand.recordTotalCustomers, Player.name);
            Console.WriteLine("[ENTER]");
            Console.Read();
            cus.customerAtLemonadeStand();
            Console.WriteLine("{0} cups of Lemonade were sold today.", Cups.recordCupsSold);
            Console.WriteLine("{0} made ${1} today.", Player.name, Inventory.madeMoney);
            Console.WriteLine("[ENTER]");
            Console.Read();
            i.addTotalMoneyMade();
            i.runAfterAddTotalMoneyMade();
            Console.WriteLine("{0} money total at the end of the day is ${1}", Player.name, Inventory.totalMoney);
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("All your ice melted at the end of the day.");
            ice.endDayNoIceCubes();
            Console.WriteLine("[ENTER]");
            Console.Read();
        } 

        public void singleDayPath()
        {
            Console.WriteLine("Please type in how many number of days you would like to sale lemonade for?");
            Console.WriteLine("Between: 7, 14, 21 or 28 days? [ENTER]");
            days = Console.ReadLine();

            switch (days)
            {
                case "7":
                    while (this.day < this.week)
                    {
                        plugInDayCycle();
                    }
                    double number = Inventory.totalMoney;
                    if (number >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number1 = Inventory.totalMoney;
                    if (number1 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number2 = Inventory.totalMoney;
                    if (number2 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    break;
                case "28":
                    while (this.day < this.fourthWeeks)
                    {
                        plugInDayCycle();
                    }
                    double number3 = Inventory.totalMoney;
                    if (number3 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    singleDayPath();
                    break;
            }
        }

        public void plugInHumanAiDayCycle()
        {
            w.setPredictWeather();
            Console.WriteLine("[ENTER]");
            Console.Read();
            goToInventory();
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("Begin Day {0}", this.day);
            w.setweatherForecast();
            s.setNumberOFCustomersPerDay();
            s.setAiNumberOFCustomersPerDay();
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("{0}'s stand sold lemonade for 6 hours.", Player.name);
            Console.WriteLine("{0}'s stand also sold Lemonade for 6 hours", Player.aiName);
            Console.WriteLine("{0} possible customers past {1}'s Lemondade Stand.", Stand.recordTotalCustomers, Player.name);
            Console.WriteLine("{0} possible customers past {1}'s Lemondade Stand.", Stand.aiRecordTotalCustomers, Player.aiName);
            Console.WriteLine("[ENTER]");
            Console.ReadLine();
            cus.customerAtLemonadeStand();
            cus.aiCustomerAtLemonadeStand();
            Console.WriteLine("{0} cups of {1} Lemonade were sold today.", Cups.recordCupsSold, Player.name);
            Console.WriteLine("{0} cups of {1} Lemonade were sold today.", Cups.aiRecordCupsSold, Player.aiName);
            Console.WriteLine("{0} made ${1} today.", Player.name, Inventory.madeMoney);
            Console.WriteLine("{0} made ${1} today.", Player.aiName, Inventory.aiMadeMoney);
            Console.WriteLine("[ENTER]");
            Console.Read();
            i.addTotalMoneyMade();
            i.aiAddTotalMoneyMade();
            i.runAfterAddTotalMoneyMade();
            i.aiRunAfterAddTotalMoneyMade();
            Console.WriteLine("{0} money total at the end of the day is ${1}", Player.name, Inventory.totalMoney);
            Console.WriteLine("{0} money total at the end of the day is ${1}", Player.aiName, Inventory.aiTotalMoney);
            Console.WriteLine("[ENTER]");
            Console.Read();
            Console.WriteLine("All the ice melted at the end of the day.");
            ice.endDayNoIceCubes();
            ice.aiEndDayNoIceCubes();
            Console.WriteLine("[ENTER]");
            Console.Read();
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
                        plugInHumanAiDayCycle();
                    }
                    double ab = Inventory.totalMoney;
                    if (ab >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 7 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    double abc = Inventory.aiTotalMoney;
                    if (abc >= 20)
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 7 days, {0} profited ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    else
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 7 days, {0} lost ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    double abcd = Inventory.testAddMoney;
                    if (abcd > Inventory.aiTestAddMoney)
                    {
                        i.humanMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.name, Player.aiName, Inventory.humanScore);
                    }
                    else if (abcd < Inventory.aiTestAddMoney)
                    {
                        i.computerMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.aiName, Player.name, Inventory.computerScore);
                    }
                    else
                    {
                        Console.WriteLine("Tie Game, both {0} and {1} made equally the same amount.", Player.name, Player.aiName);
                    }
                    break;
                case "14":
                    while (this.day < this.twoWeeks)
                    {
                        plugInHumanAiDayCycle();
                    }
                    double ab1 = Inventory.totalMoney;
                    if (ab1 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 14 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    double abc1 = Inventory.aiTotalMoney;
                    if (abc1 >= 20)
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 14 days, {0} profited ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    else
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 14 days, {0} lost ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    double abcd1 = Inventory.testAddMoney;
                    if (abcd1 > Inventory.aiTestAddMoney)
                    {
                        i.humanMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.name, Player.aiName, Inventory.humanScore);
                    }
                    else if (abcd1 < Inventory.aiTestAddMoney)
                    {
                        i.computerMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.aiName, Player.name, Inventory.computerScore);
                    }
                    else
                    {
                        Console.WriteLine("Tie Game, both {0} and {1} made equally the same amount.", Player.name, Player.aiName);
                    }
                    break;

                case "21":
                    while (this.day < this.threeWeeks)
                    {
                        plugInHumanAiDayCycle();
                    }
                    double ab2 = Inventory.totalMoney;
                    if (ab2 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 21 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    double abc2 = Inventory.aiTotalMoney;
                    if (abc2 >= 20)
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 21 days, {0} profited ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    else
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 21 days, {0} lost ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    double abcd2 = Inventory.testAddMoney;
                    if (abcd2 > Inventory.aiTestAddMoney)
                    {
                        i.humanMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.name, Player.aiName, Inventory.humanScore);
                    }
                    else if (abcd2 < Inventory.aiTestAddMoney)
                    {
                        i.computerMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.aiName, Player.name, Inventory.computerScore);
                    }
                    else
                    {
                        Console.WriteLine("Tie Game, both {0} and {1} made equally the same amount.", Player.name, Player.aiName);
                    }
                    break;
                case "28":
                    while (this.day < this.fourthWeeks)
                    {
                        plugInHumanAiDayCycle();
                    }
                    double ab3 = Inventory.totalMoney;
                    if (ab3 >= 20)
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} profited ${1}", Player.name, Inventory.testAddMoney);
                    }
                    else
                    {
                        i.profit();
                        Console.WriteLine("At the end of 28 days, {0} lost ${1}", Player.name, Inventory.testAddMoney);
                    }
                    double abc3 = Inventory.aiTotalMoney;
                    if (abc3 >= 20)
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 28 days, {0} profited ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    else
                    {
                        i.aiProfit();
                        Console.WriteLine("At the end of 28 days, {0} lost ${1}", Player.aiName, Inventory.aiTestAddMoney);
                    }
                    double abcd3 = Inventory.testAddMoney;
                    if (abcd3 > Inventory.aiTestAddMoney)
                    {
                        i.humanMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.name, Player.aiName, Inventory.humanScore);
                    }
                    else if (abcd3 < Inventory.aiTestAddMoney)
                    {
                        i.computerMore();
                        Console.WriteLine("{0} made more than {1} by ${2}", Player.aiName, Player.name, Inventory.computerScore);
                    }
                    else
                    {
                        Console.WriteLine("Tie Game, both {0} and {1} made equally the same amount.", Player.name, Player.aiName);
                    }
                    break;
                default:
                    Console.WriteLine("INVALID, please input either: 7, 14, 21, or 28");
                    singleDayPath();
                    break;
            }
        }
    }
}
