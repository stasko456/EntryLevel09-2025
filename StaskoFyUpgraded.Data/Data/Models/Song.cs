using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Range(1, 9999)]
        public double Length { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        //non-reqired shtoto ne vsqka pesen e chast ot album 
        [ForeignKey(nameof(Album))]
        public int? AlbumId { get; set; }
        public Album Album { get; set; }

        //vsqka pesen ima genre
        [Required]
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<ArtistSong> ArtistsSongs { get; set; } = new List<ArtistSong>();

        public ICollection<PlaylistSong> PlaylistsSongs { get; set; } = new List<PlaylistSong>();
    }
}
