namespace AdventCalendarTask.Forms
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            progLoading = new ProgressBar();
            tmrLoading = new System.Windows.Forms.Timer(components);
            lblLoading = new Label();
            SuspendLayout();
            // 
            // progLoading
            // 
            progLoading.BackColor = Color.Black;
            progLoading.Dock = DockStyle.Bottom;
            progLoading.ForeColor = SystemColors.HotTrack;
            progLoading.Location = new Point(0, 427);
            progLoading.Name = "progLoading";
            progLoading.Size = new Size(800, 23);
            progLoading.Style = ProgressBarStyle.Continuous;
            progLoading.TabIndex = 0;
            progLoading.Click += progLoading_Click;
            // 
            // tmrLoading
            // 
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.BackColor = Color.Transparent;
            lblLoading.Dock = DockStyle.Bottom;
            lblLoading.Font = new Font("Bahnschrift", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoading.ForeColor = Color.White;
            lblLoading.Location = new Point(0, 350);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(306, 77);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading...";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgBlurred;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoading);
            Controls.Add(progLoading);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            Text = "SplashScreen";
            WindowState = FormWindowState.Maximized;
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private Label lblLoading;
    }
}