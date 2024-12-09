
namespace Tutorial
{
    public class Loops
    {
        static void Main(string[] args)
        {
            // ** FOOR LOOPS ** \\
            Console.WriteLine("Foor loop:");
            for(int i = 0; i <= 5; i ++)
            {
                Console.WriteLine(i);
            }

            // ** WHILE LOOP ** \\
            int idx = 5;
            Console.WriteLine("While loop:");
            while(idx >= 0)
            {
                Console.WriteLine(idx);
                idx--;
            }

            // ** DO WHILE ** \\
            // 1st iteration no depende en nadie, el resto sí
            do
            {
                Console.WriteLine("1st aquí");
            } while (idx >= 0);
        }
    }
}