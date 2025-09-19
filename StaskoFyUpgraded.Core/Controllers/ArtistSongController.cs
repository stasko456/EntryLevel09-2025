using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class ArtistSongController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddArtistsSongs()
        {
            string fileName = "artistsSongs.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Artist artist = context.Artists.FirstOrDefault(x => x.Id == int.Parse(text[0]));
                    Song song = context.Songs.FirstOrDefault(x => x.Id == int.Parse(text[1]));
                    ArtistSong artistSong = new ArtistSong()
                    {
                        ArtistId = int.Parse(text[0]),
                        Artist = artist,
                        SongId = int.Parse(text[1]),
                        Song = song
                    };
                    context.ArtistsSongs.Add(artistSong);
                    song.ArtistsSongs.Add(artistSong);
                    artist.ArtistsSongs.Add(artistSong);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadArtistsSongs()
        {
            var artistsSongs = context.ArtistsSongs.Select(x => $"id:{x.Id} - artist's id:{x.ArtistId} - song's id:{x.SongId}");
            return artistsSongs.ToList();
        }
    }

}
