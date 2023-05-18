namespace Airline_System
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            label7 = new Label();
            ResetButton = new Button();
            AddPassButton = new Button();
            PassPhone = new TextBox();
            PassId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Title = new Label();
            label8 = new Label();
            label9 = new Label();
            Passport = new TextBox();
            PassNat = new ComboBox();
            Close = new Button();
            PassGen = new ComboBox();
            pictureBox1 = new PictureBox();
            PassAdd = new TextBox();
            PassName = new TextBox();
            ViewPassengers = new Button();
            GoHomeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 670);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 33;
            label7.Text = "@UdaanAirline";
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.CornflowerBlue;
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.ForeColor = Color.LightSalmon;
            ResetButton.Location = new Point(280, 570);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(165, 40);
            ResetButton.TabIndex = 31;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // AddPassButton
            // 
            AddPassButton.BackColor = Color.CornflowerBlue;
            AddPassButton.Cursor = Cursors.Hand;
            AddPassButton.FlatAppearance.BorderSize = 0;
            AddPassButton.FlatStyle = FlatStyle.Flat;
            AddPassButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddPassButton.ForeColor = Color.LightSalmon;
            AddPassButton.Location = new Point(40, 570);
            AddPassButton.Name = "AddPassButton";
            AddPassButton.Size = new Size(165, 40);
            AddPassButton.TabIndex = 30;
            AddPassButton.Text = "Add Passenger";
            AddPassButton.UseVisualStyleBackColor = false;
            AddPassButton.Click += AddFlightButton_Click;
            // 
            // PassPhone
            // 
            PassPhone.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassPhone.BackColor = SystemColors.Info;
            PassPhone.Cursor = Cursors.IBeam;
            PassPhone.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassPhone.ForeColor = Color.CornflowerBlue;
            PassPhone.HideSelection = false;
            PassPhone.Location = new Point(250, 400);
            PassPhone.Name = "PassPhone";
            PassPhone.Size = new Size(200, 32);
            PassPhone.TabIndex = 29;
            // 
            // PassId
            // 
            PassId.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassId.BackColor = SystemColors.Info;
            PassId.Cursor = Cursors.IBeam;
            PassId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassId.ForeColor = Color.CornflowerBlue;
            PassId.HideSelection = false;
            PassId.Location = new Point(250, 200);
            PassId.Name = "PassId";
            PassId.Size = new Size(200, 32);
            PassId.TabIndex = 28;
            PassId.TextChanged += uid_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(15, 250);
            label6.Name = "label6";
            label6.Size = new Size(175, 23);
            label6.TabIndex = 27;
            label6.Text = "Passenger Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(15, 300);
            label5.Name = "label5";
            label5.Size = new Size(193, 23);
            label5.TabIndex = 26;
            label5.Text = "Passenger Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(15, 350);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 25;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(15, 400);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 24;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(15, 200);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 23;
            label2.Text = "Passenger Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(290, 70);
            label1.Name = "label1";
            label1.Size = new Size(235, 27);
            label1.TabIndex = 22;
            label1.Text = "Add New Passenger";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(301, 11);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 21;
            Title.Text = "Udaan Airline";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(15, 500);
            label8.Name = "label8";
            label8.Size = new Size(174, 23);
            label8.TabIndex = 37;
            label8.Text = "Passport Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(15, 450);
            label9.Name = "label9";
            label9.Size = new Size(115, 23);
            label9.TabIndex = 38;
            label9.Text = "Nationality";
            // 
            // Passport
            // 
            Passport.AutoCompleteMode = AutoCompleteMode.Suggest;
            Passport.BackColor = SystemColors.Info;
            Passport.Cursor = Cursors.IBeam;
            Passport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Passport.ForeColor = Color.CornflowerBlue;
            Passport.HideSelection = false;
            Passport.Location = new Point(250, 500);
            Passport.Name = "Passport";
            Passport.Size = new Size(200, 32);
            Passport.TabIndex = 39;
            // 
            // PassNat
            // 
            PassNat.BackColor = SystemColors.Info;
            PassNat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassNat.ForeColor = Color.CornflowerBlue;
            PassNat.FormattingEnabled = true;
            PassNat.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "AFGHANISTAN", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ARMENIA", "AUSTRALIA", "AUSTRIA", "AZERBAIJANARGENTINA", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BRAZIL", "BULGARIA", "BURKINA FASO", "BURUNDIBELGIUM", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE ISLANDS", "CHAD", "CHINA", "COLOMBIA", "CUBA", "CHILE", "CONGO", "COSTA RICA", "CROATIA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "ERITREA", "ESTONIA", "ETHIOPIA", "FIJI", "FINLAND", "FRANCE", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GREECE", "GRENADA", "GUATEMALA", "GUINEA", "GUYANA", "HAITI", "HONDURAS", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRELAND", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JORDAN", "KAZAKHSTAN", "KENYA", "KOREA (NORTH)", "KOREA (SOUTH)", "KUWAIT", "LATVIA", "LEBANON", "LIBERIA", "LIBYA", "LITHUANIA", "LUXEMBOURG", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MAURITANIA", "MAURITIUS", "MEXICO", "MONACO", "MONGOLIA", "MONTENEGRO", "MOROCCO", "MOZAMBIQUE", "NAMIBIA", "NEPAL", "NETHERLANDS", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NORWAY", "OMAN", "PAKISTAN", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "POLAND", "PORTUGAL", "QATAR", "ROMANIA", "RWANDA", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SWAZILAND", "SWEDEN", "SWITZERLAND", "TAIWAN", "TAJIKISTAN", "THAILAND", "TOGO", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "YEMEN", "ZAMBIA" });
            PassNat.Location = new Point(250, 450);
            PassNat.Name = "PassNat";
            PassNat.Size = new Size(200, 31);
            PassNat.TabIndex = 40;
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
            Close.TabIndex = 41;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // PassGen
            // 
            PassGen.BackColor = SystemColors.Info;
            PassGen.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassGen.ForeColor = Color.CornflowerBlue;
            PassGen.FormattingEnabled = true;
            PassGen.Items.AddRange(new object[] { "PLEASE SELECT FROM BELOW", "MALE", "FEMALE", "TRANSGENDER", "OTHER" });
            PassGen.Location = new Point(250, 350);
            PassGen.Name = "PassGen";
            PassGen.Size = new Size(200, 31);
            PassGen.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 363);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // PassAdd
            // 
            PassAdd.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassAdd.BackColor = SystemColors.Info;
            PassAdd.Cursor = Cursors.IBeam;
            PassAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassAdd.ForeColor = Color.CornflowerBlue;
            PassAdd.HideSelection = false;
            PassAdd.Location = new Point(250, 297);
            PassAdd.Name = "PassAdd";
            PassAdd.Size = new Size(200, 32);
            PassAdd.TabIndex = 44;
            // 
            // PassName
            // 
            PassName.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassName.BackColor = SystemColors.Info;
            PassName.Cursor = Cursors.IBeam;
            PassName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassName.ForeColor = Color.CornflowerBlue;
            PassName.HideSelection = false;
            PassName.Location = new Point(250, 247);
            PassName.Name = "PassName";
            PassName.Size = new Size(200, 32);
            PassName.TabIndex = 45;
            // 
            // ViewPassengers
            // 
            ViewPassengers.BackColor = Color.CornflowerBlue;
            ViewPassengers.Cursor = Cursors.Hand;
            ViewPassengers.FlatAppearance.BorderSize = 0;
            ViewPassengers.FlatStyle = FlatStyle.Flat;
            ViewPassengers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewPassengers.ForeColor = Color.LightSalmon;
            ViewPassengers.Location = new Point(520, 570);
            ViewPassengers.Name = "ViewPassengers";
            ViewPassengers.Size = new Size(185, 40);
            ViewPassengers.TabIndex = 46;
            ViewPassengers.Text = "View Passengers";
            ViewPassengers.UseVisualStyleBackColor = false;
            ViewPassengers.Click += ViewPassengers_Click;
            // 
            // GoHomeBtn
            // 
            GoHomeBtn.BackColor = Color.CornflowerBlue;
            GoHomeBtn.Cursor = Cursors.Hand;
            GoHomeBtn.FlatAppearance.BorderSize = 0;
            GoHomeBtn.FlatStyle = FlatStyle.Flat;
            GoHomeBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GoHomeBtn.ForeColor = Color.LightSalmon;
            GoHomeBtn.Location = new Point(280, 630);
            GoHomeBtn.Name = "GoHomeBtn";
            GoHomeBtn.Size = new Size(165, 41);
            GoHomeBtn.TabIndex = 47;
            GoHomeBtn.Text = "Back";
            GoHomeBtn.UseVisualStyleBackColor = false;
            GoHomeBtn.Click += GoHomeBtn_Click;
            // 
            // AddPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 700);
            Controls.Add(GoHomeBtn);
            Controls.Add(ViewPassengers);
            Controls.Add(PassName);
            Controls.Add(PassAdd);
            Controls.Add(pictureBox1);
            Controls.Add(PassGen);
            Controls.Add(Close);
            Controls.Add(PassNat);
            Controls.Add(Passport);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ResetButton);
            Controls.Add(AddPassButton);
            Controls.Add(PassPhone);
            Controls.Add(PassId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPassenger";
            Load += AddPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button ResetButton;
        private Button AddPassButton;
        private TextBox PassPhone;
        private TextBox PassId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label Title;
        private Label label8;
        private Label label9;
        private TextBox Passport;
        private ComboBox PassNat;
        private Button Close;
        private ComboBox PassGen;
        private PictureBox pictureBox1;
        private TextBox PassAdd;
        private TextBox PassName;
        private Button ViewPassengers;
        private Button GoHomeBtn;
    }
}