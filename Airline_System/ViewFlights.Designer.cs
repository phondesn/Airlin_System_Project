namespace Airline_System
{
    partial class ViewFlights
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
            fdate = new DateTimePicker();
            fdest = new ComboBox();
            fsrc = new ComboBox();
            label7 = new Label();
            fcap = new TextBox();
            fcode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Title = new Label();
            FlightDGV = new DataGridView();
            updatebtn = new Button();
            resetbtn = new Button();
            delflighttbn = new Button();
            Backbtn = new Button();
            Close = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            SuspendLayout();
            // 
            // fdate
            // 
            fdate.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fdate.CalendarForeColor = Color.CornflowerBlue;
            fdate.CalendarMonthBackground = SystemColors.Info;
            fdate.CalendarTitleForeColor = Color.CornflowerBlue;
            fdate.CalendarTrailingForeColor = Color.CornflowerBlue;
            fdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fdate.Location = new Point(580, 150);
            fdate.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            fdate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            fdate.Name = "fdate";
            fdate.Size = new Size(200, 28);
            fdate.TabIndex = 31;
            // 
            // fdest
            // 
            fdest.BackColor = SystemColors.Info;
            fdest.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fdest.ForeColor = Color.CornflowerBlue;
            fdest.FormattingEnabled = true;
            fdest.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            fdest.Location = new Point(580, 200);
            fdest.Name = "fdest";
            fdest.Size = new Size(200, 31);
            fdest.TabIndex = 30;
            // 
            // fsrc
            // 
            fsrc.BackColor = SystemColors.Info;
            fsrc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fsrc.ForeColor = Color.CornflowerBlue;
            fsrc.FormattingEnabled = true;
            fsrc.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            fsrc.Location = new Point(190, 200);
            fsrc.Name = "fsrc";
            fsrc.Size = new Size(200, 31);
            fsrc.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 570);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 28;
            label7.Text = "@UdaanAirline";
            // 
            // fcap
            // 
            fcap.AutoCompleteMode = AutoCompleteMode.Suggest;
            fcap.BackColor = SystemColors.Info;
            fcap.Cursor = Cursors.IBeam;
            fcap.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fcap.ForeColor = Color.CornflowerBlue;
            fcap.HideSelection = false;
            fcap.Location = new Point(420, 250);
            fcap.Name = "fcap";
            fcap.Size = new Size(200, 32);
            fcap.TabIndex = 27;
            // 
            // fcode
            // 
            fcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            fcode.BackColor = SystemColors.Info;
            fcode.Cursor = Cursors.IBeam;
            fcode.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fcode.ForeColor = Color.CornflowerBlue;
            fcode.HideSelection = false;
            fcode.Location = new Point(190, 150);
            fcode.Name = "fcode";
            fcode.Size = new Size(200, 32);
            fcode.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(10, 200);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 25;
            label6.Text = "Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(410, 200);
            label5.Name = "label5";
            label5.Size = new Size(118, 23);
            label5.TabIndex = 24;
            label5.Text = "Destination";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(410, 150);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 23;
            label4.Text = "Take Off Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(210, 250);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 22;
            label3.Text = "Number of Seats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(10, 150);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 21;
            label2.Text = "Flight Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(300, 70);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 33;
            label1.Text = "Scheduled Flights";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(300, 10);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 32;
            Title.Text = "Udaan Airline";
            // 
            // FlightDGV
            // 
            FlightDGV.BackgroundColor = Color.FloralWhite;
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightDGV.Location = new Point(25, 371);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.ReadOnly = true;
            FlightDGV.RowHeadersWidth = 51;
            FlightDGV.RowTemplate.Height = 29;
            FlightDGV.Size = new Size(750, 196);
            FlightDGV.TabIndex = 34;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.CornflowerBlue;
            updatebtn.Cursor = Cursors.Hand;
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.ForeColor = Color.Snow;
            updatebtn.Location = new Point(25, 315);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(150, 40);
            updatebtn.TabIndex = 35;
            updatebtn.Text = "Update Flight";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.CornflowerBlue;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.Snow;
            resetbtn.Location = new Point(225, 315);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(150, 40);
            resetbtn.TabIndex = 36;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // delflighttbn
            // 
            delflighttbn.BackColor = Color.CornflowerBlue;
            delflighttbn.Cursor = Cursors.Hand;
            delflighttbn.FlatAppearance.BorderSize = 0;
            delflighttbn.FlatStyle = FlatStyle.Flat;
            delflighttbn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            delflighttbn.ForeColor = Color.Snow;
            delflighttbn.Location = new Point(425, 315);
            delflighttbn.Name = "delflighttbn";
            delflighttbn.Size = new Size(150, 40);
            delflighttbn.TabIndex = 37;
            delflighttbn.Text = "Delete Flight";
            delflighttbn.UseVisualStyleBackColor = false;
            delflighttbn.Click += delflighttbn_Click;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.CornflowerBlue;
            Backbtn.Cursor = Cursors.Hand;
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.Snow;
            Backbtn.Location = new Point(625, 315);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(150, 40);
            Backbtn.TabIndex = 38;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
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
            Close.TabIndex = 39;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 600);
            Controls.Add(Close);
            Controls.Add(Backbtn);
            Controls.Add(delflighttbn);
            Controls.Add(resetbtn);
            Controls.Add(updatebtn);
            Controls.Add(FlightDGV);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(fdate);
            Controls.Add(fdest);
            Controls.Add(fsrc);
            Controls.Add(label7);
            Controls.Add(fcap);
            Controls.Add(fcode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker fdate;
        private ComboBox fdest;
        private ComboBox fsrc;
        private Label label7;
        private TextBox fcap;
        private TextBox fcode;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Title;
        private DataGridView FlightDGV;
        private Button updatebtn;
        private Button resetbtn;
        private Button delflighttbn;
        private Button Backbtn;
        private Button Close;
    }
}