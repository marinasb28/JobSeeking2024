
namespace Tutorial
{
    public class EqualsComp
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            string str2 = "Hello";
            char[] chars = {'H','e','l','l','o'};

            Console.WriteLine("Comparing strings with '==' and '.Equals()'");
            Console.WriteLine(str == str2
                ? "Same"
                : "Different");
            Console.WriteLine(str.Equals(str2)
                ? "Same"
                : "Different");
            
            object str3 = new string(chars);
            // Compara el valor vs. compara la memoria
            Console.WriteLine("Comparing strings vs. object with '==' and '.Equals()'");
            Console.WriteLine(str == str3
                ? "Same"
                : "Different");
            Console.WriteLine(str.Equals(str3)
                ? "Same"
                : "Different");

            
            string strBack ="";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLinee(str[i]);
                strBack += str[i];
            }
            Console.WriteLine($"\n{str} & {strBack}");

        }
    }
}