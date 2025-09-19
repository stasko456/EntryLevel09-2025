using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class ArtistController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddArtists()
        {
            string fileName = "artists.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Artist artist = new Artist()
                    {
                        Name = text[0],
                        Country = text[1],
                        DebutYear = int.Parse(text[2])
                    };
                    context.Artists.Add(artist);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadArtists()
        {
            var artists = context.Artists.Select(x => $"id:{x.Id} - name:{x.Name} - country:{x.Country} - debut year:{x.DebutYear}");
            return artists.ToList();
        }
    }

}
