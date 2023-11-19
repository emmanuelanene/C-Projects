using System;

namespace RockPaperScissorsApp
{
    class Program
    {        
        static void Main(string[] args) 
        {
            String playerName;
            String value2 = "PAPER";
            String value3 = "SCISSORS";
            Random randoms = new Random();
            String[] compChoice = { "ROCK", "PAPER", "SCISSORS" };
            String compChoices;

            String playerChoice;
            bool playAgain = true;

            String playerplayAgain;


            Console.WriteLine("Please Enter your name: ");
            playerName = Console.ReadLine();

            while (playAgain) 
            {
                playerplayAgain = "";

                

                Console.WriteLine("Pick a value among ROCK, PAPER or SCISSORS: ");
                playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToUpper();

                compChoices = compChoice[randoms.Next(compChoice.Length)];

                if (playerChoice == compChoices)
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("It's a Draw");
                }

                else if (playerChoice == "ROCK" && compChoices == "SCISSORS") 
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is: " + playerName);
                }

                else if (playerChoice == "ROCK" && compChoices == "PAPER")
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is the Computer");
                }

                else if (playerChoice == "SCISSORS" && compChoices == "ROCK")
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is the Computer");
                }

                else if (playerChoice == "PAPER" && compChoices == "ROCK")
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is: " + playerName);
                }

                else if (playerChoice == "SCISSORS" && compChoices == "PAPER")
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is: " + playerName);
                }

                else if (playerChoice == "PAPER" && compChoices == "SCISSORS")
                {
                    Console.WriteLine("Computer Choice: " + compChoices);
                    Console.WriteLine("Your Choice: " + playerChoice);
                    Console.WriteLine("The winner is the Computer");
                }

                Console.WriteLine("Would you like to play again? (Y/N)");
                playerplayAgain = Console.ReadLine();
                playerplayAgain = playerplayAgain.ToUpper();
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}