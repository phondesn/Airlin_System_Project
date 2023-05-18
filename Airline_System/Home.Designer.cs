namespace Airline_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            Close = new Button();
            Title = new Label();
            FlightBtn = new Button();
            Passbtn = new Button();
            Ticketbtn = new Button();
            Cancelbtn = new Button();
            label1 = new Label();
            Logo1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(Close);
            panel1.Controls.Add(Title);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.LightSalmon;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // Close
            // 
            Close.BackColor = Color.AntiqueWhite;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(770, 0);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 22;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(301, 45);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 2;
            Title.Text = "Udaan Airline";
            // 
            // FlightBtn
            // 
            FlightBtn.BackColor = Color.RoyalBlue;
            FlightBtn.FlatStyle = FlatStyle.Flat;
            FlightBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FlightBtn.ForeColor = Color.LightSalmon;
            FlightBtn.Location = new Point(40, 380);
            FlightBtn.Name = "FlightBtn";
            FlightBtn.Size = new Size(150, 40);
            FlightBtn.TabIndex = 3;
            FlightBtn.Text = "Flight";
            FlightBtn.UseVisualStyleBackColor = false;
            FlightBtn.Click += FlightBtn_Click;
            // 
            // Passbtn
            // 
            Passbtn.BackColor = Color.RoyalBlue;
            Passbtn.FlatStyle = FlatStyle.Flat;
            Passbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Passbtn.ForeColor = Color.LightSalmon;
            Passbtn.Location = new Point(230, 380);
            Passbtn.Name = "Passbtn";
            Passbtn.Size = new Size(150, 40);
            Passbtn.TabIndex = 4;
            Passbtn.Text = "Passenger";
            Passbtn.UseVisualStyleBackColor = false;
            Passbtn.Click += Passbtn_Click;
            // 
            // Ticketbtn
            // 
            Ticketbtn.BackColor = Color.RoyalBlue;
            Ticketbtn.FlatStyle = FlatStyle.Flat;
            Ticketbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Ticketbtn.ForeColor = Color.LightSalmon;
            Ticketbtn.Location = new Point(420, 380);
            Ticketbtn.Name = "Ticketbtn";
            Ticketbtn.Size = new Size(150, 40);
            Ticketbtn.TabIndex = 5;
            Ticketbtn.Text = "Ticket";
            Ticketbtn.UseVisualStyleBackColor = false;
            Ticketbtn.Click += Ticketbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.RoyalBlue;
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.ForeColor = Color.LightSalmon;
            Cancelbtn.Location = new Point(610, 380);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(150, 40);
            Cancelbtn.TabIndex = 6;
            Cancelbtn.Text = "Cancellation";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(340, 230);
            label1.Name = "label1";
            label1.Size = new Size(431, 37);
            label1.TabIndex = 3;
            label1.Text = "Serving the World's Travelers";
            // 
            // Logo1
            // 
            Logo1.Image = (Image)resources.GetObject("Logo1.Image");
            Logo1.Location = new Point(60, 160);
            Logo1.Name = "Logo1";
            Logo1.Size = new Size(290, 180);
            Logo1.SizeMode = PictureBoxSizeMode.Zoom;
            Logo1.TabIndex = 7;
            Logo1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 470);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 29;
            label7.Text = "@UdaanAirline";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 500);
            Controls.Add(label7);
            Controls.Add(Logo1);
            Controls.Add(label1);
            Controls.Add(Cancelbtn);
            Controls.Add(Ticketbtn);
            Controls.Add(Passbtn);
            Controls.Add(FlightBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Title;
        private Button FlightBtn;
        private Button Passbtn;
        private Button Ticketbtn;
        private Button Cancelbtn;
        private Label label1;
        private Button Close;
        private PictureBox Logo1;
        private Label label7;
    }
}