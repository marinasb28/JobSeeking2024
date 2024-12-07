
namespace T2
{
    public static class Methods
    {
        public static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("What's your name? ");
            name = Console.ReadLine();
            Console.Write("And your age? ");
            age = int.Parse(Console.ReadLine());
            SayHi(name,age);
        }

        static void SayHi(string n,int a)
        {
            Console.WriteLine($"Hello {n}! Wow, you're {a} old.");

        }
    }
}