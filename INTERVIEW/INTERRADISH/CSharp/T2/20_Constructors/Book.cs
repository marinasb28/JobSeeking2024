namespace T2
{
    class Book
    {
        // class attributes
        public string title;
        public string author;
        public int numPages;

        // Constructors
        public Book(string title, string author, int numPages)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
        }
    } 
}