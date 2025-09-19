using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class Playlist
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
        public int SongCount { get; set; }

        // ne vseki user ima playlist
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<PlaylistSong> PlaylistsSongs { get; set; } = new List<PlaylistSong>();
    }
}
