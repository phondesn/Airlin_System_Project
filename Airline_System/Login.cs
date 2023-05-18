using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (uid.Text=="" || upass.Text=="")
            {
                MessageBox.Show("Please enter UserID and Password...");
            }
            else if (uid.Text=="admin" && upass.Text=="admin")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserId or Password. Enter valid UserID and Password...");
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            uid.Text = "";
            upass.Text = "";
        }
    }
}
