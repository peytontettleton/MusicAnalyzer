using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAnalyzer
{
    public static class MusicStatsReport
    {
        public static string GenerateText(List<MusicStats> musicStatsList)
        {
            string report = "Crime Analyzer Report\n\n";

            if (musicStatsList.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            Console.WriteLine("Songs played more than 200 times:");
            var Over200 = from MusicStats in musicStatsList where MusicStats.Plays > 200 select musicStatsList;
            foreach(var musicStatList in Over200)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            Console.WriteLine("Number of Alternative Songs:");
            var HowManyAlternative = musicStatsList.Where(MusicStats => MusicStats.Genre == "Alternative");
            foreach(var musicStatList in HowManyAlternative)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            Console.WriteLine("Number of Hip/Hop - Rap Songs:");
            var HowManyRap = from MusicStats in musicStatsList where MusicStats.Genre == "Hip-Hop / Rap" select MusicStats.Genre;
            foreach (var musicStatList in HowManyRap)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            Console.WriteLine("Songs from the Album - Welcome to the Fish Bowl");
            var FishBowl = musicStatsList.Where(MusicStats => MusicStats.Album == "Welcome to the Fish Bowl");
            foreach (var musicStatList in FishBowl)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            Console.WriteLine("Songs before 1970:");
            var OldManMusic = from MusicStats in musicStatsList where MusicStats.Year < 1970 select MusicStats.Year;
            foreach (var musicStatList in OldManMusic)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            Console.WriteLine("Number of Alternative Songs:");
            var LongTitle = musicStatsList.Where(MusicStats => MusicStats.Name.Length > 85);
            foreach(var musicStatList in LongTitle)
            {
                Console.WriteLine(musicStatList.ToString());
            }

            return report;

        }
    }
}
