using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int min = 1;
            int max = 10;
            int compGuess;
            int guessed;

            bool playAgain = true;
            bool newer = true;

            Console.WriteLine("Welcome to the number guessing game");
            Console.WriteLine("A number between 1 and 10 will be generated");

            Console.WriteLine("If you guess the correct number, you win!");


            while (playAgain)
            {
                compGuess = random.Next(min, max + 1);
                guessed = 0;

                while (guessed != compGuess)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Please enter your Guess: ");
                    guessed = Convert.ToInt32(Console.ReadLine());



                    if (guessed > compGuess)
                    {
                        Console.WriteLine("Your guess: " + guessed);
                        Console.WriteLine("Your guess is a bit too high. Guess Again :)");
                    }

                    else if (guessed < compGuess)
                    {
                        Console.WriteLine("Your guess: " + guessed);
                        Console.WriteLine("Your guess is a bit too low. Guess Again :)");
                    }

                    else if (guessed == compGuess)
                    {
                        Console.WriteLine("Your guess: " + guessed);
                        Console.WriteLine("Computer guess: " + compGuess);
                        Console.WriteLine("You guessed correctly!! Would you like to play again? Y/N");

                        string result = Console.ReadLine();
                        result = result.ToUpper();

                        if (result == "Y")
                        {
                            playAgain = true;
                        }

                        else
                        {
                            playAgain = false;
                        }
                    }
                }
                


            }

            Console.WriteLine("Thanks for playing!!");


            Console.ReadKey();
        }
    }
}