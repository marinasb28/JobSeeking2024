namespace Tutorial
{
    public static class HelloWorld
    {
        static void Main(string[] args)
        {
            // ** WORKING WITH NUMS \\
            int age = 23;
            Console.WriteLine($"Age: {age}");
            age ++;
            Console.WriteLine($"Age after increment: {age}");
            age += 10;
            Console.WriteLine($"Age after adding 10: {age}");

            Console.WriteLine($"Writting, then incrementing: {age++} || {age}"); //34 then 35
            Console.WriteLine($"Incrementing, then writing: {++age} || {age}"); //36 then 36

            // ** EVEN OR ODD \\
            int number = 23;
            Console.WriteLine(number%2 == 0 ? "Even" : "Odd");

            // ** WORKING WITH STRINGS \\
            string name = "Marin";
            char letter = 'a';
            Console.WriteLine($"Name: {name+letter}");


        }
    }
}