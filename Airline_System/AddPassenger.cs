using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Airline_System
{
    public partial class AddPassenger : Form
    {
        string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False";
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");

        public AddPassenger()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            if (PassId.Text == "" || PassName.Text == "" || Passport.Text == "" || PassPhone.Text == "")
            {
                MessageBox.Show("Please fill the information");
            }
            else
            {
                try
                {
                    con.Open();
                    string insrt = "Insert into PassengerTbl values('" + PassId.Text + "', '" + PassName.Text + "', '" + PassAdd.Text + "', '" + PassGen.SelectedItem + "', '" + PassPhone.Text + "', '" + PassNat.SelectedItem + "', '" + Passport.Text + "')";
                    SqlCommand cmd = new SqlCommand(insrt, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully...");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewPassengers_Click(object sender, EventArgs e)
        {
            ViewPassengers viewPass = new ViewPassengers();
            viewPass.Show();
            this.Hide();
        }

        private void GoHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
