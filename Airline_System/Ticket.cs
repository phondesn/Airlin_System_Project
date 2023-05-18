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
using System.Data.Common;

namespace Airline_System
{
    public partial class Ticket : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");
        public Ticket()
        {
            InitializeComponent();
        }

        string pname, ppass, pnat, pgen;
        int page;


        private void populate()
        {
            con.Open();
            string query = "select * from TicketTbl where PassId = " + PassIdT.SelectedValue.ToString() + ";";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            adapter.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillPassenger()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(reader);
            PassIdT.ValueMember = "PassId";
            PassIdT.DataSource = dt;
            con.Close();
        }
        private void fetchPassenger()
        {
            //con.Open();
            string query = "select * from PassengerTbl where PassId=" + PassIdT.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNationality"].ToString();
                PassNameT.Text = pname;
                PassportT.Text = ppass;
                PassNatT.Text = pnat;
            }
            con.Close();
        }

        private void fillFlight()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(reader);
            FcodeT.ValueMember = "Fcode";
            FcodeT.DataSource = dt;
            con.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlight();
            populate();
        }
        private void Bookbtn_Click(object sender, EventArgs e)
        {
            if (TktId.Text == "" || PassNameT.Text == "")
            {
                MessageBox.Show("Missing Information! Please fill the information...");
            }
            else
            {
                try
                {
                    con.Open();
                    string insrt = "insert into TicketTbl values(" + TktId.Text + ", '" + FcodeT.SelectedValue.ToString() + "', '" + PassIdT.SelectedValue.ToString() + "', '" + PassNameT.Text + "', '" + PassportT.Text + "', '" + PassNatT.SelectedValue.ToString() + "', " + AmountT.Text + ")";
                    SqlCommand cmd = new SqlCommand(insrt, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully...");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            TktId.Text = "";
            FcodeT.Text = "";
            PassIdT.Text = "";
            PassNameT.Text = "";
            PassportT.Text = "";
            PassNatT.Text = "";
            AmountT.Text = "";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void PassIdT_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchPassenger();
        }
    }
}
