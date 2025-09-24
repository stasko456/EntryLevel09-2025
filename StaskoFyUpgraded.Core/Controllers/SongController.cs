using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class SongController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddSongs()
        {
            string fileName = "songs.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Genre genre = context.Genres.FirstOrDefault(x => x.Id == int.Parse(text[4]));
                    Song song = new Song()
                    {
                        Title = text[0],
                        Length = double.Parse(text[1]),
                        ReleaseDate = DateTime.Parse(text[2]),
                        GenreId = int.Parse(text[4]),
                        Genre = genre
                    };
                    if (text[3] != "NULL")
                    {
                        Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(text[3]));
                        song.AlbumId = int.Parse(text[3]);
                        song.Album = album;
                        album.Songs.Add(song);
                    }
                    genre.Songs.Add(song);
                    context.Songs.Add(song);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadSongs()
        {
            var songs = context.Songs.Select(x => $"id:{x.Id} - Title:{x.Title} - length:{x.Length} - release date:{x.ReleaseDate.Date} - genre:{x.Genre.Name} - genre's id:{x.GenreId}");
            return songs.ToList();
        }

        public List<Song> ReturnSongs()
        {
            return context.Songs.ToList();
        }
    }

}
