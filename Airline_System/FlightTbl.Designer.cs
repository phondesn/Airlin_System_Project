namespace Airline_System
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fcode = new TextBox();
            fcap = new TextBox();
            AddFlightButton = new Button();
            Resetbtn = new Button();
            SideImage = new PictureBox();
            label7 = new Label();
            fsrc = new ComboBox();
            fdest = new ComboBox();
            fdate = new DateTimePicker();
            Close = new Button();
            Fview = new Button();
            GoHomeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SideImage).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(300, 10);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 2;
            Title.Text = "Udaan Airline";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(290, 70);
            label1.Name = "label1";
            label1.Size = new Size(221, 27);
            label1.TabIndex = 3;
            label1.Text = "Register New Flight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(10, 200);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 4;
            label2.Text = "Flight Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(10, 400);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 5;
            label3.Text = "Number of Seats";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(10, 350);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 6;
            label4.Text = "Take Off Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(10, 300);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 7;
            label5.Text = "Destination";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(10, 250);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 8;
            label6.Text = "Source";
            // 
            // fcode
            // 
            fcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            fcode.BackColor = SystemColors.Info;
            fcode.Cursor = Cursors.IBeam;
            fcode.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fcode.ForeColor = Color.CornflowerBlue;
            fcode.HideSelection = false;
            fcode.Location = new Point(240, 194);
            fcode.Name = "fcode";
            fcode.Size = new Size(200, 32);
            fcode.TabIndex = 9;
            // 
            // fcap
            // 
            fcap.AutoCompleteMode = AutoCompleteMode.Suggest;
            fcap.BackColor = SystemColors.Info;
            fcap.Cursor = Cursors.IBeam;
            fcap.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fcap.ForeColor = Color.CornflowerBlue;
            fcap.HideSelection = false;
            fcap.Location = new Point(240, 397);
            fcap.Name = "fcap";
            fcap.Size = new Size(200, 32);
            fcap.TabIndex = 13;
            // 
            // AddFlightButton
            // 
            AddFlightButton.BackColor = Color.CornflowerBlue;
            AddFlightButton.Cursor = Cursors.Hand;
            AddFlightButton.FlatAppearance.BorderSize = 0;
            AddFlightButton.FlatStyle = FlatStyle.Flat;
            AddFlightButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddFlightButton.ForeColor = Color.LightSalmon;
            AddFlightButton.Location = new Point(48, 483);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(165, 41);
            AddFlightButton.TabIndex = 14;
            AddFlightButton.Text = "Add Flight";
            AddFlightButton.UseVisualStyleBackColor = false;
            AddFlightButton.Click += AddFlightButton_Click;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.CornflowerBlue;
            Resetbtn.Cursor = Cursors.Hand;
            Resetbtn.FlatAppearance.BorderSize = 0;
            Resetbtn.FlatStyle = FlatStyle.Flat;
            Resetbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Resetbtn.ForeColor = Color.LightSalmon;
            Resetbtn.Location = new Point(300, 483);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(165, 41);
            Resetbtn.TabIndex = 15;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // SideImage
            // 
            SideImage.Image = (Image)resources.GetObject("SideImage.Image");
            SideImage.Location = new Point(458, 178);
            SideImage.Name = "SideImage";
            SideImage.Size = new Size(330, 265);
            SideImage.SizeMode = PictureBoxSizeMode.StretchImage;
            SideImage.TabIndex = 16;
            SideImage.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 620);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 17;
            label7.Text = "@UdaanAirline";
            // 
            // fsrc
            // 
            fsrc.BackColor = SystemColors.Info;
            fsrc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fsrc.ForeColor = Color.CornflowerBlue;
            fsrc.FormattingEnabled = true;
            fsrc.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            fsrc.Location = new Point(240, 247);
            fsrc.Name = "fsrc";
            fsrc.Size = new Size(200, 31);
            fsrc.TabIndex = 18;
            // 
            // fdest
            // 
            fdest.BackColor = SystemColors.Info;
            fdest.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fdest.ForeColor = Color.CornflowerBlue;
            fdest.FormattingEnabled = true;
            fdest.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            fdest.Location = new Point(240, 292);
            fdest.Name = "fdest";
            fdest.Size = new Size(200, 31);
            fdest.TabIndex = 19;
            // 
            // fdate
            // 
            fdate.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fdate.CalendarForeColor = Color.CornflowerBlue;
            fdate.CalendarMonthBackground = SystemColors.Info;
            fdate.CalendarTitleForeColor = Color.CornflowerBlue;
            fdate.CalendarTrailingForeColor = Color.CornflowerBlue;
            fdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fdate.Location = new Point(240, 346);
            fdate.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            fdate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            fdate.Name = "fdate";
            fdate.Size = new Size(200, 28);
            fdate.TabIndex = 20;
            // 
            // Close
            // 
            Close.BackColor = Color.SeaShell;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(770, 0);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 21;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Fview
            // 
            Fview.BackColor = Color.CornflowerBlue;
            Fview.Cursor = Cursors.Hand;
            Fview.FlatAppearance.BorderSize = 0;
            Fview.FlatStyle = FlatStyle.Flat;
            Fview.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Fview.ForeColor = Color.LightSalmon;
            Fview.Location = new Point(549, 483);
            Fview.Name = "Fview";
            Fview.Size = new Size(165, 41);
            Fview.TabIndex = 22;
            Fview.Text = "View Flights";
            Fview.UseVisualStyleBackColor = false;
            Fview.Click += Fview_Click;
            // 
            // GoHomeBtn
            // 
            GoHomeBtn.BackColor = Color.CornflowerBlue;
            GoHomeBtn.Cursor = Cursors.Hand;
            GoHomeBtn.FlatAppearance.BorderSize = 0;
            GoHomeBtn.FlatStyle = FlatStyle.Flat;
            GoHomeBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GoHomeBtn.ForeColor = Color.LightSalmon;
            GoHomeBtn.Location = new Point(300, 550);
            GoHomeBtn.Name = "GoHomeBtn";
            GoHomeBtn.Size = new Size(165, 41);
            GoHomeBtn.TabIndex = 23;
            GoHomeBtn.Text = "Back";
            GoHomeBtn.UseVisualStyleBackColor = false;
            GoHomeBtn.Click += GoHomeBtn_Click;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 650);
            Controls.Add(GoHomeBtn);
            Controls.Add(Fview);
            Controls.Add(Close);
            Controls.Add(fdate);
            Controls.Add(fdest);
            Controls.Add(fsrc);
            Controls.Add(label7);
            Controls.Add(SideImage);
            Controls.Add(Resetbtn);
            Controls.Add(AddFlightButton);
            Controls.Add(fcap);
            Controls.Add(fcode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ((System.ComponentModel.ISupportInitialize)SideImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox fcode;
        private TextBox fcap;
        private Button AddFlightButton;
        private Button Resetbtn;
        private PictureBox SideImage;
        private Label label7;
        private ComboBox fsrc;
        private ComboBox fdest;
        private DateTimePicker fdate;
        private Button Close;
        private Button Fview;
        private Button GoHomeBtn;
    }
}