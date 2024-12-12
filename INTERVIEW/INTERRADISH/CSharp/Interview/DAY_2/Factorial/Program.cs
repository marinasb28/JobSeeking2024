namespace DAY2
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = n;

            int result = 1;
            for(int i=0; i < n; i++)
            {
                if(n == 0 || n == 1)
                {
                    result = 1;
                    break;
                }else
                {
                    result *= fact;
                    fact --;
                }
            }
            Console.WriteLine($"{n}! = {result}");
        }
    }
}