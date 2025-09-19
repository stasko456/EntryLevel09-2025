using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.Core.Controllers
{
    public class SelectQueriesController
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        //select artists by given country:
        //need data from the console
        public List<string> SelectArtistsByGivenCountry(string country)
        {
            var artists = context.Artists.Select(x => new
            {
                x.Country,
                x.Name,
            }).Where(a => a.Country.ToLower() == country.ToLower()).ToList();
            List<string> artistNames = artists.Select(x => $"artist's name:{x.Name}").ToList();
            return artistNames;
        }

        //select producers by given country:
        //need data from the console
        public List<string> SelectProducersByGivenCountry(string country)
        {
            var producers = context.Producers.Select(x => new
            {
                x.Country,
                x.Name,
            }).Where(a => a.Country.ToLower() == country.ToLower()).ToList();
            List<string> producersNames = producers.Select(x => $"producer's name:{x.Name}").ToList();
            return producersNames;
        }

        //select songs from an album by given album name:
        //need data from the console
        //data used from 2 tables: Albums and Songs (one to many)
        public List<string> SelectSongsFromSpecificAlbum(string albumName)
        {
            var album = context.Albums.Include(a => a.Songs).FirstOrDefault(x => x.Title.ToLower() == albumName.ToLower());
            List<string> songNames = album.Songs.Select(x => $"songs's title:{x.Title}").ToList();
            return songNames;
        }

        //select songs from given artist name:
        //need data from the console
        //data used from 3 tables: Artists and Songs (many to many) with mapping table ArtistsSongs
        public List<string> SelectSongsFromSpecificArtist(string artistName)
        {
            var artist = context.Artists.Include(a => a.ArtistsSongs).ThenInclude(b => b.Song).FirstOrDefault(x => x.Name.ToLower() == artistName.ToLower());
            List<string> songNames = artist.ArtistsSongs.OrderBy(b => b.Song.ReleaseDate).Select(x => $"songs's title:{x.Song.Title}").ToList();
            return songNames;
        }

        //select users with their fav song:
        //data used from 2 tables: User and Songs (one to one)
        public List<string> SelectUserWithFavSong()
        {
            var users = context.Users.Select(x => new
            {
                Name = x.Username,
                FavSong = x.FavSong.Title
            }).ToList();
            List<string> usersInfo = users.OrderBy(b => b.FavSong).Select(c => $"user's name:{c.Name} - user's fav song:{c.FavSong}").ToList();
            return usersInfo;
        }

        //select users with their fav album:
        //data used from 2 tables: User and Albums (one to one)
        public List<string> SelectUserWithFavAlbum()
        {
            var users = context.Users.Select(x => new
            {
                Name = x.Username,
                FavAlbum = x.FavAlbum.Title
            }).ToList();
            List<string> usersInfo = users.OrderBy(b => b.FavAlbum).Select(c => $"user's name:{c.Name} - user's fav album:{c.FavAlbum}").ToList();
            return usersInfo;
        }

        //select users with their fav artist:
        //data used from 2 tables: User and Artists (one to one)
        public List<string> SelectUserWithFavArtists()
        {
            var users = context.Users.Select(x => new
            {
                Username = x.Username,
                FavArtist = x.FavArtist.Name
            }).ToList();
            List<string> usersInfo = users.OrderBy(b => b.FavArtist).Select(c => $"user's name:{c.Username} - user's fav artist:{c.FavArtist}").ToList();
            return usersInfo;
        }

        //select albums with their producers by given album name:
        //data used from 3 tables: Albums and Producers (many to many) with mapping table ProducersAlbums
        //need data from the console
        public List<string> SelectAlbumsAndTheirProducers(string albumName)
        {
            var albums = context.Albums.Include(a => a.ProducersAlbums).ThenInclude(b => b.Producer).Where(x => x.Title.ToLower() == albumName.ToLower()).ToList();
            List<string> albumsAndProducers = albums
                    .SelectMany(album => album.ProducersAlbums
                        .Select(pa => $"producer's name: {pa.Producer.Name}"))
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
                .Select(x => $"album's title:{album.Title} - artist's name:{x.Artist.Name}"))
                .ToList();
            return albumsAndArtists;
        }

        //select count of songs in every album:
        //data used from 2 tables: Songs and Albums (one to many)
        public List<string> SelectCountOfEveryTrackInEachAlbum()
        {
            var albums = context.Albums.Include(a => a.Songs).ToList();
            List<string> countOfSongs = albums.OrderBy(v => v.Songs.Count).Select(x => $"album's title:{x.Title} - song's count:{x.Songs.Count}").ToList();
            return countOfSongs;
        }
    }

}
