namespace Airline_System
{
    partial class Ticket
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
            label1 = new Label();
            Title = new Label();
            PassportT = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            TicketDGV = new DataGridView();
            PassNatT = new ComboBox();
            TktId = new TextBox();
            label7 = new Label();
            label10 = new Label();
            AmountT = new TextBox();
            FcodeT = new ComboBox();
            PassIdT = new ComboBox();
            Close = new Button();
            label11 = new Label();
            Backbtn = new Button();
            resetbtn = new Button();
            Bookbtn = new Button();
            PassNameT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)TicketDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(310, 70);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 44;
            label1.Text = "Ticket Booking";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(300, 10);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 43;
            Title.Text = "Udaan Airline";
            // 
            // PassportT
            // 
            PassportT.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassportT.BackColor = SystemColors.GradientInactiveCaption;
            PassportT.Cursor = Cursors.IBeam;
            PassportT.Enabled = false;
            PassportT.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassportT.ForeColor = Color.CornflowerBlue;
            PassportT.HideSelection = false;
            PassportT.Location = new Point(200, 229);
            PassportT.Name = "PassportT";
            PassportT.Size = new Size(200, 32);
            PassportT.TabIndex = 88;
            PassportT.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.CornflowerBlue;
            label9.Location = new Point(425, 229);
            label9.Name = "label9";
            label9.Size = new Size(115, 23);
            label9.TabIndex = 84;
            label9.Text = "Nationality";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(10, 229);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 82;
            label5.Text = "Passport";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(425, 184);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 81;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(425, 135);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 80;
            label3.Text = "Flight Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(10, 184);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 79;
            label6.Text = "Passenger Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(10, 135);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 78;
            label8.Text = "Ticket Id";
            // 
            // TicketDGV
            // 
            TicketDGV.BackgroundColor = Color.FloralWhite;
            TicketDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDGV.Location = new Point(30, 430);
            TicketDGV.Name = "TicketDGV";
            TicketDGV.ReadOnly = true;
            TicketDGV.RowHeadersWidth = 51;
            TicketDGV.RowTemplate.Height = 29;
            TicketDGV.Size = new Size(750, 238);
            TicketDGV.TabIndex = 73;
            // 
            // PassNatT
            // 
            PassNatT.BackColor = SystemColors.GradientInactiveCaption;
            PassNatT.Enabled = false;
            PassNatT.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassNatT.ForeColor = Color.CornflowerBlue;
            PassNatT.FormattingEnabled = true;
            PassNatT.Location = new Point(575, 230);
            PassNatT.Name = "PassNatT";
            PassNatT.Size = new Size(200, 31);
            PassNatT.TabIndex = 71;
            // 
            // TktId
            // 
            TktId.AutoCompleteMode = AutoCompleteMode.Suggest;
            TktId.BackColor = SystemColors.Info;
            TktId.Cursor = Cursors.IBeam;
            TktId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TktId.ForeColor = Color.CornflowerBlue;
            TktId.HideSelection = false;
            TktId.Location = new Point(200, 135);
            TktId.Name = "TktId";
            TktId.Size = new Size(200, 32);
            TktId.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 670);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 89;
            label7.Text = "@UdaanAirline";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.CornflowerBlue;
            label10.Location = new Point(270, 280);
            label10.Name = "label10";
            label10.Size = new Size(93, 23);
            label10.TabIndex = 90;
            label10.Text = "Amount ";
            // 
            // AmountT
            // 
            AmountT.AutoCompleteMode = AutoCompleteMode.Suggest;
            AmountT.BackColor = SystemColors.Info;
            AmountT.Cursor = Cursors.IBeam;
            AmountT.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AmountT.ForeColor = Color.CornflowerBlue;
            AmountT.HideSelection = false;
            AmountT.Location = new Point(420, 280);
            AmountT.Name = "AmountT";
            AmountT.Size = new Size(200, 32);
            AmountT.TabIndex = 91;
            // 
            // FcodeT
            // 
            FcodeT.BackColor = SystemColors.Info;
            FcodeT.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FcodeT.ForeColor = Color.CornflowerBlue;
            FcodeT.FormattingEnabled = true;
            FcodeT.Location = new Point(575, 136);
            FcodeT.Name = "FcodeT";
            FcodeT.Size = new Size(200, 31);
            FcodeT.TabIndex = 92;
            // 
            // PassIdT
            // 
            PassIdT.BackColor = SystemColors.Info;
            PassIdT.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PassIdT.ForeColor = Color.CornflowerBlue;
            PassIdT.FormattingEnabled = true;
            PassIdT.Location = new Point(200, 184);
            PassIdT.Name = "PassIdT";
            PassIdT.Size = new Size(200, 31);
            PassIdT.TabIndex = 93;
            PassIdT.SelectedIndexChanged += PassIdT_SelectedIndexChanged;
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
            Close.TabIndex = 94;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.LightSalmon;
            label11.Location = new Point(345, 385);
            label11.Name = "label11";
            label11.Size = new Size(113, 27);
            label11.TabIndex = 95;
            label11.Text = "Bookings";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.CornflowerBlue;
            Backbtn.Cursor = Cursors.Hand;
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.Snow;
            Backbtn.Location = new Point(580, 330);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(150, 40);
            Backbtn.TabIndex = 99;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.CornflowerBlue;
            resetbtn.Cursor = Cursors.Hand;
            resetbtn.FlatAppearance.BorderSize = 0;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.Snow;
            resetbtn.Location = new Point(320, 330);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(150, 40);
            resetbtn.TabIndex = 97;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // Bookbtn
            // 
            Bookbtn.BackColor = Color.CornflowerBlue;
            Bookbtn.Cursor = Cursors.Hand;
            Bookbtn.FlatAppearance.BorderSize = 0;
            Bookbtn.FlatStyle = FlatStyle.Flat;
            Bookbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Bookbtn.ForeColor = Color.Snow;
            Bookbtn.Location = new Point(60, 330);
            Bookbtn.Name = "Bookbtn";
            Bookbtn.Size = new Size(150, 40);
            Bookbtn.TabIndex = 96;
            Bookbtn.Text = "Book";
            Bookbtn.UseVisualStyleBackColor = false;
            Bookbtn.Click += Bookbtn_Click;
            // 
            // PassNameT
            // 
            PassNameT.AutoCompleteMode = AutoCompleteMode.Suggest;
            PassNameT.BackColor = SystemColors.GradientInactiveCaption;
            PassNameT.Cursor = Cursors.IBeam;
            PassNameT.Enabled = false;
            PassNameT.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PassNameT.ForeColor = Color.CornflowerBlue;
            PassNameT.HideSelection = false;
            PassNameT.Location = new Point(577, 184);
            PassNameT.Name = "PassNameT";
            PassNameT.Size = new Size(200, 32);
            PassNameT.TabIndex = 100;
            PassNameT.TextAlign = HorizontalAlignment.Right;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 700);
            Controls.Add(PassNameT);
            Controls.Add(Backbtn);
            Controls.Add(resetbtn);
            Controls.Add(Bookbtn);
            Controls.Add(label11);
            Controls.Add(Close);
            Controls.Add(PassIdT);
            Controls.Add(FcodeT);
            Controls.Add(AmountT);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(PassportT);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(TicketDGV);
            Controls.Add(PassNatT);
            Controls.Add(TktId);
            Controls.Add(label1);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)TicketDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Title;
        private TextBox PassportT;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label8;
        private DataGridView TicketDGV;
        private ComboBox PassNatT;
        private TextBox TktId;
        private Label label7;
        private Label label10;
        private TextBox AmountT;
        private ComboBox FcodeT;
        private ComboBox PassIdT;
        private Button Close;
        private Label label11;
        private Button Backbtn;
        private Button resetbtn;
        private Button Bookbtn;
        private TextBox PassNameT;
    }
}