
namespace T2
{
    public static class Arrays
    {
        public static void Main(string[] args)
        {
            //Array of intergers
            int[] luckyNumbers = {7,13,21};

            // Change value
            Console.WriteLine($"Before: {luckyNumbers[1]}");
            luckyNumbers[1] = 15;
            Console.WriteLine($"After: {luckyNumbers[1]}");
        }
    }
}