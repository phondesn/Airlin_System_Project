namespace Airline_System
{
    partial class ViewPassengers
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
            Close = new Button();
            Backbtn = new Button();
            Reset = new Button();
            Deletebtn = new Button();
            UpdateBTN = new Button();
            PageHeader = new Label();
            Title = new Label();
            PassGen = new ComboBox();
            PassNat = new ComboBox();
            label7 = new Label();
            PassId = new TextBox();
            label0 = new Label();
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            Passport = new TextBox();
            PassName = new TextBox();
            PassAdd = new TextBox();
            LogoHeader = new Label();
            button4 = new Button();
            label6 = new Label();
            PassPhone = new TextBox();
            PassDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PassDGV).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.BackColor = Color.SeaShell;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(765, -69);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 58;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.CornflowerBlue;
            Backbtn.Cursor = Cursors.Hand;
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.Snow;
            Backbtn.Location = new Point(625, 365);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(150, 40);
            Backbtn.TabIndex = 57;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.CornflowerBlue;
            Reset.Cursor = Cursors.Hand;
            Reset.FlatAppearance.BorderSize = 0;
            Reset.FlatStyle = FlatStyle.Flat;
            Reset.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Reset.ForeColor = Color.Snow;
            Reset.Location = new Point(425, 365);
            Reset.Name = "Reset";
            Reset.Size = new Size(150, 40);
            Reset.TabIndex = 56;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.CornflowerBlue;
            Deletebtn.Cursor = Cursors.Hand;
            Deletebtn.FlatAppearance.BorderSize = 0;
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deletebtn.ForeColor = Color.Snow;
            Deletebtn.Location = new Point(225, 365);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(150, 40);
            Deletebtn.TabIndex = 55;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // UpdateBTN
            // 
            UpdateBTN.BackColor = Color.CornflowerBlue;
            UpdateBTN.Cursor = Cursors.Hand;
            UpdateBTN.FlatAppearance.BorderSize = 0;
            UpdateBTN.FlatStyle = FlatStyle.Flat;
            UpdateBTN.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBTN.ForeColor = Color.Snow;
            UpdateBTN.Location = new Point(25, 365);
            UpdateBTN.Name = "UpdateBTN";
            UpdateBTN.Size = new Size(150, 40);
            UpdateBTN.TabIndex = 54;
            UpdateBTN.Text = "Update ";
            UpdateBTN.UseVisualStyleBackColor = false;
            UpdateBTN.Click += UpdateBTN_Click;
            // 
            // PageHeader
            // 
            PageHeader.AutoSize = true;
            PageHeader.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PageHeader.ForeColor = Color.LightSalmon;
            PageHeader.Location = new Point(310, 70);
            PageHeader.Name = "PageHeader";
            PageHeader.Size = new Size(165, 27);
            PageHeader.TabIndex = 52;
            PageHeader.Text = "Passenger List";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(295, -59);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 51;
            Title.Text = "Udaan Airline";
            // 
            // PassGen
            // 
            PassGen.BackColor = SystemColors.Info;
            PassGen.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassGen.ForeColor = Color.CornflowerBlue;
            PassGen.FormattingEnabled = true;
            PassGen.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "MALE", "FEMALE", "TRANSGENDER", "OTHER" });
            PassGen.Location = new Point(590, 201);
            PassGen.Name = "PassGen";
            PassGen.Size = new Size(200, 31);
            PassGen.TabIndex = 49;
            // 
            // PassNat
            // 
            PassNat.BackColor = SystemColors.Info;
            PassNat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassNat.ForeColor = Color.CornflowerBlue;
            PassNat.FormattingEnabled = true;
            PassNat.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            PassNat.Location = new Point(590, 250);
            PassNat.Name = "PassNat";
            PassNat.Size = new Size(200, 31);
            PassNat.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 670);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 47;
            label7.Text = "@UdaanAirline";
            // 
            // PassId
            // 
            PassId.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassId.BackColor = SystemColors.Info;
            PassId.Cursor = Cursors.IBeam;
            PassId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassId.ForeColor = Color.CornflowerBlue;
            PassId.HideSelection = false;
            PassId.Location = new Point(210, 150);
            PassId.Name = "PassId";
            PassId.Size = new Size(200, 32);
            PassId.TabIndex = 45;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label0.ForeColor = Color.CornflowerBlue;
            label0.Location = new Point(10, 150);
            label0.Name = "label0";
            label0.Size = new Size(134, 23);
            label0.TabIndex = 59;
            label0.Text = "Passenger Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(10, 200);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 60;
            label1.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(425, 250);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 65;
            label5.Text = "Nationality";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(10, 250);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 63;
            label2.Text = "Passport";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(425, 200);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 62;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(425, 150);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 61;
            label3.Text = "Name";
            // 
            // Passport
            // 
            Passport.AutoCompleteMode = AutoCompleteMode.Suggest;
            Passport.BackColor = SystemColors.Info;
            Passport.Cursor = Cursors.IBeam;
            Passport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Passport.ForeColor = Color.CornflowerBlue;
            Passport.HideSelection = false;
            Passport.Location = new Point(210, 250);
            Passport.Name = "Passport";
            Passport.Size = new Size(200, 32);
            Passport.TabIndex = 67;
            // 
            // PassName
            // 
            PassName.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassName.BackColor = SystemColors.Info;
            PassName.Cursor = Cursors.IBeam;
            PassName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassName.ForeColor = Color.CornflowerBlue;
            PassName.HideSelection = false;
            PassName.Location = new Point(590, 150);
            PassName.Name = "PassName";
            PassName.Size = new Size(200, 32);
            PassName.TabIndex = 68;
            // 
            // PassAdd
            // 
            PassAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassAdd.BackColor = SystemColors.Info;
            PassAdd.Cursor = Cursors.IBeam;
            PassAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassAdd.ForeColor = Color.CornflowerBlue;
            PassAdd.HideSelection = false;
            PassAdd.Location = new Point(210, 201);
            PassAdd.Name = "PassAdd";
            PassAdd.Size = new Size(200, 32);
            PassAdd.TabIndex = 69;
            // 
            // LogoHeader
            // 
            LogoHeader.AutoSize = true;
            LogoHeader.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogoHeader.ForeColor = Color.LightSalmon;
            LogoHeader.Location = new Point(300, 10);
            LogoHeader.Name = "LogoHeader";
            LogoHeader.Size = new Size(198, 34);
            LogoHeader.TabIndex = 70;
            LogoHeader.Text = "Udaan Airline";
            // 
            // button4
            // 
            button4.BackColor = Color.SeaShell;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(770, 0);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 71;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(255, 315);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 72;
            label6.Text = "Phone Number";
            // 
            // PassPhone
            // 
            PassPhone.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassPhone.BackColor = SystemColors.Info;
            PassPhone.Cursor = Cursors.IBeam;
            PassPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassPhone.ForeColor = Color.CornflowerBlue;
            PassPhone.HideSelection = false;
            PassPhone.Location = new Point(425, 312);
            PassPhone.Name = "PassPhone";
            PassPhone.Size = new Size(200, 32);
            PassPhone.TabIndex = 73;
            // 
            // PassDGV
            // 
            PassDGV.BackgroundColor = Color.Linen;
            PassDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassDGV.Location = new Point(10, 420);
            PassDGV.Name = "PassDGV";
            PassDGV.ReadOnly = true;
            PassDGV.RowHeadersWidth = 51;
            PassDGV.RowTemplate.Height = 29;
            PassDGV.Size = new Size(780, 240);
            PassDGV.TabIndex = 74;
            // 
            // ViewPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 700);
            Controls.Add(PassDGV);
            Controls.Add(PassPhone);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(LogoHeader);
            Controls.Add(PassAdd);
            Controls.Add(PassName);
            Controls.Add(Passport);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label0);
            Controls.Add(Close);
            Controls.Add(Backbtn);
            Controls.Add(Reset);
            Controls.Add(Deletebtn);
            Controls.Add(UpdateBTN);
            Controls.Add(PageHeader);
            Controls.Add(Title);
            Controls.Add(PassGen);
            Controls.Add(PassNat);
            Controls.Add(label7);
            Controls.Add(PassId);
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPassengers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPassengers";
            Load += ViewPassengers_Load;
            ((System.ComponentModel.ISupportInitialize)PassDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Button Backbtn;
        private Button Reset;
        private Button Deletebtn;
        private Button UpdateBTN;
        private Label PageHeader;
        private Label Title;
        private ComboBox PassGen;
        private ComboBox PassNat;
        private Label label7;
        private TextBox PassId;
        private Label label0;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox Passport;
        private TextBox PassName;
        private TextBox PassAdd;
        private Label LogoHeader;
        private Button button4;
        private Label label6;
        private TextBox PassPhone;
        private DataGridView PassDGV;
    }
}