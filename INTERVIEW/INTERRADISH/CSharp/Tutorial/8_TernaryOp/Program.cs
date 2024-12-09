
namespace Tutorial
{
    public class TernaryOp
    {
        static void Main(string[] args)
        {
            int age = 23;
            if(age >= 18)
            {
                Console.WriteLine("+18");
            }else
            {
                Console.WriteLine($"{18-age} years to become an adult");
            }

            // Ternary operator
            Console.WriteLine(age >= 25
                ? "+25"
                : $"{25-age} years and then, +25");

            // Formatting
            double d = 1/3d;
            Console.WriteLine(d);
            Console.WriteLine($"Decimales: {d:F3}");

        }
    }
}