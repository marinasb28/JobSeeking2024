using System;
using System.Text.RegularExpressions;

namespace Tutorial
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            const int angleNum = 3
            int[] triangle = new int[angleNum]; //array con fixed length

            for(int i = 0; i < triangle.Length; i++)
            {
                Console.Write($"Enter side {i+1}: ");
                triangle[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in triangle)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(triangle.Sum() == 180
            ? "The triangle is valid"
            : "The triangle is not valid");

            // Algunas funciones útiles
            int[] newarray = {1,3,2,0,4,0,0,3};
            
            Array.Sort(newarray);
            Array.Reverse(newarray);
            /*Array.Clear(newarray,0,newarray.Length);
            *(array,startPosition,endPosition)
            */
            /*
            for(int i = 0; i < newarray.Length;i++)
            {
                newarray[i] = default;
            }
            */

            Array.IndexOf(newarray,0); //1st ocurrence
            //Array.IndexOf(nameArray,searchedNum,range)
        }
    }
}