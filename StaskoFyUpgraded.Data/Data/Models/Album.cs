using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data.Models
{
    public class Album
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

        public ICollection<Song> Songs { get; set; } = new List<Song>();

        public ICollection<ArtistAlbum> ArtistsAlbums { get; set; } = new List<ArtistAlbum>();

        public ICollection<ProducerAlbum> ProducersAlbums { get; set; } = new List<ProducerAlbum>();
    }
}
