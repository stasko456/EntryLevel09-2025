using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class ProducerController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddProducers()
        {
            string fileName = "producers.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    Producer producer = new Producer()
                    {
                        Name = text[0],
                        Country = text[1]
                    };
                    context.Producers.Add(producer);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadProducers()
        {
            var producers = context.Producers.Select(x => $"id:{x.Id} - name:{x.Name} - country:{x.Country}");
            return producers.ToList();
        }
    }

}
