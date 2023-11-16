using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Welcome to the CURRENCY & TEMPERATURE converter app");
                Console.WriteLine("Welcome! Please enter 'C' to use the currency converter or anything else to use the temperature converter");
                string converter = Console.ReadLine();
                converter = converter.ToUpper();

                if (converter == "C")
                {
                    Console.WriteLine("You have selected the Currency Converter");
                    Console.WriteLine("Please enter 'A' to convert from Pounds or anything else to convert from Euros");
                    string poundToEuros = Console.ReadLine();
                    poundToEuros = poundToEuros.ToUpper();

                    if (poundToEuros == "A")
                    {
                        Console.WriteLine("Please enter your amount in British Pounds");
                        float poundValue = float.Parse(Console.ReadLine());

                        float convertedValue = poundValue * 1.16f;

                        Console.WriteLine(poundValue + " pounds in Euros is " + convertedValue);

                    }

                    else
                    {
                        Console.WriteLine("Please enter your amount in Euros");
                        float euroValue = float.Parse(Console.ReadLine());

                        float convertedValue = euroValue * 1.16f;

                        Console.WriteLine(euroValue + " Euros in Pounds is " + convertedValue);
                    }
                }

                else
                {
                    Console.WriteLine("You have selected the Temperature Converter");
                    Console.WriteLine("Please enter 'A' to convert from Celsius or anything else to convert from Farenheit");
                    string celsiusToFarenheit = Console.ReadLine();
                    celsiusToFarenheit = celsiusToFarenheit.ToUpper();

                    if (celsiusToFarenheit == "A")
                    {
                        Console.WriteLine("Please enter your temperature in Celsius");
                        float celsiusValue = float.Parse(Console.ReadLine());

                        float converteddValue = celsiusValue * 1.18f * 32f;

                        Console.WriteLine(celsiusValue + " degrees celsius in Farenheit is " + converteddValue);
                    }

                    else
                    {
                        Console.WriteLine("Please enter your temperature in Farenheit");
                        float farenheitValue = float.Parse(Console.ReadLine());

                        float converteddValue = (farenheitValue - 32f) / 1.8f;

                        Console.WriteLine(farenheitValue + " degrees Farenheit in Celsius is " + converteddValue);
                    }

                }

                Console.WriteLine("Would you like to play again? Y / N");
                string yorn = Console.ReadLine();
                yorn = yorn.ToUpper();

                if (yorn == "Y")
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
}

// €£