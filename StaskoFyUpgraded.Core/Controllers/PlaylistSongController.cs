using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class PlaylistSongController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddPlaylistsSongs()
        {
            string fileName = "playlistsSongs.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';');
                    Playlist playlist = context.Playlists.FirstOrDefault(x => x.Id == int.Parse(text[0]));
                    Song song = context.Songs.FirstOrDefault(x => x.Id == int.Parse(text[1]));
                    PlaylistSong playlistSong = new PlaylistSong
                    {
                        PlaylistId = int.Parse(text[0]),
                        Playlist = playlist,
                        SongId = int.Parse(text[1]),
                        Song = song
                    };
                    context.PlaylistsSongs.Add(playlistSong);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public List<string> ReadPlaylistsSongs()
        {
            var playlistsSongs = context.PlaylistsSongs.Select(x => $"id:{x.Id} - playlistSong's id:{x.PlaylistId} - song's id:{x.SongId}");
            return playlistsSongs.ToList();
        }
    }
}
