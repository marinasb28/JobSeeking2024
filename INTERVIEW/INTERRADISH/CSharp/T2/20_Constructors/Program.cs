
namespace T2
{
    public static class Classes
    {
        public static void Main(string[] args)
        {
            //creating an object
            Book book1 = new Book("Reviewing C#","Giraffe Academy",300);

            Console.WriteLine($"Reading {book1.title}");
            Console.WriteLine($"by {book1.author}");
            Console.WriteLine($"with {book1.numPages} pages");
        }
    }
}