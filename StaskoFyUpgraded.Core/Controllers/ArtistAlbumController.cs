using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class ArtistAlbumController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddArtistsAlbums()
        {
            string fileName = "artistsAlbums.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Artist artist = context.Artists.FirstOrDefault(x => x.Id == int.Parse(text[0]));
                    Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(text[1]));
                    ArtistAlbum artistAlbum = new ArtistAlbum()
                    {
                        ArtistId = int.Parse(text[0]),
                        Artist = artist,
                        AlbumId = int.Parse(text[1]),
                        Album = album
                    };
                    context.ArtistsAlbums.Add(artistAlbum);
                    album.ArtistsAlbums.Add(artistAlbum);
                    artist.ArtistsAlbums.Add(artistAlbum);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadArtistsAlbums()
        {
            var artistsAlbums = context.ArtistsAlbums.Select(x => $"id:{x.Id} - artist's id:{x.ArtistId} - album's id:{x.AlbumId}");
            return artistsAlbums.ToList();
        }
    }

}
