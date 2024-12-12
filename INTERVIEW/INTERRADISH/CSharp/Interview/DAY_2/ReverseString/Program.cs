namespace DAY2
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            string reverse = "";
            string og = "Hello";

            for(int i = og.Length-1; i >= 0;i--)
            {
                reverse += og[i];
            }

            Console.WriteLine(og);
            Console.WriteLine(reverse);
        }
    }
}