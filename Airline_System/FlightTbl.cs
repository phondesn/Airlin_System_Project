using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_System
{
    public partial class FlightTbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");
        public FlightTbl()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            if (fcode.Text == "" || fsrc.Text == "" || fdest.Text == "" || fdate.Text == "" || fcap.Text == "")
            {
                MessageBox.Show("Please fill the information");
            }
            else
            {
                try
                {
                    con.Open();
                    string insrt = "Insert into FlightTbl values('" + fcode.Text + "', '" + fsrc.SelectedItem.ToString() + "', '" + fdest.SelectedItem.ToString() + "', '" + fdate.Value.ToString() + "', '" + fcap.Text + "')";
                    SqlCommand cmd = new SqlCommand(insrt, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flighta Added Successfully...");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            fcode.Text = "";
            fsrc.Text = "";
            fdest.Text = "";
            fdate.Text = "";
            fcap.Text = "";
        }

        private void Fview_Click(object sender, EventArgs e)
        {
            ViewFlights viewFlights = new ViewFlights();
            viewFlights.Show();
            this.Hide();
        }

        private void GoHomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }
    }
}
