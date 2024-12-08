namespace T2
{
    public class Song
    {
        public string title,artist;
        public double duration;
        // al ser static, está asociado A LA CLASE
        public static int songCount = 0;

        public Song(string title,string artist, double duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}