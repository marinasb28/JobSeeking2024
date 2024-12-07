
namespace T2
{
    public static class ReturnValue
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number}^3 = {CubeNum(number)}");
        }

        static int CubeNum(int num)
        {
            return (int)Math.Pow(num,3);
        }
    }
}