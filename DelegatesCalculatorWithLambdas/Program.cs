using DelegateCalculator;
using System;

namespace DelegatesCalculatorWithLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            CalculatorOperation operation;

            number1 = GetNumberFromUser("Enter number 1: ");
            operation = GetOperationFromUser();
            number2 = GetNumberFromUser("Enter number 2:");

            double result = operation.OperationDelegate(number1, number2);

            Console.WriteLine($"{number1} {operation.DisplayText} {number2} = {result}");
        }

        static double GetNumberFromUser(string prompt)
        {
            string userEnteredString;
            double number;
            while (true)
            {
                Console.Write(prompt + " ");

                userEnteredString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userEnteredString) && double.TryParse(userEnteredString, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please specify a valid number");
                }
            }
        }

        static CalculatorOperation GetOperationFromUser()
        {
            string userEnteredString;
            while (true)
            {
                Console.WriteLine("Enter what you want to do with the number (+,-,*,/)");

                userEnteredString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userEnteredString))
                {
                    switch (userEnteredString)
                    {
                        case "+":
                            return new CalculatorOperation(userEnteredString, (a,b) => a + b);
                        case "-":
                            return new CalculatorOperation(userEnteredString, (a, b) => a - b);
                        case "*":
                            return new CalculatorOperation(userEnteredString, (a, b) => a * b);
                        case "/":
                            return new CalculatorOperation(userEnteredString, (a, b) => a / b);
                    }
                }
                Console.WriteLine("Please specify a valid operation (+,-,*,/)");
            }
        }

    }
}
