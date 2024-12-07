
namespace T2
{
    public static class IfStatements
    {
        public static void Main(string[] args)
        {
            bool isWoman = false;
            int age = 5;

            if(isWoman && age >= 18)
            {
                Console.WriteLine("Hello, adult woman!");
            }else if (isWoman || age < 10)
            {
                Console.WriteLine("Hello, kid!");
            }else{
                Console.WriteLine("Hello, man!");
            }
        }
    }
}