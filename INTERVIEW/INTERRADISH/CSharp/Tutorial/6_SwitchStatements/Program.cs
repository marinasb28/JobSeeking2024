
namespace Tutorial
{
    public class SwitchStatements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-3): ");
            int numLight = int.Parse(Console.ReadLine());

            string lightName;
            switch(numLight)
            {
                case 1:
                    lightName = "Red";
                    break;
                case 2:
                    lightName = "Yellow";
                    break;
                case 3:
                    lightName = "Green";
                    break;
                default:
                    lightName = "N/A";
                    break;
            }
            Console.WriteLine($"{lightName} is {numLight}");
        }
    }
}