
namespace Tutorial
{
    public class TryParse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string strNum = Console.ReadLine();
            int num;

            while(!(int.TryParse(strNum,out num)))
            {
                Console.Write("Wrong input, try again! ");
                strNum = Console.ReadLine();
            }
            Console.WriteLine($"The input number is: {num}");
        }
    }
}