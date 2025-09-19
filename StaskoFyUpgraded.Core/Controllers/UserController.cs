using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class UserController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void RemoveUser(int userId)
        {
            User user = context.Users.FirstOrDefault(x => x.Id == userId);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public void UpdateUser(int userId, string name, string email, string favArtist, string favAlbum, string favSong)
        {
            User user = context.Users.FirstOrDefault(x => x.Id == userId);
            // favArtis, favAlbum and favSong:
            if (favArtist != "NULL")
            {
                Artist artist = context.Artists.FirstOrDefault(x => x.Id == int.Parse(favArtist));
                user.FavArtist = artist;
                user.FavArtistId = int.Parse(favArtist);
            }
            else
            {
                user.FavArtistId = null;
                user.FavArtist = null;
            }
            if (favAlbum != "NULL")
            {
                Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(favAlbum));
                user.FavAlbum = album;
                user.FavAlbumId = int.Parse(favAlbum);
            }
            else
            {
                user.FavAlbumId = null;
                user.FavAlbum = null;
            }
            if (favSong != "NULL")
            {
                Song song = context.Songs.FirstOrDefault(x => x.Id == int.Parse(favSong));
                user.FavSong = song;
                user.FavSongId = int.Parse(favSong);
            }
            else
            {
                user.FavSongId = null;
                user.FavSong = null;
            }
            context.SaveChanges();
        }

        //public bool IsUserNull(int userId)
        //{
        //    User user = context.Users.FirstOrDefault(x => x.Id == userId);
        //    if (user == null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public List<string> ReadUsers()
        {
            var users = context.Users.Select(x => $"id:{x.Id} - name:{x.Username} - fav artist id:{x.FavArtistId} - fav album id:{x.FavAlbumId} - fav song id:{x.FavSongId}");
            return users.ToList();
        }

        public List<string> ReadUsersIdAndName()
        {
            var users = context.Users.Select(x => $"id:{x.Id} - name:{x.Username}");
            return users.ToList();
        }
    }
}
