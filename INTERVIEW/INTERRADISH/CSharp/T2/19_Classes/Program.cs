
namespace T2
{
    public static class Classes
    {
        public static void Main(string[] args)
        {
            //creating an object
            Book book1 = new Book("Marina");
            book1.title = "Reviewing C#";
            book1.author = "Giraffe Academy";
            book1.numPages = 300;

            Console.WriteLine($"Reading {book1.title}");
            Console.WriteLine($"by {book1.author}");
            Console.WriteLine($"with {book1.numPages} pages");
        }
    }
}