using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class GenreController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddGenres()
        {
            string fileName = "genres.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Genre genre = new Genre()
                    {
                        Name = line,
                    };
                    context.Genres.Add(genre);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadGenres()
        {
            var genres = context.Genres.Select(genre => $"id:{genre.Id} - name:{genre.Name}");
            return genres.ToList();
        }
    }

}
