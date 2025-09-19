using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class ProducerAlbumController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddProducersAlbums()
        {
            string fileName = "producersAlbums.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Producer producer = context.Producers.FirstOrDefault(x => x.Id == int.Parse(text[0]));
                    Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(text[1]));
                    ProducerAlbum producerAlbum = new ProducerAlbum()
                    {
                        ProducerId = int.Parse(text[0]),
                        Producer = producer,
                        AlbumId = int.Parse(text[1]),
                        Album = album
                    };
                    context.ProducersAlbums.Add(producerAlbum);
                    producer.ProducersAlbums.Add(producerAlbum);
                    album.ProducersAlbums.Add(producerAlbum);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadProducersAlbums()
        {
            var producersAlbums = context.ProducersAlbums.Select(x => $"id:{x.Id} - producer's id:{x.ProducerId} - album's id:{x.AlbumId}");
            return producersAlbums.ToList();
        }
    }

}
