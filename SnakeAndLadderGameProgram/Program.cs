using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;



namespace SnakeAndLadderGameProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Game!");
            int initialPosition = 0;
            int finalPosition = 100;
            int playerPosition = initialPosition;
            Random random = new Random();
            int DieNumber = random.Next(1, 7);
            Console.WriteLine(DieNumber);
            //UC3 selecting the Options between no play/snake/ladder
            Random random1 = new Random();
            int playerOption = random1.Next(0, 3);
            const int SNAKE = 1;
            const int LADDER = 2;
            Console.WriteLine(playerOption);
            Console.WriteLine(playerPosition);
            if (playerOption == LADDER)
            {
                playerPosition = playerPosition+ DieNumber;
            }
            else if (playerOption == SNAKE)
            {
                playerPosition = playerPosition - DieNumber;
            }
            else
            {
                playerPosition = playerPosition;
            }
            Console.WriteLine(playerPosition);
        }
    }
}
