
namespace T2
{
    public static class forLoop
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <=10; i++)
            {
                Console.WriteLine(i);
            }

            int[] luckyNums = {6,13,21};
            Console.WriteLine("\nLUCKY NUMBERS:");
            for(int i = 0; i < luckyNums.Length; i++)
            {
                Console.WriteLine(luckyNums[i]);
            }
        }
    }
}