
namespace DAY2
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una cadena: ");
            string cadena = Console.ReadLine();
            int vowelCount = 0;

            // Recorrer cada caracter de la cadena
            foreach (var c in cadena)
            {
                if ("aeiou".Contains(Char.ToLower(c)))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"El número de vocales es: {vowelCount}");
        }
    }
}