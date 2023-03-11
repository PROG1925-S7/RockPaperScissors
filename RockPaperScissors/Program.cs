/*  RockPaperScissors
 *  A RPS game. You vs. the computer.
 *  
 *  Revision History:
 *     Tony Theo... 2023.03.11:   Created
 *     
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int playerScore = 0;
            int cpuScore = 0;
            int playerChoice, cpuChoice;
            string playAgain;

            Random randGen = new Random();

            do
            {
                Console.Clear();
                Console.WriteLine($"Player: {playerScore}   CPU: {cpuScore}");
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");

                Console.WriteLine("Please select an option");
                playerChoice = Convert.ToInt16(Console.ReadLine());

                cpuChoice = randGen.Next(1, 4);
                Console.WriteLine($"Computer picked: {cpuChoice}");

                if (playerChoice == cpuChoice)
                {
                    Console.WriteLine("It's a tie. Play again (y/n)?");
                }
                else if ((playerChoice == 1 && cpuChoice == 3) ||
                         (playerChoice == 2 && cpuChoice == 1) ||
                         (playerChoice == 3 && cpuChoice == 2))
                {
                    playerScore++;
                    Console.WriteLine("You win. Play again? (y/n)");
                }
                else
                {
                    cpuScore++;
                    Console.WriteLine("You lose. Play again? (y/n)");
                }

                playAgain = Console.ReadLine();
            }
            while (playAgain == "y");

            Console.ReadKey();
        }
    }
}

