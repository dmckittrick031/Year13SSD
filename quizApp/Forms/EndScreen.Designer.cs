namespace quizApp
{
    partial class EndScreen
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
            flowSidebar = new FlowLayoutPanel();
            btnMenu = new Button();
            panel2 = new Panel();
            btnRetry = new Button();
            btnQuit = new Button();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblScore = new Label();
            lblGameOver = new Label();
            flowSidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowSidebar
            // 
            flowSidebar.BackColor = Color.FromArgb(30, 40, 45);
            flowSidebar.Controls.Add(btnMenu);
            flowSidebar.Controls.Add(panel2);
            flowSidebar.Dock = DockStyle.Left;
            flowSidebar.Location = new Point(0, 0);
            flowSidebar.MaximumSize = new Size(300, 1000);
            flowSidebar.MinimumSize = new Size(70, 1000);
            flowSidebar.Name = "flowSidebar";
            flowSidebar.Size = new Size(70, 1000);
            flowSidebar.TabIndex = 0;
            flowSidebar.Paint += flowSidebar_Paint;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(0, 3);
            btnMenu.Margin = new Padding(0, 3, 3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(300, 92);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRetry);
            panel2.Controls.Add(btnQuit);
            panel2.Location = new Point(3, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 800);
            panel2.TabIndex = 4;
            // 
            // btnRetry
            // 
            btnRetry.FlatAppearance.BorderSize = 0;
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetry.ForeColor = Color.White;
            btnRetry.Location = new Point(0, 0);
            btnRetry.Margin = new Padding(0);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(300, 55);
            btnRetry.TabIndex = 4;
            btnRetry.Text = "Retry";
            btnRetry.TextAlign = ContentAlignment.MiddleLeft;
            btnRetry.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRetry.UseVisualStyleBackColor = true;
            btnRetry.Click += btnRetry_Click;
            // 
            // btnQuit
            // 
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(0, 741);
            btnQuit.Margin = new Padding(0, 3, 3, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(300, 55);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "Quit";
            btnQuit.TextAlign = ContentAlignment.MiddleLeft;
            btnQuit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click_1;
            // 
            // tmrSidebar
            // 
            tmrSidebar.Interval = 1;
            tmrSidebar.Tick += tmrSidebar_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lblScore);
            panel1.Controls.Add(lblGameOver);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Bahnschrift", 40F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 900);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Dock = DockStyle.Left;
            lblScore.Font = new Font("Bahnschrift", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.FromArgb(30, 40, 45);
            lblScore.Location = new Point(0, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(124, 45);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score:";
            lblScore.Click += lblScore_Click;
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.Font = new Font("Bahnschrift", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblGameOver.ForeColor = Color.FromArgb(100, 40, 45);
            lblGameOver.Location = new Point(272, 362);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(310, 65);
            lblGameOver.TabIndex = 0;
            lblGameOver.Text = "Game Over!";
            lblGameOver.Click += lblQuestionText_Click;
            // 
            // EndScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 900);
            Controls.Add(panel1);
            Controls.Add(flowSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EndScreen";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            flowSidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowSidebar;
        private Button btnMenu;
        private System.Windows.Forms.Timer tmrSidebar;
        private Panel panel1;
        private Label lblGameOver;
        private Panel panel2;
        private Button btnQuit;
        private Button btnRetry;
        private Label lblScore;
    }
}