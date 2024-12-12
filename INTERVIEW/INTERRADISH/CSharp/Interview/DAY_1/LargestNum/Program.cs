
namespace DAY1
{
    public class LargestNum
    {
        static int maxNum(List<int> lista)
        {
            int max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] >= max)
                {
                    max = lista[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            List<int> ex = new List<int>() { 10, 20, 80, 40, 50, 90, 80 };

            Console.WriteLine($"The largest number in the list is: {maxNum(ex)}");
        }
    }
}