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
            //UC6
            int initialPosition = 0;
            int finalPosition = 100;
            int playerPosition = initialPosition;
            int DieCount = 0;
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while (playerPosition < finalPosition)
            {
                DieCount++;
                Random random = new Random();
                int DieNumber = random.Next(1, 7);
                Console.WriteLine("DieNumber : " + DieNumber);
                Random random1 = new Random();
                int playerOption = random1.Next(0, 4);
                const int SNAKE = 1;
                const int LADDER = 2;
                const int noPlay = 0;
                Console.WriteLine("PlayerOption : " + playerOption);
                if (playerOption == SNAKE)
                {
                    playerPosition = playerPosition - DieNumber; ;
                    if (playerPosition < initialPosition)
                    {
                        playerPosition = initialPosition;
                    }
                }
                else if (playerOption == LADDER)
                {
                    playerPosition = playerPosition + DieNumber; 
                    if (playerPosition > finalPosition) 
                    {
                        playerPosition = playerPosition - DieNumber; 
                    }
                }
                else
                {
                    playerPosition = playerPosition;
                }
                Console.WriteLine("playerPosition : " + playerPosition);
            }
            Console.WriteLine("DieCount : " + DieCount);
            Console.WriteLine("Player Final Position : " + playerPosition + " And Die Rolled For " + DieCount + " Times");
        }
    }
}
