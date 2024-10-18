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
            this.components = new System.ComponentModel.Container();
            this.flowSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.rbAns = new System.Windows.Forms.RadioButton();
            this.rbAnsThree = new System.Windows.Forms.RadioButton();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.rbAnsTwo = new System.Windows.Forms.RadioButton();
            this.rbAnsOne = new System.Windows.Forms.RadioButton();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.flowSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowSidebar
            // 
            this.flowSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowSidebar.Controls.Add(this.btnMenu);
            this.flowSidebar.Controls.Add(this.panel2);
            this.flowSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowSidebar.Location = new System.Drawing.Point(0, 0);
            this.flowSidebar.MaximumSize = new System.Drawing.Size(300, 1000);
            this.flowSidebar.MinimumSize = new System.Drawing.Size(70, 1000);
            this.flowSidebar.Name = "flowSidebar";
            this.flowSidebar.Size = new System.Drawing.Size(70, 1000);
            this.flowSidebar.TabIndex = 0;
            this.flowSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowSidebar_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 3);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(300, 92);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Location = new System.Drawing.Point(3, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 800);
            this.panel2.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(0, 741);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(300, 55);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 1;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.lblQuestionNum);
            this.panel1.Controls.Add(this.rbAns);
            this.panel1.Controls.Add(this.rbAnsThree);
            this.panel1.Controls.Add(this.lblTimeRemaining);
            this.panel1.Controls.Add(this.rbAnsTwo);
            this.panel1.Controls.Add(this.rbAnsOne);
            this.panel1.Controls.Add(this.lblQuestionText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 881);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionNum.Location = new System.Drawing.Point(6, 9);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(129, 24);
            this.lblQuestionNum.TabIndex = 8;
            this.lblQuestionNum.Text = "questionNum";
            // 
            // rbAns
            // 
            this.rbAns.AutoSize = true;
            this.rbAns.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAns.ForeColor = System.Drawing.Color.White;
            this.rbAns.Location = new System.Drawing.Point(503, 279);
            this.rbAns.Name = "rbAns";
            this.rbAns.Size = new System.Drawing.Size(125, 52);
            this.rbAns.TabIndex = 7;
            this.rbAns.TabStop = true;
            this.rbAns.Text = "ans4";
            this.rbAns.UseVisualStyleBackColor = true;
            this.rbAns.CheckedChanged += new System.EventHandler(this.rbAns_CheckedChanged);
            // 
            // rbAnsThree
            // 
            this.rbAnsThree.AutoSize = true;
            this.rbAnsThree.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAnsThree.ForeColor = System.Drawing.Color.White;
            this.rbAnsThree.Location = new System.Drawing.Point(503, 221);
            this.rbAnsThree.Name = "rbAnsThree";
            this.rbAnsThree.Size = new System.Drawing.Size(123, 52);
            this.rbAnsThree.TabIndex = 6;
            this.rbAnsThree.TabStop = true;
            this.rbAnsThree.Text = "ans3";
            this.rbAnsThree.UseVisualStyleBackColor = true;
            this.rbAnsThree.CheckedChanged += new System.EventHandler(this.rbAnsThree_CheckedChanged);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeRemaining.Location = new System.Drawing.Point(706, 9);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(153, 24);
            this.lblTimeRemaining.TabIndex = 5;
            this.lblTimeRemaining.Text = "Time Remaining";
            // 
            // rbAnsTwo
            // 
            this.rbAnsTwo.AutoSize = true;
            this.rbAnsTwo.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAnsTwo.ForeColor = System.Drawing.Color.White;
            this.rbAnsTwo.Location = new System.Drawing.Point(224, 279);
            this.rbAnsTwo.Name = "rbAnsTwo";
            this.rbAnsTwo.Size = new System.Drawing.Size(123, 52);
            this.rbAnsTwo.TabIndex = 2;
            this.rbAnsTwo.TabStop = true;
            this.rbAnsTwo.Text = "ans2";
            this.rbAnsTwo.UseVisualStyleBackColor = true;
            this.rbAnsTwo.CheckedChanged += new System.EventHandler(this.rbCode_CheckedChanged);
            // 
            // rbAnsOne
            // 
            this.rbAnsOne.AutoSize = true;
            this.rbAnsOne.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAnsOne.ForeColor = System.Drawing.Color.White;
            this.rbAnsOne.Location = new System.Drawing.Point(224, 221);
            this.rbAnsOne.Name = "rbAnsOne";
            this.rbAnsOne.Size = new System.Drawing.Size(115, 52);
            this.rbAnsOne.TabIndex = 1;
            this.rbAnsOne.TabStop = true;
            this.rbAnsOne.Text = "ans1";
            this.rbAnsOne.UseVisualStyleBackColor = true;
            this.rbAnsOne.CheckedChanged += new System.EventHandler(this.rbICT_CheckedChanged);
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionText.ForeColor = System.Drawing.Color.White;
            this.lblQuestionText.Location = new System.Drawing.Point(0, 33);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(330, 65);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "questionText";
            this.lblQuestionText.Click += new System.EventHandler(this.lblQuestionText_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScreen";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowSidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private RadioButton rbAns;
        private Button btnQuit;
        private Label lblQuestionNum;
    }
}