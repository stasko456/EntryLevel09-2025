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
using StaskoFyUpgraded.Data.Data;
using StaskoFyUpgraded.Data.Data.Models;

namespace StaskoFyUpgraded.View
{
    public partial class SignUp : Form
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();
        private UserController userController = new UserController();

        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string re_password = textBox3.Text;

            User user = new User
            {
                Username = username,
                Password = password,
            };

            if (user == null)
            {
                MessageBox.Show("User is null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (context.Users.Contains(user))
                {
                    MessageBox.Show("User already exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (password.Equals(re_password))
                    {
                        userController.AddUser(user);
                        MainMenu main = new MainMenu();
                        main.Show();
                        this.Hide();
                        Session.User = user;
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
