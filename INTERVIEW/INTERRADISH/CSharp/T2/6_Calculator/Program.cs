
namespace T2
{
    public static class Calculator
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {num1 + num2}");
        }
    }
}