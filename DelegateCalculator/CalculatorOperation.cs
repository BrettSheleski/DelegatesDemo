using System;

namespace DelegateCalculator
{
    public class CalculatorOperation
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
