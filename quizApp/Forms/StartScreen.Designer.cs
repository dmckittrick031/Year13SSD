namespace quizApp
{
    partial class StartScreen
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
            btnStartQuiz = new Button();
            panel2 = new Panel();
            btnQuit = new Button();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblLastScore = new Label();
            lblName = new Label();
            tbNameInput = new TextBox();
            rbCode = new RadioButton();
            rbICT = new RadioButton();
            lblSelectQuiz = new Label();
            flowSidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowSidebar
            // 
            flowSidebar.BackColor = Color.FromArgb(30, 40, 45);
            flowSidebar.Controls.Add(btnMenu);
            flowSidebar.Controls.Add(btnStartQuiz);
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
            // btnStartQuiz
            // 
            btnStartQuiz.FlatAppearance.BorderSize = 0;
            btnStartQuiz.FlatStyle = FlatStyle.Flat;
            btnStartQuiz.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartQuiz.ForeColor = Color.White;
            btnStartQuiz.Location = new Point(0, 101);
            btnStartQuiz.Margin = new Padding(0, 3, 3, 3);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(300, 55);
            btnStartQuiz.TabIndex = 3;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.TextAlign = ContentAlignment.MiddleLeft;
            btnStartQuiz.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnQuit);
            panel2.Location = new Point(3, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 763);
            panel2.TabIndex = 4;
            // 
            // btnQuit
            // 
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Location = new Point(0, 680);
            btnQuit.Margin = new Padding(0, 3, 3, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(300, 55);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.TextAlign = ContentAlignment.MiddleLeft;
            btnQuit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // tmrSidebar
            // 
            tmrSidebar.Interval = 1;
            tmrSidebar.Tick += tmrSidebar_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lblLastScore);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(tbNameInput);
            panel1.Controls.Add(rbCode);
            panel1.Controls.Add(rbICT);
            panel1.Controls.Add(lblSelectQuiz);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Bahnschrift", 40F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 900);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblLastScore
            // 
            lblLastScore.AutoSize = true;
            lblLastScore.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastScore.ForeColor = Color.FromArgb(30, 40, 45);
            lblLastScore.Location = new Point(691, 801);
            lblLastScore.Name = "lblLastScore";
            lblLastScore.Size = new Size(107, 24);
            lblLastScore.TabIndex = 5;
            lblLastScore.Text = "Last Score";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(30, 40, 45);
            lblName.Location = new Point(0, 801);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 24);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // tbNameInput
            // 
            tbNameInput.BackColor = Color.Silver;
            tbNameInput.BorderStyle = BorderStyle.None;
            tbNameInput.ForeColor = Color.FromArgb(30, 40, 45);
            tbNameInput.Location = new Point(3, 828);
            tbNameInput.Multiline = true;
            tbNameInput.Name = "tbNameInput";
            tbNameInput.Size = new Size(898, 65);
            tbNameInput.TabIndex = 3;
            // 
            // rbCode
            // 
            rbCode.AutoSize = true;
            rbCode.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            rbCode.ForeColor = Color.FromArgb(30, 40, 45);
            rbCode.Location = new Point(6, 135);
            rbCode.Name = "rbCode";
            rbCode.Size = new Size(217, 52);
            rbCode.TabIndex = 2;
            rbCode.TabStop = true;
            rbCode.Text = "Code Quiz";
            rbCode.UseVisualStyleBackColor = true;
            rbCode.CheckedChanged += rbCode_CheckedChanged;
            // 
            // rbICT
            // 
            rbICT.AutoSize = true;
            rbICT.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            rbICT.ForeColor = Color.FromArgb(30, 40, 45);
            rbICT.Location = new Point(6, 77);
            rbICT.Name = "rbICT";
            rbICT.Size = new Size(182, 52);
            rbICT.TabIndex = 1;
            rbICT.TabStop = true;
            rbICT.Text = "ICT Quiz";
            rbICT.UseVisualStyleBackColor = true;
            rbICT.CheckedChanged += rbICT_CheckedChanged;
            // 
            // lblSelectQuiz
            // 
            lblSelectQuiz.AutoSize = true;
            lblSelectQuiz.Font = new Font("Bahnschrift", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblSelectQuiz.ForeColor = Color.FromArgb(30, 40, 45);
            lblSelectQuiz.Location = new Point(3, 9);
            lblSelectQuiz.Name = "lblSelectQuiz";
            lblSelectQuiz.Size = new Size(422, 65);
            lblSelectQuiz.TabIndex = 0;
            lblSelectQuiz.Text = "Select Your Quiz";
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 900);
            Controls.Add(panel1);
            Controls.Add(flowSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartScreen";
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
        private Button btnQuit;
        private Panel panel1;
        private Label lblSelectQuiz;
        private RadioButton rbCode;
        private RadioButton rbICT;
        private TextBox tbNameInput;
        private Label lblName;
        private Label lblLastScore;
        private Button btnStartQuiz;
        private Panel panel2;
    }
}