namespace Tutorial
{
    public static class Functions
    {


        static string WelcomeMessage(int age, string name)
        {
            return ($"Welcome, {name} - {age}");
        }

        static bool isEven(int num)
        {
            return num%2==0;
        }

        //Optional parameters
        static int optSum(int a, int b = 5) //[Optional] int b = default
        {
            return a+b;
        }

        // Using 'ref' será como una variable global
        static void assign(ref int num)
        {
            num = 20;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage(name: "Marina", age: 23));

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(isEven(num)
               ? "The number is even"
                : "The number is odd");

            Console.WriteLine($"Sum: {optSum(num)}");
            Console.WriteLine($"Sum: {optSum(num,10)}");
        }
    }
}