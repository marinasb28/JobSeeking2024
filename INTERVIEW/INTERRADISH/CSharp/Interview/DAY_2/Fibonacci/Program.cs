namespace DAY2
{
    class FibonacciSerie
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            
            int n1 = 0, n2 = 1, next = 0;

            Console.Write("Fibonacci Series: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{n1},");
                next = n1+n2;
                n1 = n2;
                n2 = next;
                if(i == n-1)
                {
                    Console.Write($"{n1}");   
                }

            }
        }
    }
}