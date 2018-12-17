using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var player = new Player();
            player.Volume = 20;
            player.Songs = GetSongsData();
            //TraceInfo(player);

            player.Play();
            player.VolumeUp();
            player.VolumeChange(25);
            player.VolumeDown();
            player.Stop();

            Console.ReadLine();
        }
        public static Song[] GetSongsData()
        {
            var album = new Album();
            album.Name = "Back in Black";
            album.Year = 1980;

            var artist = new Artist();
            artist.Genre = "Rock";
            artist.Name = "AC/DC";

            var song = new Song()
            {
                Duration = 100,
                Name = "new song",
                Album = album,
                Artist = artist

            };
            return new Song[] {song};
        }
        public static void TraceInfo(Player player)
        {
            Console.WriteLine(player.Songs[0].Album);
            Console.WriteLine(player.Songs[0].Name);
            Console.WriteLine(player.Songs[0].Artist);
            Console.WriteLine(player.Songs[0].Duration);
        }
         
    }
}
