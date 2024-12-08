namespace Tutorial
{
    public static class Variables
    {
        static void Main(string[] args)
        {
            // ** MOST COMMON ONES ** \\
            string name = "Marina";
            int age = 23;
            bool isWoman = true;
            double height = 1.69;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine(isWoman ? "Hi girl!" : "Hi boy!");
            Console.WriteLine(height >= 1.5 ? "You're tall" : "You're short");

        }
    }
}