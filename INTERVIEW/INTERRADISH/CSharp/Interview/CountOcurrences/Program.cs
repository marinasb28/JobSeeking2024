
namespace CountOcurrences
{
    public class CountOcurrences
    {
        static int countOcurrences(int[] lista, int number)
        {
            int count = 0;
            for(int i = 0; i <lista.Length; i++)
            {
                if(lista[i] == number)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] ex = { 1, 2, 3, 2, 3, 4, 2, 5 };
            int number = 2;

            Console.WriteLine($"The number {number} appears {countOcurrences(ex, number)} times in the array.");
        }
    }
}