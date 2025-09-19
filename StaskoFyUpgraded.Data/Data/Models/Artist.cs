using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [Range(1, 2025)]
        public int DebutYear { get; set; }

        public ICollection<ArtistSong> ArtistsSongs { get; set; } = new List<ArtistSong>();

        public ICollection<ArtistAlbum> ArtistsAlbums { get; set; } = new List<ArtistAlbum>();
    }
}
