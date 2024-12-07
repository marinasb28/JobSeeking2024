
namespace T2
{
    public static class Input
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            Console.Write($"Hello, {name}! How old are you? ");
            int age = int.Parse(Console.ReadLine());
            //int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old.");
        }
    }
}