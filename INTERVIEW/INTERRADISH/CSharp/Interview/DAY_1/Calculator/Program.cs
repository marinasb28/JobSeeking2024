
namespace DAY1
{
    public class Calculator
    {
        static double addition(double x, double y)
        {
            return x + y;
        }
        static double subtraction(double x, double y)
        {
            return x - y;
        }
        static double multiplication(double x, double y)
        {
            return x * y;
        }
        static double division(double x, double y)
        {
            if(y == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            double num1 = 0,num2 = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.Write("Enter the first number:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number:");
                    num2 = double.Parse(Console.ReadLine());
                    valid = true;
                } catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers only.");
                }
            }
            

            string[] options = new string[]
            {
                "1) Addition",
                "2) Subtraction",
                "3) Multiplication",
                "4) Division"
            };

            Console.WriteLine("Choose an operation:");
            foreach(var option in options)
            {
                Console.WriteLine(option);
            }
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Result: {addition(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"Result: {subtraction(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"Result: {multiplication(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"Result: {division(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
}