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
    public partial class LogIn : Form
    {
        private StaskoFyUpgradedContext context = new StaskoFyUpgradedContext();

        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            User user = context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                if (!context.Users.Contains(user))
                {
                    MessageBox.Show("User does not exists!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Session.User = user;
                    MainMenu main = new MainMenu();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("User is null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
