
namespace T2
{
    public static class Exceptions
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 =  int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                int num2 =  int.Parse(Console.ReadLine());

                Console.WriteLine(num1/num2);
            }catch(DivideByZeroException)
            {
                Console.WriteLine("Error: can't divide by zero");
            }catch(FormatException)
            {
                Console.WriteLine("Error: invalid input");
            }finally
            {
                Console.WriteLine("Program terminated");
            }
        }
    }
}