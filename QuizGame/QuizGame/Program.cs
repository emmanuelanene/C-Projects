using System;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. What is the largest breed of domestic cat?");
            Console.WriteLine("a) Maine Coon \nb) Bengal \nc) Ragdoll");

            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "a")
            {
                Console.WriteLine("You Are Correct!!");
            }

            else
            {
                Console.WriteLine("Your answer is wrong");
            }



            Console.WriteLine("2. What is the term for involuntary kneading motion that cats often do with their paws?");
            Console.WriteLine("a) Purring \nb) Napping \nc) Kneading");

            string answer2 = Console.ReadLine();
            answer2 = answer2.ToLower();

            if (answer == "a")
            {
                Console.WriteLine("You Are Correct!!");
            }

            else
            {
                Console.WriteLine("Your answer is wrong");
            }
        }
    }
}