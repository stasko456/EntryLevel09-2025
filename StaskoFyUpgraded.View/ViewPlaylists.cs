using Microsoft.EntityFrameworkCore;
using StaskoFyUpgraded.Core.Controllers;
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaskoFyUpgraded.View
{
    public partial class ViewPlaylists : Form
    {
        private SelectQueriesController selectQueriesController = new SelectQueriesController();
        private UserController userController = new UserController();
        StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public ViewPlaylists()
        {
            InitializeComponent();
            List<string> currentUserPlaylists = selectQueriesController.SelectCurrentUserPlaylists();
            currentUserPlaylists.ForEach(x => checkedListBox1.Items.Add(x));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 2)
            {
                MessageBox.Show("You can only check one playlist at a time!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string text = checkedListBox1.CheckedItems.ToString();
                string[] array = text.Split('-').ToArray();
                string playlistTitle = array.First().Trim();

                listBox1.Items.Add(selectQueriesController.SelectSongsNamesFromCurrentUserPlaylist(playlistTitle));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
