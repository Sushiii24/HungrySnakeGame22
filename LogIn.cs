using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungry_Snake2._0
{
    public partial class LogIn : Form
    {
        private const string Username = "admin";
        private const string Password = "password";
        public LogIn()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = username_text.Text;
            string enteredPassword = password_text.Text;

            if (enteredUsername == Username && enteredPassword == Password)
            {
               MainGame mainGame= new MainGame();   
               mainGame.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup signup= new Signup();
            signup.Show();  
        }
    }
}
