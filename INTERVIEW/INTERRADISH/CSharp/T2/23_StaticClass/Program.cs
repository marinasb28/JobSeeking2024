namespace T2
{
    public static class GetSet
    {
        public static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day",4.57);
            Console.WriteLine($"Title: {holiday.title}, Artist: {holiday.artist}, Duration: {holiday.duration} minutes");
            Console.WriteLine($"Número de clases: {Song.songCount}");

            Console.WriteLine($"Número de clases: {holiday.getSongCount()}");
        }
    }
}