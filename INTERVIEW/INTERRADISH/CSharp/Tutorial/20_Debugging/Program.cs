namespace Tutorial
{
    public static class Debugging
    {
        static void Main(string[] args)
        {
            int age = 35;

            if(age > 18)
            {
                Console.WriteLine("18+");
            } else if (age > 30)
            {
                Console.WriteLine("30+");
            }
            //Falta el else
        }
    }
}