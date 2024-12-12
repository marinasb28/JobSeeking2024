
namespace DAY1
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                bool div3 = i%3==0;
                bool div5 = i%5==0;

                if(div3 && div5)
                {
                    Console.WriteLine("FizzBuzz");
                } else if(div3)
                {
                    Console.WriteLine("Fizz");
                } else if(div5)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}