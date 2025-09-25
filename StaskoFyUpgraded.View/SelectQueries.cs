using StaskoFyUpgraded.Core.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StaskoFyUpgraded.View
{
    public partial class SelectQueries : Form
    {
        private SelectQueriesController selectQueriesController = new SelectQueriesController();

        public SelectQueries()
        {
            InitializeComponent();
            comboBox1.Items.Add("Select artists by given country");
            comboBox1.Items.Add("Select producers by given country");
            comboBox1.Items.Add("Select songs from an album by given album name");
            comboBox1.Items.Add("Select songs from an artist by given artist name");
            comboBox1.Items.Add("Select current user with their fav song");
            comboBox1.Items.Add("Select current user with their fav album");
            comboBox1.Items.Add("Select current user with their fav artist");
            comboBox1.Items.Add("Select albums with their producers by given album name");
            comboBox1.Items.Add("Select albums with their artists");
            comboBox1.Items.Add("Select count of songs in every album");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string item = string.Empty;
            List<string> items = new List<string>();
            string selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "Select artists by given country")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectArtistsByGivenCountry(textBox1.Text);
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select producers by given country")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectProducersByGivenCountry(textBox1.Text);
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select songs from an album by given album name")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectSongsFromSpecificAlbum(textBox1.Text);
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select songs from an artist by given artist name")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectSongsFromSpecificArtist(textBox1.Text);
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select users with their fav song")
            {
                listBox1.Items.Clear();
                item = selectQueriesController.SelectCurrentUserWithFavSong();
                listBox1.Items.Add(item);
            }
            else if (selectedItem == "Select users with their fav album")
            {
                listBox1.Items.Clear();
                item = selectQueriesController.SelectCurrentUserWithFavAlbum();
                listBox1.Items.Add(item);
            }
            else if (selectedItem == "Select users with their fav artist")
            {
                listBox1.Items.Clear();
                item = selectQueriesController.SelectCurrentUserWithFavArtist();
                listBox1.Items.Add(item);
            }
            else if (selectedItem == "Select albums with their producers by given album name")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectAlbumsAndTheirProducers(textBox1.Text);
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select albums with their artists")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectAlbumsAndTheirArtists();
                items.ForEach(x => listBox1.Items.Add(x));
            }
            else if (selectedItem == "Select count of songs in every album")
            {
                listBox1.Items.Clear();
                items = selectQueriesController.SelectCountOfEveryTrackInEachAlbum();
                items.ForEach(x => listBox1.Items.Add(x));
            }
        }
    }
}
