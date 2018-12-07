using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAnalyzer
{
    public class MusicStats
    {
        public String Name;
        public String Artist;
        public String Album;
        public String Genre;
        public int Size;
        public int Time;
        public int Year;
        public int Plays;
        



        public MusicStats(string name, string artist, string album, string genre, int size,
                         int time, int year, int plays)
        {
            Name = name;
            Artist = artist;
            Album = album;
            Size = size;
            Genre = genre;
            Time = time;
            Year = year;
            Plays = plays;
            
        }
    }
}
