using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and ladder program");
            //UC2
            int START_POSITION = 0;
            Console.WriteLine("Start position of player is: " + START_POSITION);
            Console.WriteLine("Roll a dice");
            Console.ReadLine();
            Random random = new Random();
            int countDiceRoll = random.Next(1, 7);
            Console.WriteLine(countDiceRoll);
            Console.ReadLine();
        }
    }
}
