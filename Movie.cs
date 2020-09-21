using System;
using System.Linq;

namespace csharpworld
{
    class Movie
    {
        public string title, director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                string[] values = { "G", "R", "PG", "PG-13"};
                if (values.Contains(value))
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}