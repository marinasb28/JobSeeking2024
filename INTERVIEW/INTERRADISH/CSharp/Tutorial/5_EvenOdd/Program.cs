namespace Tutorial
{
    public static class EvenOdd
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i % 2 == 0
                    ? $"{i} is even"
                    : $"{i} is odd");
            }

            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.Write("What's your age? ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name}, {age} years old");

            // ** IF STATEMENTS ** \\
            if(age < 18)
            {
                Console.WriteLine("<18");
            }else if(age >= 18 && age <= 25)
            {
                Console.WriteLine("Between 18 & 25");
            }else
            {
                Console.WriteLine("+25");
            }
        }
    }
}