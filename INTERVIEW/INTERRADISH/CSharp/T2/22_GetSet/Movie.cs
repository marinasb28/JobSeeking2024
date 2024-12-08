namespace T2
{
    public class Movie
    {
        public string title, director;
        private string rating;

        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            Rating = rating;
        }

        public string Rating
        {
            get{ return this.rating;}
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    this.rating = value;
                }else
                {
                    this.rating = "NR";
                }
            }
        }
    }
}