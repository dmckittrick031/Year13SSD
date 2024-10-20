namespace quizApp
{
    partial class GameScreen
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
            btnSubmit = new Button();
            btnQuit = new Button();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblQuestionNum = new Label();
            rbAnsFour = new RadioButton();
            rbAnsThree = new RadioButton();
            lblTimeRemaining = new Label();
            rbAnsTwo = new RadioButton();
            rbAnsOne = new RadioButton();
            lblQuestionText = new Label();
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
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(btnQuit);
            panel2.Location = new Point(3, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 800);
            panel2.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(-3, 3);
            btnSubmit.Margin = new Padding(0, 3, 3, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(300, 55);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Check";
            btnSubmit.TextAlign = ContentAlignment.MiddleLeft;
            btnSubmit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
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
            panel1.Controls.Add(lblQuestionNum);
            panel1.Controls.Add(rbAnsFour);
            panel1.Controls.Add(rbAnsThree);
            panel1.Controls.Add(lblTimeRemaining);
            panel1.Controls.Add(rbAnsTwo);
            panel1.Controls.Add(rbAnsOne);
            panel1.Controls.Add(lblQuestionText);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Bahnschrift", 40F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 900);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblQuestionNum
            // 
            lblQuestionNum.AutoSize = true;
            lblQuestionNum.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionNum.ForeColor = Color.FromArgb(30, 40, 45);
            lblQuestionNum.Location = new Point(6, 9);
            lblQuestionNum.Name = "lblQuestionNum";
            lblQuestionNum.Size = new Size(129, 24);
            lblQuestionNum.TabIndex = 8;
            lblQuestionNum.Text = "questionNum";
            // 
            // rbAnsFour
            // 
            rbAnsFour.AutoSize = true;
            rbAnsFour.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbAnsFour.ForeColor = Color.FromArgb(30, 40, 45);
            rbAnsFour.Location = new Point(501, 378);
            rbAnsFour.Name = "rbAnsFour";
            rbAnsFour.Size = new Size(83, 33);
            rbAnsFour.TabIndex = 7;
            rbAnsFour.TabStop = true;
            rbAnsFour.Text = "ans4";
            rbAnsFour.UseVisualStyleBackColor = true;
            rbAnsFour.CheckedChanged += rbAns_CheckedChanged;
            // 
            // rbAnsThree
            // 
            rbAnsThree.AutoSize = true;
            rbAnsThree.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbAnsThree.ForeColor = Color.FromArgb(30, 40, 45);
            rbAnsThree.Location = new Point(503, 221);
            rbAnsThree.Name = "rbAnsThree";
            rbAnsThree.Size = new Size(82, 33);
            rbAnsThree.TabIndex = 6;
            rbAnsThree.TabStop = true;
            rbAnsThree.Text = "ans3";
            rbAnsThree.UseVisualStyleBackColor = true;
            rbAnsThree.CheckedChanged += rbAnsThree_CheckedChanged;
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeRemaining.ForeColor = Color.FromArgb(30, 40, 45);
            lblTimeRemaining.Location = new Point(652, 9);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(153, 24);
            lblTimeRemaining.TabIndex = 5;
            lblTimeRemaining.Text = "Time Remaining";
            lblTimeRemaining.Click += lblTimeRemaining_Click;
            // 
            // rbAnsTwo
            // 
            rbAnsTwo.AutoSize = true;
            rbAnsTwo.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbAnsTwo.ForeColor = Color.FromArgb(30, 40, 45);
            rbAnsTwo.Location = new Point(20, 378);
            rbAnsTwo.Name = "rbAnsTwo";
            rbAnsTwo.Size = new Size(81, 33);
            rbAnsTwo.TabIndex = 2;
            rbAnsTwo.TabStop = true;
            rbAnsTwo.Text = "ans2";
            rbAnsTwo.UseVisualStyleBackColor = true;
            rbAnsTwo.CheckedChanged += rbCode_CheckedChanged;
            // 
            // rbAnsOne
            // 
            rbAnsOne.AutoSize = true;
            rbAnsOne.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbAnsOne.ForeColor = Color.FromArgb(30, 40, 45);
            rbAnsOne.Location = new Point(20, 221);
            rbAnsOne.Name = "rbAnsOne";
            rbAnsOne.Size = new Size(77, 33);
            rbAnsOne.TabIndex = 1;
            rbAnsOne.TabStop = true;
            rbAnsOne.Text = "ans1";
            rbAnsOne.UseVisualStyleBackColor = true;
            rbAnsOne.CheckedChanged += rbICT_CheckedChanged;
            // 
            // lblQuestionText
            // 
            lblQuestionText.AutoSize = true;
            lblQuestionText.Font = new Font("Bahnschrift", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestionText.ForeColor = Color.FromArgb(30, 40, 45);
            lblQuestionText.Location = new Point(0, 33);
            lblQuestionText.Name = "lblQuestionText";
            lblQuestionText.Size = new Size(213, 42);
            lblQuestionText.TabIndex = 0;
            lblQuestionText.Text = "questionText";
            lblQuestionText.Click += lblQuestionText_Click;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 900);
            Controls.Add(panel1);
            Controls.Add(flowSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameScreen";
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
        private Label lblQuestionText;
        private RadioButton rbAnsTwo;
        private RadioButton rbAnsOne;
        private Label lblTimeRemaining;
        private Panel panel2;
        private RadioButton rbAnsThree;
        private RadioButton rbAnsFour;
        private Button btnQuit;
        private Label lblQuestionNum;
        private Button btnSubmit;
    }
}