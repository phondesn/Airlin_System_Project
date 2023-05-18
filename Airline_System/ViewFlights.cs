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
    public partial class ViewFlights : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            FlightTbl flightTbl = new FlightTbl();
            flightTbl.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (fcode.Text == "" || fcap.Text == "")
            {
                MessageBox.Show("Missing Information, Please fill Information...");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FlightTbl set Fsrc='" + fsrc.SelectedItem.ToString() + "',FDest='" + fdest.SelectedItem.ToString() + "',FCap=" + fcap.Text + " where Fcode='" + fcode.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully...");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Missing Information...");
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            fcode.Text = "";
            fsrc.Text = "";
            fdest.Text = "";
            fdate.Text = "";
            fcap.Text = "";

        }

        private void delflighttbn_Click(object sender, EventArgs e)
        {
            if (fcode.Text == "")
            {
                MessageBox.Show("Enter Flight to Delete...");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from FlightTbl where Fcode='" + fcode.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully...");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
