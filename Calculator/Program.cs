using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            double result;

            CSharpCalculator.Calculator calculator;

            calculator = new CSharpCalculator.Calculator();

            result = calculator.Add(a, b);
            Console.WriteLine(result);

            result = calculator.Divide(a, b);
            Console.WriteLine(result);

            result = calculator.Multiply(a, b);
            Console.WriteLine(result);
        }
    }
}
