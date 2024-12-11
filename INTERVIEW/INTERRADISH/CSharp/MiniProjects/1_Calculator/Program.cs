
namespace MiniProjects
{
    class Calculator
    {
        static double suma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double resta(double n1, double n2)
        {
            return Math.Abs(n1 - n2);
        }

        static double mult(double n1, double n2)
        {
            return n1 * n2;
        }

        static double div(double n1, double n2)
        {
            if(n2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to THE CALCULATOR :)");
            
            bool valid = false;
            double num1 = 0, num2 = 0;
            while(!valid)
            {
                try{
                    Console.Write("Enter 1st number: ");
                    num1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter 2nd number: ");
                    num2 = double.Parse(Console.ReadLine());
                    valid = true;
                }catch (FormatException)
                {
                    Console.WriteLine("Invalid input, please enter a number!");
                }
            }

            Console.Write("\nChoose an operation (+, -, *, /): ");
            var opt = Console.ReadLine();

            switch(opt)
            {
                case "+":
                    Console.WriteLine($"Result: {suma(num1, num2)}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {resta(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {mult(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine("Cannot divide by zero.");
                    Console.WriteLine($"Result: {div(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }
    }
}