namespace Airline_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int StartPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartPoint += 1;
            MyProgress.Value = StartPoint;
            if (MyProgress.Value == 50)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}