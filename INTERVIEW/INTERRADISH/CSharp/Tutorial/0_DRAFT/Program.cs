namespace Tutorial
{
    public class DRAFT
    {
        public static void Main(string[] args)
        {
            Console.Write("Escribe un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series: ");
            Fib(num);
            Console.WriteLine("\nEs primo?");
            Console.WriteLine(esPrimo(num) ? "Sí, es primo." : "No, no es primo.");
        }

        public static void Fib(int fibNum)
        {
            Console.WriteLine($"Printing first {fibNum} Fibonacci numbers: ");
            int num1 = 0, num2 = 1;

            for (int i = 0; i < fibNum; i++)
            {
                Console.Write($"{num1}");
                if (i < fibNum - 1) // Evita imprimir una coma al final
                {
                    Console.Write(", ");
                }

                int nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
            }
        }

        public static bool esPrimo(int num)
        {
            if (num < 2) // Un número menor que 2 no es primo
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // Si es divisible, no es primo
                }
            }
            return true; // Si no tiene divisores, es primo
        }
    }
}