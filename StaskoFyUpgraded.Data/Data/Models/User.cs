using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        //ne vseki ima lubim artist ne pi6i na maimunica
        [ForeignKey(nameof(Artist))]
        public int? FavArtistId { get; set; }
        public Artist FavArtist { get; set; }

        //ne vseki ima lubim album
        [ForeignKey(nameof(Album))]
        public int? FavAlbumId { get; set; }
        public Album FavAlbum { get; set; }

        //ne vseki ima lubima pesen
        [ForeignKey(nameof(Song))]
        public int? FavSongId { get; set; }
        public Song FavSong { get; set; }

        public ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
    }
}
