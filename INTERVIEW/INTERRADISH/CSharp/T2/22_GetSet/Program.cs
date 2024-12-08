namespace T2
{
    public static class GetSet
    {
        public static void Main(string[] args)
        {
            Movie shrek = new Movie("Shrek","Adam Adamson","Dog");

            Console.WriteLine(shrek.Rating);
            shrek.Rating = "G";
            Console.WriteLine(shrek.Rating);
        }
    }
}