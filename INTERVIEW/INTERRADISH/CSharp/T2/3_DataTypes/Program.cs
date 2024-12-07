
namespace T2
{
    public static class DataTypes
    {
        public static void Main(string[] args)
        {
            // ** PLAIN TEXT ** \\
            string phrase = "Hi there!";
            char letter = 'M'; // comilla simple

            Console.WriteLine($"string: {phrase}");
            Console.WriteLine($"char: {letter}");


            // ** NUMBERS ** \\
            int age = 23;
            float height = 1.69f; //usa menos memoria
            double weight = 59.9; //el más usado

            Console.WriteLine($"int: {age}");
            Console.WriteLine($"float: {height}");
            Console.WriteLine($"double: {weight}");

            // ** BOOLEANS ** \\
            bool isAdult = true;
            Console.WriteLine($"string: {isAdult}");


        }
    }
}