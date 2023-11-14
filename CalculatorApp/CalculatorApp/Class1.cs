// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CalculatorApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            String operation;

            Boolean startAgain = true;
            String result;

            Console.WriteLine("Hello, welcome to the calculator program!");


            while (startAgain)
            {
                result = "";

                Console.WriteLine("Please enter your first value:");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter your second value:");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("What operation would you like to carry out? \n A for Addition \n S for Subtraction \n M for Multiplication \n D for Division");
                operation = Console.ReadLine();
                operation = operation.ToUpper();


                if (operation == "A")
                {
                    double addition = num1 + num2;

                    Console.WriteLine("First Value: " + num1);
                    Console.WriteLine("Second Value: " + num2);
                    Console.WriteLine("Operation Value: " + operation);
                    Console.WriteLine("Added Value = " + addition);

                    Console.WriteLine("Would you like to perform a new calculation? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "S")
                {
                    double subtraction = num1 - num2;

                    Console.WriteLine("First Value: " + num1);
                    Console.WriteLine("Second Value: " + num2);
                    Console.WriteLine("Operation Value: " + operation);
                    Console.WriteLine("Subtracted Value = " + subtraction);

                    Console.WriteLine("Would you like to perform a new calculation? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "M")
                {
                    double multiplication = num1 * num2;

                    Console.WriteLine("First Value: " + num1);
                    Console.WriteLine("Second Value: " + num2);
                    Console.WriteLine("Operation Value: " + operation);
                    Console.WriteLine("Multiplied Value = " + multiplication);

                    Console.WriteLine("Would you like to perform a new calculation? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                else if (operation == "D" && num2 == 0)
                {
                    double division = num1 / num2;

                    Console.WriteLine("First Value: " + num1);
                    Console.WriteLine("Second Value: " + num2);
                    Console.WriteLine("Operation Value: " + operation);
                    Console.WriteLine(float.NaN + " - Cannot Divide by 0");

                    Console.WriteLine("Would you like to perform a new calculation? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }


                else if (operation == "D")
                {
                    double division = num1 / num2;

                    Console.WriteLine("First Value: " + num1);
                    Console.WriteLine("Second Value: " + num2);
                    Console.WriteLine("Operation Value: " + operation);
                    Console.WriteLine("Divided Value = " + Math.Round(division, 3));

                    Console.WriteLine("Would you like to perform a new calculation? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }


                else
                {
                    Console.WriteLine("You have entered an invalid operator. Would you like to start again? Y / N");
                    result = Console.ReadLine();
                    result = result.ToUpper();
                }

                if (result == "Y")
                {
                    startAgain = true;
                }

                else
                {
                    startAgain = false;
                }

            }

            Console.WriteLine("END OF CALCULATION");

            Console.ReadKey();
        }
    }
}