using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class PlaylistController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddPlaylists()
        {
            string fileName = "playlists.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';');
                    User user = context.Users.FirstOrDefault(x => x.Id == int.Parse(text[3]));
                    Playlist playlist = new Playlist
                    {
                        Title = text[0],
                        Length = double.Parse(text[1]),
                        SongCount = int.Parse(text[2]),
                        UserId = int.Parse(text[3]),
                        User = user
                    };
                    if (text[3] == "NULL")
                    {
                        playlist.UserId = int.Parse(null);
                        playlist.User = null;
                    }
                    else
                    {
                        playlist.UserId = int.Parse(text[3]);
                        playlist.User = user;
                    }
                    context.Playlists.Add(playlist);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public void RemoveSongFromPlaylist(int songId)
        {
            Song song = context.Songs.FirstOrDefault(x => x.Id == songId);
            if (song != null)
            {
                // work in progress!
            }
        }

        public void AddSongToPlaylist(int songId)
        {
            // work in progress!
        }

        public List<string> ReadPlaylists()
        {
            var songsFromPlaylist = context.Songs.Include(x => x.PlaylistsSongs).ThenInclude(c => c.Playlist).Select(v => v.Title).ToList();
            return songsFromPlaylist;
        }
    }

}
