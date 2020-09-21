using System;

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
            rating = aRating;
        }
    }
}