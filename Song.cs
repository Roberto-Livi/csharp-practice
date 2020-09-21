using System;
using System.Linq;

namespace csharpworld
{
    class Song
    {
        public string title, artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}