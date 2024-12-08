namespace Tutorial
{
    public static class DataTypes
    {
        static void Main(string[] args)
        {
            // ** MOST COMMON ONES ** \\
            string name = "Marina";
            //char letter = 'a';
            int age = 23;
            bool isWoman = true;
            double height = 1.69;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine(isWoman ? "Hi girl!" : "Hi boy!");
            Console.WriteLine(height >= 1.5 ? "You're tall" : "You're short");

            // ** CONVERSIONS FROM ONE TYPE TO ANOTHER ** \\

            // string -> int
            string textAge = "23";
            int intAge = int.Parse(textAge);
            //int intAge = Convert.ToInt32(textAge);

            // int -> string
            int intNum = 4;
            string stringNum = intNum.ToString();
        }
    }
}