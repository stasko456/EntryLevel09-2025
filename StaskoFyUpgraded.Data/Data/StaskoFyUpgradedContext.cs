using Microsoft.EntityFrameworkCore;
using StaskoFyUpgraded.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaskoFyUpgraded.Data.Data
{
    public class StaskoFyUpgradedContext : DbContext
    {
        public StaskoFyUpgradedContext() : base()
        {
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<ArtistSong> ArtistsSongs { get; set; }

        public DbSet<ArtistAlbum> ArtistsAlbums { get; set; }

        public DbSet<ProducerAlbum> ProducersAlbums { get; set; }

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<PlaylistSong> PlaylistsSongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User: if favs are deleted, set them null
            modelBuilder.Entity<User>()
                .HasOne(u => u.FavAlbum)
                .WithMany()
                .HasForeignKey(u => u.FavAlbumId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasOne(u => u.FavArtist)
                .WithMany()
                .HasForeignKey(u => u.FavArtistId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasOne(u => u.FavSong)
                .WithMany()
                .HasForeignKey(u => u.FavSongId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StaskoFy;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
