﻿using System;
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
            int playerPosition = initialPosition;
            Console.WriteLine("Welcome To Snake Ladder Game!");
            while (playerPosition < finalPosition)
            {
                Random random = new Random();
                int DieNumber = random.Next(1, 7);
                Console.WriteLine("DieNumber : " + DieNumber);
                //UC4 Setting Options For the Game(NoPlay, Ladd);
                Random random1 = new Random();
                int playerOption = random1.Next(0, 3);
                const int SNAKE = 1;
                const int LADDER = 2;
                Console.WriteLine("PlayerOption : " + playerOption);
                if (playerOption == LADDER)
                {
                    playerPosition = playerPosition + DieNumber; // If ladder comes player position will be incremented;
                    if (playerPosition > finalPosition)
                    {
                        playerPosition = playerPosition - DieNumber;
                    }
                }
                else if (playerOption == SNAKE)
                {
                    playerPosition = playerPosition- DieNumber; // If Snake comes player position will be decremented;
                    if (playerPosition < initialPosition)
                    {
                        playerPosition = initialPosition;
                    }
                }
                else
                {
                    playerPosition = playerPosition;
                }
                Console.WriteLine("playerPosition : " + playerPosition);
            }
            Console.WriteLine("Player Final Position : " + playerPosition);
        }
    }
}
