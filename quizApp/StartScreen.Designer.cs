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
            this.components = new System.ComponentModel.Container();
            this.flowSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.rbICT = new System.Windows.Forms.RadioButton();
            this.lblSelectQuiz = new System.Windows.Forms.Label();
            this.flowSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowSidebar
            // 
            this.flowSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.flowSidebar.Controls.Add(this.btnMenu);
            this.flowSidebar.Controls.Add(this.btnStartQuiz);
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
            // btnStartQuiz
            // 
            this.btnStartQuiz.FlatAppearance.BorderSize = 0;
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartQuiz.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(0, 101);
            this.btnStartQuiz.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(300, 55);
            this.btnStartQuiz.TabIndex = 3;
            this.btnStartQuiz.Text = "Start";
            this.btnStartQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartQuiz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuit);
            this.panel2.Location = new System.Drawing.Point(3, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 763);
            this.panel2.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(0, 680);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(300, 55);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 1;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.lblLastScore);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.tbNameInput);
            this.panel1.Controls.Add(this.rbCode);
            this.panel1.Controls.Add(this.rbICT);
            this.panel1.Controls.Add(this.lblSelectQuiz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 881);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 242);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 11);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblLastScore
            // 
            this.lblLastScore.AutoSize = true;
            this.lblLastScore.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastScore.Location = new System.Drawing.Point(691, 801);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(107, 24);
            this.lblLastScore.TabIndex = 5;
            this.lblLastScore.Text = "Last Score";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(0, 801);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // tbNameInput
            // 
            this.tbNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.tbNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNameInput.ForeColor = System.Drawing.Color.White;
            this.tbNameInput.Location = new System.Drawing.Point(3, 828);
            this.tbNameInput.Multiline = true;
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(898, 65);
            this.tbNameInput.TabIndex = 3;
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbCode.ForeColor = System.Drawing.Color.White;
            this.rbCode.Location = new System.Drawing.Point(6, 135);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(217, 52);
            this.rbCode.TabIndex = 2;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "Code Quiz";
            this.rbCode.UseVisualStyleBackColor = true;
            this.rbCode.CheckedChanged += new System.EventHandler(this.rbCode_CheckedChanged);
            // 
            // rbICT
            // 
            this.rbICT.AutoSize = true;
            this.rbICT.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbICT.ForeColor = System.Drawing.Color.White;
            this.rbICT.Location = new System.Drawing.Point(6, 77);
            this.rbICT.Name = "rbICT";
            this.rbICT.Size = new System.Drawing.Size(182, 52);
            this.rbICT.TabIndex = 1;
            this.rbICT.TabStop = true;
            this.rbICT.Text = "ICT Quiz";
            this.rbICT.UseVisualStyleBackColor = true;
            this.rbICT.CheckedChanged += new System.EventHandler(this.rbICT_CheckedChanged);
            // 
            // lblSelectQuiz
            // 
            this.lblSelectQuiz.AutoSize = true;
            this.lblSelectQuiz.Font = new System.Drawing.Font("Bahnschrift", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectQuiz.ForeColor = System.Drawing.Color.White;
            this.lblSelectQuiz.Location = new System.Drawing.Point(3, 9);
            this.lblSelectQuiz.Name = "lblSelectQuiz";
            this.lblSelectQuiz.Size = new System.Drawing.Size(422, 65);
            this.lblSelectQuiz.TabIndex = 0;
            this.lblSelectQuiz.Text = "Select Your Quiz";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
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
        private FlowLayoutPanel flowLayoutPanel1;
    }
}