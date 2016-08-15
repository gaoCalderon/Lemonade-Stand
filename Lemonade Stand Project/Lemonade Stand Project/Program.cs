using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.runGame();
            Console.WriteLine("End Game");
            Console.ReadLine();
        }
    }
}
