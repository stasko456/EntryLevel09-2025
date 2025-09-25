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

        public void AddUser()
        {
            string fileName = "users.txt";
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] text = line.Split(';').ToArray();
                    User user = new User()
                    {
                        Username = text[0].ToString(),
                        Password = text[1].ToString()
                    };
                    if (text[2] != "NULL")
                    {
                        Artist artist = context.Artists.FirstOrDefault(x => x.Id == int.Parse(text[2]));
                        user.FavArtistId = artist.Id;
                        user.FavArtist = artist;
                    }
                    else
                    {
                        user.FavArtistId = null;
                        user.FavArtist = null;
                    }
                    if (text[3] != "NULL")
                    {
                        Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(text[3]));
                        user.FavAlbumId = album.Id;
                        user.FavAlbum = album;
                    }
                    else
                    {
                        user.FavAlbumId = null;
                        user.FavAlbum = null;
                    }
                    if (text[4] != "NULL")
                    {
                        Song song = context.Songs.FirstOrDefault(x => x.Id == int.Parse(text[4]));
                        user.FavSongId = song.Id;
                        user.FavSong = song;
                    }
                    else
                    {
                        user.FavSongId = null;
                        user.FavSong = null;
                    }
                    context.Users.Add(user);
                    context.SaveChanges();
                    line = reader.ReadLine();
                }
            }
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void RemoveCurrentUser()
        {
            User user = Session.User;
            context.Users.Remove(user);
            context.SaveChanges();
            Session.User = null;
        }

        public void UpdateCurrentUser(string username, string passsword, string favArtist, string favAlbum, string favSong)
        {
            int id = Session.User.Id;
            User user = context.Users.FirstOrDefault(x => x.Id == id);
            user.Username = username;
            user.Password = passsword;
            Session.User.Username = username;
            Session.User.Password = passsword;
            // favArtis, favAlbum and favSong:
            if (favArtist != "NULL")
            {
                Artist artist = context.Artists.FirstOrDefault(x => x.Id == int.Parse(favArtist));
                user.FavArtist = artist;
                user.FavArtistId = int.Parse(favArtist);
                Session.User.FavArtist = artist;
                Session.User.FavArtistId = int.Parse(favArtist);
            }
            else
            {
                user.FavArtistId = null;
                user.FavArtist = null;
                Session.User.FavArtistId = null;
                Session.User.FavArtist = null;
            }
            if (favAlbum != "NULL")
            {
                Album album = context.Albums.FirstOrDefault(x => x.Id == int.Parse(favAlbum));
                user.FavAlbum = album;
                user.FavAlbumId = int.Parse(favAlbum);
                Session.User.FavAlbum = album;
                Session.User.FavAlbumId = int.Parse(favAlbum);
            }
            else
            {
                user.FavAlbumId = null;
                user.FavAlbum = null;
                Session.User.FavAlbumId = null;
                Session.User.FavAlbum = null;
            }
            if (favSong != "NULL")
            {
                Song song = context.Songs.FirstOrDefault(x => x.Id == int.Parse(favSong));
                user.FavSong = song;
                user.FavSongId = int.Parse(favSong);
                Session.User.FavSong = song;
                Session.User.FavSongId = int.Parse(favSong);
            }
            else
            {
                user.FavSongId = null;
                user.FavSong = null;
                Session.User.FavSongId = null;
                Session.User.FavSong = null;
            }
            context.SaveChanges();
        }

        public List<string> ReadUsers()
        {
            var users = context.Users.Select(x => $"id:{x.Id} - name:{x.Username} - fav artist id:{x.FavArtistId} - fav album id:{x.FavAlbumId} - fav song id:{x.FavSongId}");
            return users.ToList();
        }

        public List<string> ReadUsersNamesAndIds()
        {
            var users = context.Users.Select(x => $"{x.Id};{x.Username}");
            return users.ToList();
        }
    }
}
