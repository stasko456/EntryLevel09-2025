using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class AlbumController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddAlbums()
        {
            string fileName = "albums.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Album album = new Album()
                    {
                        Title = text[0],
                        Length = int.Parse(text[1]),
                        ReleaseDate = DateTime.Parse(text[2])
                    };
                    context.Albums.Add(album);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadAlbums()
        {
            var albums = context.Albums.Select(x => $"id:{x.Id} - Title:{x.Title} - length:{x.Length} - release date:{x.ReleaseDate.Date}");
            return albums.ToList();
        }
    }

}
