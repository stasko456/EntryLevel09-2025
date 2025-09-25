using StaskoFyUpgraded.Core.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaskoFyUpgraded.View
{
    public partial class UpdateUser : Form
    {
        private UserController userController = new UserController();

        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string favArtistId = "";
            string favAlbumId = "";
            string favSongId = "";
            if (textBox8.Text != "Enter your new name:" !|| !string.IsNullOrEmpty(textBox8.Text))
            {
                username = textBox8.Text;
            }
            if (textBox9.Text != "Enter your new password:" !|| string.IsNullOrEmpty(textBox9.Text))
            {
                password = textBox8.Text;
            }
            if (textBox10.Text != "Enter your fav artist id:" !|| string.IsNullOrEmpty(textBox10.Text))
            {
                favArtistId = textBox10.Text;
            }
            if (textBox11.Text != "Enter your fav album id:" !|| string.IsNullOrEmpty(textBox11.Text))
            {
                favAlbumId = textBox11.Text;
            }
            if (textBox12.Text != "Enter your fav song id:" !|| string.IsNullOrEmpty(textBox12.Text))
            {
                favSongId = textBox12.Text;
            }
            userController.UpdateCurrentUser(username, password, favArtistId, favAlbumId, favSongId);
            MessageBox.Show("Successfuly updated your account!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
