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
        }
    }
}