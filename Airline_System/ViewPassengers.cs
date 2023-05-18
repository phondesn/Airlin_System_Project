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
    public partial class ViewPassengers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");
        public ViewPassengers()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from PassengerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            PassDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void ViewPassengers_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "")
            {
                MessageBox.Show("Enter Passenger to Delete...");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from PassengerTbl where PassId=" + PassId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfylly...");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            PassAdd.Text = "";
            PassGen.Text = "";
            PassNat.Text = "";
            Passport.Text = "";
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassName.Text == "" || PassAdd.Text == "" || Passport.Text == "")
            {
                MessageBox.Show("Missing Information, Please fill Information...");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update PassengerTbl set PassName='" + PassName.Text + "',PassAdd='" + PassAdd.Text + "',PassGender='" + PassGen.SelectedItem.ToString() + "',PassPhone='" + PassPhone.Text + "',PassNationality='" + PassNat.SelectedItem.ToString() + "',Passport='" + Passport.Text + "' where PassId=" + PassId.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully...");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Missing Information...");
                }
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            addPassenger.Show();
            this.Hide();
        }
    }
}
