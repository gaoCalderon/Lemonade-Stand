﻿using System;
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

                    }
                    //create a method to be called inside here {}
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
                    //repeat 7days
                    //create a method for two players to be called inside here {}
                    break;
                case "14":
                    //repeat 14days
                    //use that method created for inside here{}
                    break;

                case "21":
                    //repeat 21days
                    //use that method created for inside here{}
                    break;
                case "28":
                    //repeat 28days
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
                    //repeat 7days
                    //create a method for human & ai players to be called inside here {}
                    break;
                case "14":
                    //repeat 14days
                    //use that method created for inside here{}
                    break;

                case "21":
                    //repeat 21days
                    //use that method created for inside here{}
                    break;
                case "28":
                    //repeat 28days
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
