using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            string operation;

            number1 = GetNumberFromUser("Enter number 1: ");
            operation = GetOperationFromUser();
            number2 = GetNumberFromUser("Enter number 2:");

            double result = 0;

            switch (operation)
            {
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "+":
                    result = Add(number1, number2);
                    break;
                case "/":
                    result = Divide(number1, number2);
                    break;
                case "-":
                    result = Subtract(number1, number2);
                    break;
            }

            Console.WriteLine($"{number1} {operation} {number2} = {result}");
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

        static string GetOperationFromUser()
        {
            string userEnteredString;
            while (true)
            {
                Console.WriteLine("Enter what you want to do with the number (+,-,*,/)");

                userEnteredString = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userEnteredString))
                {
                    if (userEnteredString == "*" ||
                        userEnteredString == "/" ||
                        userEnteredString == "+" ||
                        userEnteredString == "-")
                    {

                        return  userEnteredString;
                    }
                }


                Console.WriteLine("Please specify a valid operation (+,-,*,/)");
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
