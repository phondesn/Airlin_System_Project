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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlightBtn_Click(object sender, EventArgs e)
        {
            FlightTbl flightTbl = new FlightTbl();
            flightTbl.Show();
            this.Hide();
        }

        private void Passbtn_Click(object sender, EventArgs e)
        {
            AddPassenger passengerTbl = new AddPassenger();
            passengerTbl.Show();
            this.Hide();
        }

        private void Ticketbtn_Click(object sender, EventArgs e)
        {
            Ticket ticketTbl = new Ticket();
            ticketTbl.Show();
            this.Hide();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            CancellationTbl cancel = new CancellationTbl();
            cancel.Show();
            this.Hide();
        }
    }
}
