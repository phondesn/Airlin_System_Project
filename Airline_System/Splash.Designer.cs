namespace Airline_System
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            BackgroundImage = new PictureBox();
            Title = new Label();
            MyProgress = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)BackgroundImage).BeginInit();
            SuspendLayout();
            // 
            // BackgroundImage
            // 
            BackgroundImage.BackColor = SystemColors.ControlLightLight;
            BackgroundImage.Image = (Image)resources.GetObject("BackgroundImage.Image");
            BackgroundImage.Location = new Point(0, 80);
            BackgroundImage.Margin = new Padding(3, 4, 3, 4);
            BackgroundImage.Name = "BackgroundImage";
            BackgroundImage.Size = new Size(800, 450);
            BackgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImage.TabIndex = 0;
            BackgroundImage.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.LightSalmon;
            Title.Location = new Point(300, 25);
            Title.Name = "Title";
            Title.Size = new Size(198, 34);
            Title.TabIndex = 1;
            Title.Text = "Udaan Airline";
            // 
            // MyProgress
            // 
            MyProgress.BackColor = Color.WhiteSmoke;
            MyProgress.ForeColor = Color.OrangeRed;
            MyProgress.Location = new Point(0, 530);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(800, 20);
            MyProgress.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 550);
            Controls.Add(MyProgress);
            Controls.Add(Title);
            Controls.Add(BackgroundImage);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BackgroundImage;
        private Label Title;
        private ProgressBar MyProgress;
        private System.Windows.Forms.Timer timer1;
    }
}