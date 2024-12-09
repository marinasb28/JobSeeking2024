
namespace Tutorial
{
    public class FizzBuzz
    {
        static void Main(string[] args)
        {
            /*
            * FizzBuzz -> 3 & 5
            * Fizz -> 3
            * Buzz -> 55
            */

            for(int i = 0; i <=15; i++)
            {
                bool threeDiv = i%3 == 0,
                    fiveDiv = i%5 == 0;
                if(threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(threeDiv)
                {
                    Console.WriteLine("Fizz");
                }else if(fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}