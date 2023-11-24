using System;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int recHeight;
            int recWidth;

            int circHeight;
            int circWidth;

            bool playAgain = true;
            string answer;



            while (playAgain)
            {
                Console.WriteLine("What shape would you like to find the area of?");
                Console.WriteLine("Please Enter 'r'  for Rectangle or any other key for Circle");

                string shape = Console.ReadLine();
                shape = shape.ToLower();

                if (shape == "r")
                {
                    Console.WriteLine("Please enter the Height of the rectangle");
                    recHeight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the Width of the rectangle");
                    recWidth = Convert.ToInt32(Console.ReadLine());

                    float areaOfRectangle = recHeight * recWidth;
                    Console.WriteLine("The area of the Rectangle is: " + areaOfRectangle);
                }

                else
                {
                    Console.WriteLine("Please enter the Height of the Circle");
                    circHeight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the Width of the Circle");
                    circWidth = Convert.ToInt32(Console.ReadLine());

                    float areaOfCircle = circHeight * circWidth;
                    Console.WriteLine("The area of the Circle is: " + areaOfCircle);

                    Console.WriteLine("Would you like to perform a new Calculation? Y/N");
                    answer = Console.ReadLine();
                    answer = answer.ToLower();

                    if (answer == "y")
                    {
                        playAgain = true;
                    }

                    else
                    {
                        playAgain = false;
                    }
                }
            }

            Console.WriteLine("Thanks for Playing!");
            

            Console.ReadKey();
        }
    }
}