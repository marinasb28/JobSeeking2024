using System;
using System.Collections.Generic;

namespace DAY2
{
    class RemoveDupl
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,1,2,3,3,4,5,5};
            List<int> newList = new List<int>();

            foreach(var num in list)
            {
                if(!newList.Contains(num))
                {
                    newList.Add(num);
                }
            }

            Console.WriteLine("Original List: " + string.Join(", ", list));
            Console.WriteLine("List Without Duplicates: " + string.Join(", ", newList));
        }
    }
}