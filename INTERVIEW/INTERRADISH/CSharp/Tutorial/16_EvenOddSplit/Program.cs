namespace Tutorial
{
    public static class EvenOddSplit
    {
        static void Main(string[] args)
        {
            List<int> evenNum = new List<int>();
            List<int> oddNum = new List<int>();
            const int top = 20;

            for (int i = 0; i <= top; i++)
            {
                (i % 2 == 0
                ? evenNum
                : oddNum).Add(i);
            }

            Console.WriteLine("Even Numbers:");
            foreach (var item in evenNum)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nOdd Numbers:");
            foreach (var item in oddNum)
            {
                Console.Write($"{item} ");
            }
        }
    }
}