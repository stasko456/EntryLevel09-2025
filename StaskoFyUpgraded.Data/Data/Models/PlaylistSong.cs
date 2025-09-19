using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class PlaylistSong
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Playlist))]
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }

        [Required]
        [ForeignKey(nameof(Song))]
        public int SongId { get; set; }
        public Song Song { get; set; }
    }
}
