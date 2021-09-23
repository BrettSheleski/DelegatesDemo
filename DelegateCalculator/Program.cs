using System;

namespace DelegateCalculator
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
                            return new CalculatorOperation(userEnteredString, Add);
                        case "-":
                            return new CalculatorOperation(userEnteredString, Subtract);
                        case "*":
                            return new CalculatorOperation(userEnteredString, Multiply);
                        case "/":
                            return new CalculatorOperation(userEnteredString, Divide);
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

    class CalculatorOperation
    {
        public CalculatorOperation(string displayText, Func<double, double, double> operationDelegate)
        {
            DisplayText = displayText;
            OperationDelegate = operationDelegate;
        }

        public string DisplayText { get;  }
        public Func<double, double, double> OperationDelegate { get; }
    }
}
