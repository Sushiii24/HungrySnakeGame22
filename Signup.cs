using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hungry_Snake2._0
{
    public partial class Signup : Form
    {

        public Signup()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordlbl_Click(object sender, EventArgs e)
        {

        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void bar1_Click(object sender, EventArgs e)
        {

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {

        }


        private void signupbtn_Click(object sender, EventArgs e)
        {
            string username = usernamelbl.Text;
            string password = passwordlbl.Text;
            string confirmpass = confirmtext.Text;
            string enteremail = emailtxt.Text;
            

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                LogIn logIn= new LogIn();
                logIn.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password.");
            }

        }
    }
}
