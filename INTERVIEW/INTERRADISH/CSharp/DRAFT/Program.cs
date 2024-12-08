using System;

namespace CSHARP
{
    public static class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 100; i++)
        {
            string output = "";

            if (i % 3 == 0)
                output += "Fizz";
            if (i % 5 == 0)
                output += "Buzz";
            if (i % 7 == 0)
                output += "Bazz";

            // Si el resultado está vacío, solo mostrar el número
            if (output == "")
                //output = i.ToString();
                output = Convert.ToString(i);

            Console.WriteLine(output);
        }
        }
    }
}