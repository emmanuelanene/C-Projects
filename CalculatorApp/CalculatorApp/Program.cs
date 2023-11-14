using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            String operation;
            Boolean newCalculation = true;

            Console.WriteLine("Welcome to My Calculator App");


            while (newCalculation)
            {
                String result = "";

                Console.WriteLine("Please enter your first value: ");
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your first value: ");
                num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("What operation would you like to carry out? \n A for Addition \n S for Subtraction \n D for Division \n M for Multiplication");
                operation = Console.ReadLine();
                operation = operation.ToUpper();

                if (operation == "A")
                {
                    float addition = num1 + num2;
                    Console.WriteLine("Added Value: " + addition);

                    Console.WriteLine("Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "S")
                {
                    float subtraction = num1 - num2;
                    Console.WriteLine("Subtracted Value: " + subtraction);

                    Console.WriteLine("Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "D" && num2 == 0)
                {
                    float division = num1 / num2;
                    Console.WriteLine(float.NaN + " - Cannot divide by 0");

                    Console.WriteLine("Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "D")
                {
                    float division = num1 / num2;
                    Console.WriteLine("Division Value: " + division);

                    Console.WriteLine("Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "M")
                {
                    float multiply = num1 * num2;
                    Console.WriteLine("Multiplied Value: " + multiply);

                    Console.WriteLine("Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else
                {
                    Console.WriteLine("Please enter a valid operator. Would you like to perform a new calculation? Y/N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }


                if (result == "Y")
                {
                    newCalculation = true;
                }

                else
                {
                    newCalculation = false;
                }
            }

            Console.WriteLine("End of Calculation. Please Restart console to perform a new calculation.");
            



            Console.ReadKey();
        }
    }
}