using StaskoFyUpgraded.Data.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaskoFyUpgraded.Core.Controllers;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.View
{
    public partial class MainMenu : Form
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenreController genreController = new GenreController();
            AlbumController albumController = new AlbumController();
            ArtistController artistController = new ArtistController();
            ProducerController producerController = new ProducerController();
            SongController songController = new SongController();
            UserController userController = new UserController();
            PlaylistController playlistController = new PlaylistController();
            ArtistSongController artistSongController = new ArtistSongController();
            ArtistAlbumController artistAlbumController = new ArtistAlbumController();
            ProducerAlbumController producerAlbumController = new ProducerAlbumController();
            PlaylistSongController playlistSongController = new PlaylistSongController();

            try
            {
                genreController.AddGenres();
                albumController.AddAlbums();
                artistController.AddArtists();
                producerController.AddProducers();
                songController.AddSongs();
                userController.AddUser();
                playlistController.AddPlaylists();
                artistSongController.AddArtistsSongs();
                artistAlbumController.AddArtistsAlbums();
                producerAlbumController.AddProducersAlbums();
                playlistSongController.AddPlaylistsSongs();
                MessageBox.Show("Data loaded to database succesfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string errorMessage = GetFullErrorMessage(ex);
                MessageBox.Show($"{errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFullErrorMessage(Exception ex)
        {
            string message = ex.Message;
            Exception inner = ex.InnerException;

            while (inner != null)
            {
                message += "\nInner: " + inner.Message;
                inner = inner.InnerException;
            }

            return message;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
            this.Hide();
        }
    }
}
