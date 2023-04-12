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
            //UC1 Initilizing initialPosition,finalPosition,playerInitialPosition
            int initialPosition = 0;
            int finalPosition = 100;
            int player1 = initialPosition;
            int player2 = initialPosition;
            int DieCount = 0;
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while ((player1 < finalPosition) && (player2 < finalPosition))
            {
                DieCount++;
                Random random1 = new Random();
                int DieNumber1 = random1.Next(1, 7);
                Console.WriteLine("DieNumber For Player1 :" + DieNumber1);//DieNumber For Player2
                Random random2 = new Random();
                int DieNumber2 = random2.Next(1, 7);
                Console.WriteLine("DieNumber For Player2 :" + DieNumber2);
                //UC3 Setting Options For the Game(NoPlay, Ladd);
                Random randomA = new Random();
                int playerOption1 = randomA.Next(0, 4);
                const int SNAKE = 1;
                const int LADDER = 2;
                const int noPlay = 0;
                Console.WriteLine("Player 1 : " + playerOption1);
                Random randomB = new Random();
                int playerOption2 = randomB.Next(0, 4);
                const int SNAKE1 = 1;
                const int LADDER1 = 2;
                const int noPlay1 = 0;
                Console.WriteLine("Player 2 : " + playerOption2);

                if (playerOption1 == LADDER)
                {
                    player1 += DieNumber1;
                    if (player1 > finalPosition)
                    {
                        player1 -= DieNumber1;
                    }
                }
                else if (playerOption1 == SNAKE)
                {
                    player1 -= DieNumber1; 
                    if (player1 < initialPosition)
                    {
                        player1 = initialPosition;
                    }
                }
                else if (playerOption1 == noPlay)
                {
                    player1 = player1;
                }
                else
                {
                    player1 += DieNumber1;
                    if (player1 > finalPosition) 
                    {
                        player1 -= DieNumber1; 
                    }
                }
 
                if (playerOption2 == LADDER1)
                {
                    player2 += DieNumber1;
                    if (player2 > finalPosition)
                    {
                        player2 -= DieNumber2;
                    }
                }
                else if (playerOption2 == SNAKE1)
                {
                    player2 -= DieNumber2; 
                    if (player2 < initialPosition) 
                    {
                        player2 = initialPosition;
                    }
                }
                else if (playerOption2 == noPlay1)
                {
                    player2 = player2;
                }
                else
                {
                    player2 += DieNumber2;
                    if (player2 > finalPosition) 
                    {
                        player2 -= DieNumber2;
                    }
                }                
                Console.WriteLine("player1: " + player1);
                Console.WriteLine("player2: " + player2);

            }
            Console.WriteLine("DieCount : " + DieCount); // This If condition finds the Winner among Two Players
            if (player1 == finalPosition)
            {
                Console.WriteLine("Winner is Player1 and Die count is " + DieCount + " Times");
            }
            else
            {
                Console.WriteLine("Winner is Player2 and die count is " + DieCount + " Times");
            }
        }
    }
}
