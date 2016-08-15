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

        public Days()
        {
            this.day = 1;
            this.numberOfDays = 7;
            this.twoWeeks = 14;
            this.threeWeeks = 21;
            this.fourthWeeks = 28;

        }

        public void LengthOfDays()
        {
            while (this.day < this.numberOfDays)
            {
                Console.WriteLine("Day {0}", this.day);
                //insert cycle of game play here (will repeat for 7days)
            }
        }


        public string days()
        {
            Console.WriteLine("How many number of days do you want to sale lemonade? 7, 14, 21 or 28 days?");
            string userchoice = Console.ReadLine();
            if (userchoice == "7")
            {
                LengthOfDays();
            }
             else if (userchoice == "14")
            {
                while (this.day < this.twoWeeks)
                {
                    Console.WriteLine("Day {0}", this.day);
                    //insert cycle of game play here (will repeat for 7days)
                }
            }
            else if (userchoice == "21")
            {
                while (this.day < this.threeWeeks)
                {
                    Console.WriteLine("Day {0}", this.day);
                    //insert cycle of game play here (will repeat for 7days)
                }
            }
            else if (userchoice == "28")
            {
                while (this.day < this.fourthWeeks)
                {
                    Console.WriteLine("Day {0}", this.day);
                    //insert cycle of game play here (will repeat for 7days)
                }
            }
            else
            {
                Console.WriteLine("Please type: 7, 14, 21, 28 [ENTER]");
                days();
            }
        }
       
        
      }
}
