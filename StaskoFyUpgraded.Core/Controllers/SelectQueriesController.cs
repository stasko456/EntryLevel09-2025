using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;
using static System.Net.Mime.MediaTypeNames;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class SelectQueriesController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        //select artists by given country:
        //need data from the user
        public List<string> SelectArtistsByGivenCountry(string country)
        {
            var artists = context.Artists.Select(x => new
            {
                x.Country,
                x.Name,
            }).Where(a => a.Country.ToLower() == country.ToLower()).ToList();
            List<string> artistNames = artists.Select(x => $"{x.Name}").ToList();
            return artistNames;
        }

        //select producers by given country:
        //need data from the user
        public List<string> SelectProducersByGivenCountry(string country)
        {
            var producers = context.Producers.Select(x => new
            {
                x.Country,
                x.Name,
            }).Where(a => a.Country.ToLower() == country.ToLower()).ToList();
            List<string> producersNames = producers.Select(x => $"{x.Name}").ToList();
            return producersNames;
        }

        //select songs from an album by given album name:
        //need data from the user
        //data used from 2 tables: Albums and Songs (one to many)
        public List<string> SelectSongsFromSpecificAlbum(string albumName)
        {
            var album = context.Albums.Include(a => a.Songs).FirstOrDefault(x => x.Title.ToLower() == albumName.ToLower());
            List<string> songNames = album.Songs.Select(x => $"{x.Title}").ToList();
            return songNames;
        }

        //select songs from given artist name:
        //need data from the user
        //data used from 3 tables: Artists and Songs (many to many) with mapping table ArtistsSongs
        public List<string> SelectSongsFromSpecificArtist(string artistName)
        {
            var artist = context.Artists.Include(a => a.ArtistsSongs).ThenInclude(b => b.Song).FirstOrDefault(x => x.Name.ToLower() == artistName.ToLower());
            List<string> songNames = artist.ArtistsSongs.OrderBy(b => b.Song.ReleaseDate).Select(x => $"{x.Song.Title}").ToList();
            return songNames;
        }

        ///---------------------------------///

        //select users with their fav song:
        //data used from 2 tables: User and Songs (one to one)
        public string SelectCurrentUserWithFavSong()
        {
            string currentUserFavSong = Session.User.FavSong.Title.ToString();
            return currentUserFavSong;
        }

        //select users with their fav album:
        //data used from 2 tables: User and Albums (one to one)
        public string SelectCurrentUserWithFavAlbum()
        {
            var currentUserFavAlbum = Session.User.FavAlbum.Title.ToString();
            return currentUserFavAlbum;
        }

        //select users with their fav artist:
        //data used from 2 tables: User and Artists (one to one)
        public string SelectCurrentUserWithFavArtist()
        {
            var currentUserFavArtist = Session.User.FavArtist.Name.ToString();
            return currentUserFavArtist;
        }

        ///---------------------------------///

        //select albums with their producers by given album name:
        //data used from 3 tables: Albums and Producers (many to many) with mapping table ProducersAlbums
        //need data from the user
        public List<string> SelectAlbumsAndTheirProducers(string albumName)
        {
            var albums = context.Albums.Include(a => a.ProducersAlbums).ThenInclude(b => b.Producer).Where(x => x.Title.ToLower() == albumName.ToLower()).ToList();
            List<string> albumsAndProducers = albums
                    .SelectMany(album => album.ProducersAlbums
                        .Select(pa => $"{pa.Producer.Name}"))
                    .ToList();
            return albumsAndProducers;
        }

        //select albums with their artists:
        //data used from 3 tables: Albums and Artists (many to many) with mapping table ArtistsAlbums
        public List<string> SelectAlbumsAndTheirArtists()
        {
            var albums = context.Albums.Include(a => a.ArtistsAlbums).ThenInclude(b => b.Artist).ToList();
            List<string> albumsAndArtists = albums
                .SelectMany(album => album.ArtistsAlbums
                .Select(x => $"{album.Title} - {x.Artist.Name}"))
                .ToList();
            return albumsAndArtists;
        }

        //select count of songs in every album:
        //data used from 2 tables: Songs and Albums (one to many)
        public List<string> SelectCountOfEveryTrackInEachAlbum()
        {
            var albums = context.Albums.Include(a => a.Songs).ToList();
            List<string> countOfSongs = albums.OrderBy(v => v.Songs.Count).Select(x => $"{x.Title} - {x.Songs.Count}").ToList();
            return countOfSongs;
        }

        //show songs form current user's playlist of current user:
        //data used from 3 tables: Songs, Artists, ArtistsSongs (many to many)
        public List<string> SelectSongsNamesFromCurrentUserPlaylist(string playlistTitle)
        {
            Playlist playlist = context.Playlists.FirstOrDefault(x => x.Title == playlistTitle);

            int playlistId = playlist.Id;

            var songsIds = context.PlaylistsSongs.Where(x => x.PlaylistId == playlistId).Select(x => x.SongId).ToList();

            var songsInPlaylist = context.Songs.Where(x => songsIds.Contains(x.Id)).ToList();

            return songsInPlaylist.Select(x => $"{x.Title}").ToList();
        }

        //show curremt user's playlists:
        //data used from 2 tables: Users and Playlists (one to many)
        public List<string> SelectCurrentUserPlaylists()
        {
            int id = Session.User.Id;
            var users = context.Users.FirstOrDefault(x => x.Id == id);
            var currentUserPlaylists = context.Playlists.Where(x => x.UserId == id).Select(x => $"{x.Title} - {x.Length} minutes - {x.SongCount} songs");
            return currentUserPlaylists.ToList();
        }

        // 12 select queries so far
    }
}
