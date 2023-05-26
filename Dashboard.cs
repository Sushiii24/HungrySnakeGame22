using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hungry_Snake2._0
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            LogIn logIn= new LogIn();   
            logIn.Show();   
        }

        private void playgamebtn_Click(object sender, EventArgs e)
        {
            LogIn logIn= new LogIn();
            logIn.Show();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup signup= new Signup();
            signup.Show(); 
        }
    }   

}
