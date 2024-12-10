using System;
using System.Text.RegularExpressions;

namespace Tutorial
{
    public class Lists
    {
        public static void Main(string[] args)
        {
            const int numSides = 3;
            List<int> triangle = new List<int>();

            for(int i = 0; i < numSides; i++)
            {
                Console.Write($"Enter side {i+1}: ");
                triangle.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in triangle)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(triangle.Sum() == 180
            ? "The triangle is valid"
            : "The triangle is not valid");

            // Algunas funciones útiles
            List<int> newList = new List<int>() {1,3,2,0,4,0,0,3};

            newList.Add(5);
            newList.RemoveAt(0); //del position 0
        }
    }
}