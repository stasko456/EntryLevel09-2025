using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class ArtistAlbum
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Artist))]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [Required]
        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
