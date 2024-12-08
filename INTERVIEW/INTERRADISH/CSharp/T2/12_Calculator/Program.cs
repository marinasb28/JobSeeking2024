using System;

namespace T2
{
    public static class Calculator
    {
        public static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Enter a number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("What operation do you want to perform? (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = Calculadora(num1, num2, op);

            Console.WriteLine($"Result of {num1} {op} {num2} is: {result}");
        }

        static double Calculadora(double n1, double n2, string op)
        {
            if (op == "+")
            {
                return n1 + n2;
            }
            else if (op == "-")
            {
                return n1 - n2;
            }
            else if (op == "*")
            {
                return n1 * n2;
            }
            else if (op == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return double.NaN;
                }
                return n1 / n2;
            }
            else
            {
                Console.WriteLine("Error: Invalid operator.");
                return double.NaN;
            }
        }
    }
}