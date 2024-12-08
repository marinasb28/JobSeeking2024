namespace T2
{
    class Book
    {
        // class attributes
        public string title;
        public string author;
        public int numPages;

        // Constructors
        public Book(string name)
        {
            Console.WriteLine($"Creating book for {name}");
        }
    } 
}