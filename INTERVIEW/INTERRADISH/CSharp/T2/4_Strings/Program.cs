
namespace T2
{
    public static class Strings
    {
        public static void Main(string[] args)
        {
            string phrase = "Hola Marina";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Hola"));
            Console.WriteLine(phrase[3]);
            Console.WriteLine(phrase.IndexOf("Marina"));
            Console.WriteLine(phrase.Replace("Hola", "Hello"));
            Console.WriteLine(phrase.Substring(4,2)); //donde empieza | los que quiero
        }
    }
}