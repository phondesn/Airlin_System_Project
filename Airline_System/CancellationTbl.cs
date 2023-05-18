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
    public partial class CancellationTbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AirlineManagementSystem;Integrated Security=True;Pooling=False");
        public CancellationTbl()
        {
            InitializeComponent();
        }

        private void fillTicket()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(int));
            dt.Load(reader);
            TktIdC.ValueMember = "TId";
            TktIdC.DataSource = dt;
            con.Close();
        }
        private void fetchCode()
        {
            string query = "select * from TicketTbl where TId=" + TktIdC.SelectedValue.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FcodeC.Text = dr["Fcode"].ToString();
            }
            con.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            CanId.Text = "";
            TktIdC.Text = "";
            FcodeC.Text = "";

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Ticket tkt = new Ticket();
            tkt.Show();
            this.Hide();
        }

        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTicket();
        }

        private void TktIdC_SelectedValueChanged(object sender, EventArgs e)
        {
            fetchCode();
        }
    }
}
