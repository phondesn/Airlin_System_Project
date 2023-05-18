namespace Airline_System
{
    partial class Login
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
            panel1 = new Panel();
            Logo = new Label();
            TagLine = new Label();
            Title = new Label();
            id = new Label();
            pass = new Label();
            Loginbtn = new Button();
            Resetbtn = new Button();
            uid = new TextBox();
            upass = new TextBox();
            Close = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(TagLine);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 400);
            panel1.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.AutoSize = true;
            Logo.Font = new Font("Blackadder ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Logo.ForeColor = Color.MistyRose;
            Logo.Location = new Point(40, 100);
            Logo.Name = "Logo";
            Logo.Size = new Size(210, 44);
            Logo.TabIndex = 6;
            Logo.Text = "Udaan Airline";
            // 
            // TagLine
            // 
            TagLine.AutoSize = true;
            TagLine.Font = new Font("Blackadder ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            TagLine.ForeColor = Color.MistyRose;
            TagLine.Location = new Point(30, 200);
            TagLine.Name = "TagLine";
            TagLine.Size = new Size(224, 44);
            TagLine.TabIndex = 5;
            TagLine.Text = "Udo Ji Bhar ke\r\n";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(375, 50);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 2;
            Title.Text = "Udaan Airline";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            id.ForeColor = Color.LightSalmon;
            id.Location = new Point(305, 160);
            id.Name = "id";
            id.Size = new Size(86, 27);
            id.TabIndex = 3;
            id.Text = "User Id";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pass.ForeColor = Color.LightSalmon;
            pass.Location = new Point(305, 240);
            pass.Name = "pass";
            pass.Size = new Size(115, 27);
            pass.TabIndex = 4;
            pass.Text = "Password";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.CornflowerBlue;
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.FlatAppearance.BorderSize = 0;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.MistyRose;
            Loginbtn.Location = new Point(330, 320);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(120, 40);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Resetbtn
            // 
            Resetbtn.BackColor = Color.CornflowerBlue;
            Resetbtn.Cursor = Cursors.Hand;
            Resetbtn.FlatAppearance.BorderSize = 0;
            Resetbtn.FlatStyle = FlatStyle.Flat;
            Resetbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Resetbtn.ForeColor = Color.MistyRose;
            Resetbtn.Location = new Point(500, 320);
            Resetbtn.Name = "Resetbtn";
            Resetbtn.Size = new Size(120, 40);
            Resetbtn.TabIndex = 6;
            Resetbtn.Text = "Reset";
            Resetbtn.UseVisualStyleBackColor = false;
            Resetbtn.Click += Resetbtn_Click;
            // 
            // uid
            // 
            uid.AutoCompleteMode = AutoCompleteMode.Suggest;
            uid.BackColor = SystemColors.Info;
            uid.Cursor = Cursors.IBeam;
            uid.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            uid.ForeColor = Color.LightSalmon;
            uid.HideSelection = false;
            uid.Location = new Point(438, 157);
            uid.Name = "uid";
            uid.Size = new Size(200, 36);
            uid.TabIndex = 7;
            // 
            // upass
            // 
            upass.BackColor = SystemColors.Info;
            upass.Cursor = Cursors.IBeam;
            upass.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            upass.ForeColor = Color.LightSalmon;
            upass.HideSelection = false;
            upass.Location = new Point(438, 237);
            upass.Name = "upass";
            upass.Size = new Size(200, 36);
            upass.TabIndex = 8;
            // 
            // Close
            // 
            Close.BackColor = Color.SeaShell;
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = Color.Red;
            Close.Location = new Point(620, 0);
            Close.Name = "Close";
            Close.Size = new Size(30, 30);
            Close.TabIndex = 9;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(650, 400);
            Controls.Add(Close);
            Controls.Add(upass);
            Controls.Add(uid);
            Controls.Add(Resetbtn);
            Controls.Add(Loginbtn);
            Controls.Add(pass);
            Controls.Add(id);
            Controls.Add(Title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Title;
        private Label id;
        private Label pass;
        private Button Loginbtn;
        private Button Resetbtn;
        private Label Logo;
        private Label TagLine;
        private TextBox uid;
        private TextBox upass;
        private Button Close;
    }
}