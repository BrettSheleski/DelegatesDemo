using System;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            string userEnteredString;
            while (true)
            {
                Console.WriteLine("Enter Number 1: ");

                userEnteredString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userEnteredString) && double.TryParse(userEnteredString, out number1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please specify a valid number");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter Number 1: ");

                userEnteredString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userEnteredString) && double.TryParse(userEnteredString, out number2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please specify a valid number");
                }
            }


            Console.WriteLine($"Sum: {number1 + number2}");
        }
    }
}
