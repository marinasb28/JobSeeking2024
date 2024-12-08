
namespace T2
{
    public static class Arrays2D
    {
        public static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 2},
                {3, 4},
                {5, 6},
                {7, 8}
            };

            Console.WriteLine($"Value at (1,1): {matrix[0,0]}");
            Console.WriteLine($"Value at (4,1): {matrix[3,1]}");
        }
    }
}