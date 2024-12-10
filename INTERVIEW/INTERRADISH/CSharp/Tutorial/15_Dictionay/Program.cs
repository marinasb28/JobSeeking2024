using System;
using System.Text.RegularExpressions;

namespace Tutorial
{
    public class Dictionary
    {
        public static void Main(string[] args)
        {
            // <key,value>
            Dictionary<int,string> names = new Dictionary<int,string>()
            {
                {1, "Alice"},
                {2, "Bob"},
                {3, "Charlie"}
            };

            for(int i = 0; i < names.Count; i++)
            {
                var item = names.ElementAt(i);
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }

            foreach(var item in names)
            {
                Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
            }
            
            // Funciones útiles
            names.Add(4, "John");
            Console.WriteLine(names[4]);
            if(names.TryGetValue(4,out var name))
            {
                Console.WriteLine(name);
            }else
            {
                Console.WriteLine("Key not found");
            }

            names.Remove(4);
            

        }
    }
}