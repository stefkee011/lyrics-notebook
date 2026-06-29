using System;
using System.Collections.Generic;
using System.Text;


namespace LyricsNotebook
{
    internal class Song
    {
        public string Title {  get; set; }
        public string Lyrics { get; set; }
        public DateTime DateCreated { get; set; }

        public Song(string title, string lyrics) 
        { 
            Title = title;
            Lyrics = lyrics;
            DateCreated = DateTime.Now;
        }

    }
}
