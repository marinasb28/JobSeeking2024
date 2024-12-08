using System;

namespace T2
{
    public static class IfP2
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Num 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Num 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Num 3: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Between {num1}, {num2}, & {num3}, {getMax(num1, num2, num3)} is the greatest.");
        }

        static int getMax(int num1, int num2, int num3)
        {
            if ((num1 >= num2) && (num1 >= num3))
            {
                return num1;
            }
            else if ((num2 >= num1) && (num2 >= num3))
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}