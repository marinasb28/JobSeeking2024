using System;

namespace CSHARP
{
    public static class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                *
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                *

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }*/

            int a = 2;
            Console.WriteLine($"Original value: {a}");
            int b = ++a;
            Console.WriteLine($"a = {a}\n++a = {b}");

            int c = 2;
            Console.WriteLine($"Original value: {c}");
            int d = a++;
            Console.WriteLine($"c = {c}\nc++ = {d}");
        }
    }
}