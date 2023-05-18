namespace Airline_System
{
    partial class CancellationTbl
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
            Title = new Label();
            TktIdC = new ComboBox();
            FcodeC = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            CacelDGV = new DataGridView();
            CanId = new TextBox();
            label1 = new Label();
            label11 = new Label();
            label2 = new Label();
            Close = new Button();
            FdateC = new DateTimePicker();
            Backbtn = new Button();
            resetbtn = new Button();
            Cancelbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)CacelDGV).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(293, -38);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 94;
            Title.Text = "Udaan Airline";
            // 
            // TktIdC
            // 
            TktIdC.BackColor = SystemColors.Info;
            TktIdC.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TktIdC.ForeColor = Color.CornflowerBlue;
            TktIdC.FormattingEnabled = true;
            TktIdC.Location = new Point(570, 150);
            TktIdC.Name = "TktIdC";
            TktIdC.Size = new Size(200, 31);
            TktIdC.TabIndex = 113;
            TktIdC.SelectedValueChanged += TktIdC_SelectedValueChanged;
            // 
            // FcodeC
            // 
            FcodeC.AutoCompleteMode = AutoCompleteMode.Suggest;
            FcodeC.BackColor = SystemColors.Info;
            FcodeC.Cursor = Cursors.IBeam;
            FcodeC.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FcodeC.ForeColor = Color.CornflowerBlue;
            FcodeC.HideSelection = false;
            FcodeC.Location = new Point(200, 220);
            FcodeC.Name = "FcodeC";
            FcodeC.Size = new Size(200, 32);
            FcodeC.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.CornflowerBlue;
            label7.Location = new Point(660, 670);
            label7.Name = "label7";
            label7.Size = new Size(126, 19);
            label7.TabIndex = 110;
            label7.Text = "@UdaanAirline";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(420, 220);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 104;
            label4.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(10, 220);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 103;
            label3.Text = "Flight Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(420, 150);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 102;
            label6.Text = "Ticket Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.CornflowerBlue;
            label8.Location = new Point(10, 150);
            label8.Name = "label8";
            label8.Size = new Size(161, 23);
            label8.TabIndex = 101;
            label8.Text = "Cancellation Id";
            // 
            // CacelDGV
            // 
            CacelDGV.BackgroundColor = Color.FloralWhite;
            CacelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CacelDGV.Location = new Point(30, 400);
            CacelDGV.Name = "CacelDGV";
            CacelDGV.ReadOnly = true;
            CacelDGV.RowHeadersWidth = 51;
            CacelDGV.RowTemplate.Height = 29;
            CacelDGV.Size = new Size(750, 250);
            CacelDGV.TabIndex = 100;
            // 
            // CanId
            // 
            CanId.AutoCompleteMode = AutoCompleteMode.Suggest;
            CanId.BackColor = SystemColors.Info;
            CanId.Cursor = Cursors.IBeam;
            CanId.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CanId.ForeColor = Color.CornflowerBlue;
            CanId.HideSelection = false;
            CanId.Location = new Point(200, 150);
            CanId.Name = "CanId";
            CanId.Size = new Size(200, 32);
            CanId.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(310, 70);
            label1.Name = "label1";
            label1.Size = new Size(175, 27);
            label1.TabIndex = 96;
            label1.Text = "Ticket Booking";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.LightSalmon;
            label11.Location = new Point(300, 10);
            label11.Name = "label11";
            label11.Size = new Size(198, 34);
            label11.TabIndex = 95;
            label11.Text = "Udaan Airline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSalmon;
            label2.Location = new Point(300, 360);
            label2.Name = "label2";
            label2.Size = new Size(197, 27);
            label2.TabIndex = 115;
            label2.Text = "Cancellation List";
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
            Close.TabIndex = 116;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // FdateC
            // 
            FdateC.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FdateC.CalendarForeColor = Color.CornflowerBlue;
            FdateC.CalendarMonthBackground = SystemColors.Info;
            FdateC.CalendarTitleForeColor = Color.CornflowerBlue;
            FdateC.CalendarTrailingForeColor = Color.CornflowerBlue;
            FdateC.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FdateC.Location = new Point(570, 220);
            FdateC.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            FdateC.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            FdateC.Name = "FdateC";
            FdateC.Size = new Size(200, 28);
            FdateC.TabIndex = 117;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.CornflowerBlue;
            Backbtn.Cursor = Cursors.Hand;
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Backbtn.ForeColor = Color.Snow;
            Backbtn.Location = new Point(565, 290);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(150, 40);
            Backbtn.TabIndex = 120;
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
            resetbtn.Location = new Point(325, 290);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(150, 40);
            resetbtn.TabIndex = 119;
            resetbtn.Text = "Reset";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // Cancelbtn
            // 
            Cancelbtn.BackColor = Color.CornflowerBlue;
            Cancelbtn.Cursor = Cursors.Hand;
            Cancelbtn.FlatAppearance.BorderSize = 0;
            Cancelbtn.FlatStyle = FlatStyle.Flat;
            Cancelbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cancelbtn.ForeColor = Color.Snow;
            Cancelbtn.Location = new Point(85, 290);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(150, 40);
            Cancelbtn.TabIndex = 118;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = false;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // CancellationTbl
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 700);
            Controls.Add(Backbtn);
            Controls.Add(resetbtn);
            Controls.Add(Cancelbtn);
            Controls.Add(FdateC);
            Controls.Add(Close);
            Controls.Add(label2);
            Controls.Add(TktIdC);
            Controls.Add(FcodeC);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(CacelDGV);
            Controls.Add(CanId);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(Title);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "CancellationTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTbl";
            Load += CancellationTbl_Load;
            ((System.ComponentModel.ISupportInitialize)CacelDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private ComboBox TktIdC;
        private TextBox FcodeC;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label8;
        private DataGridView CacelDGV;
        private TextBox CanId;
        private Label label1;
        private Label label11;
        private Label label2;
        private Button Close;
        private DateTimePicker FdateC;
        private Button Backbtn;
        private Button resetbtn;
        private Button Cancelbtn;
    }
}