namespace AdventCalendarTask.Forms
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            rpnlLogin = new AdventForm.RoundedPanel();
            cbShowPass = new CheckBox();
            rbtnRegister = new AdventForm.RoundedButton();
            rpnlPassword = new AdventForm.RoundedPanel();
            tbPassword = new TextBox();
            rpnlUsername = new AdventForm.RoundedPanel();
            tbUsername = new TextBox();
            lblRegister = new Label();
            lblLogin = new Label();
            rpnlLogin.SuspendLayout();
            rpnlPassword.SuspendLayout();
            rpnlUsername.SuspendLayout();
            SuspendLayout();
            // 
            // rpnlLogin
            // 
            rpnlLogin.Anchor = AnchorStyles.None;
            rpnlLogin.BackColor = Color.FromArgb(53, 97, 68);
            rpnlLogin.BorderColor = Color.Red;
            rpnlLogin.BorderSize = 0;
            rpnlLogin.Controls.Add(cbShowPass);
            rpnlLogin.Controls.Add(rbtnRegister);
            rpnlLogin.Controls.Add(rpnlPassword);
            rpnlLogin.Controls.Add(rpnlUsername);
            rpnlLogin.Controls.Add(lblRegister);
            rpnlLogin.ForeColor = Color.White;
            rpnlLogin.Glass = false;
            rpnlLogin.Location = new Point(317, 56);
            rpnlLogin.Name = "rpnlLogin";
            rpnlLogin.PanelColor = Color.Empty;
            rpnlLogin.Radius = 50;
            rpnlLogin.Size = new Size(254, 335);
            rpnlLogin.TabIndex = 0;
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.FlatAppearance.BorderSize = 0;
            cbShowPass.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 128, 0);
            cbShowPass.Font = new Font("Bahnschrift", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowPass.ForeColor = Color.White;
            cbShowPass.Location = new Point(22, 234);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(167, 27);
            cbShowPass.TabIndex = 4;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            cbShowPass.Paint += OnPaint;
            // 
            // rbtnRegister
            // 
            rbtnRegister.BackColor = Color.White;
            rbtnRegister.BorderColor = Color.Transparent;
            rbtnRegister.BorderSize = 0;
            rbtnRegister.FlatStyle = FlatStyle.Flat;
            rbtnRegister.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnRegister.ForeColor = Color.DimGray;
            rbtnRegister.Glass = false;
            rbtnRegister.Location = new Point(22, 274);
            rbtnRegister.Name = "rbtnRegister";
            rbtnRegister.PanelColor = Color.Empty;
            rbtnRegister.Radius = 10;
            rbtnRegister.Size = new Size(208, 40);
            rbtnRegister.TabIndex = 3;
            rbtnRegister.Text = "Register";
            rbtnRegister.UseVisualStyleBackColor = false;
            rbtnRegister.Click += rbtnRegister_Click;
            // 
            // rpnlPassword
            // 
            rpnlPassword.BackColor = Color.White;
            rpnlPassword.BorderColor = Color.Transparent;
            rpnlPassword.BorderSize = 0;
            rpnlPassword.Controls.Add(tbPassword);
            rpnlPassword.ForeColor = Color.White;
            rpnlPassword.Glass = false;
            rpnlPassword.Location = new Point(22, 192);
            rpnlPassword.Name = "rpnlPassword";
            rpnlPassword.PanelColor = Color.Empty;
            rpnlPassword.Radius = 10;
            rpnlPassword.Size = new Size(211, 25);
            rpnlPassword.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(3, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(205, 20);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // rpnlUsername
            // 
            rpnlUsername.BackColor = Color.White;
            rpnlUsername.BorderColor = Color.Transparent;
            rpnlUsername.BorderSize = 0;
            rpnlUsername.Controls.Add(tbUsername);
            rpnlUsername.ForeColor = Color.White;
            rpnlUsername.Glass = false;
            rpnlUsername.Location = new Point(22, 143);
            rpnlUsername.Name = "rpnlUsername";
            rpnlUsername.PanelColor = Color.Empty;
            rpnlUsername.Radius = 10;
            rpnlUsername.Size = new Size(211, 25);
            rpnlUsername.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(3, 3);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(205, 20);
            tbUsername.TabIndex = 0;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Bahnschrift", 38F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.Location = new Point(20, 34);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(218, 62);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Dock = DockStyle.Bottom;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.PaleGreen;
            lblLogin.Location = new Point(0, 410);
            lblLogin.Name = "lblLogin";
            lblLogin.Padding = new Padding(0, 0, 0, 3);
            lblLogin.Size = new Size(91, 40);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Log In";
            lblLogin.Click += lblLogin_Click;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 97, 68);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLogin);
            Controls.Add(rpnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterScreen";
            Text = "LoginScreen1";
            WindowState = FormWindowState.Maximized;
            Load += LoginScreen_Load;
            rpnlLogin.ResumeLayout(false);
            rpnlLogin.PerformLayout();
            rpnlPassword.ResumeLayout(false);
            rpnlPassword.PerformLayout();
            rpnlUsername.ResumeLayout(false);
            rpnlUsername.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AdventForm.RoundedPanel rpnlLogin;
        private Label lblRegister;
        private AdventForm.RoundedPanel rpnlPassword;
        private AdventForm.RoundedPanel rpnlUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private AdventForm.RoundedButton rbtnRegister;
        private Label lblLogin;
        private CheckBox cbShowPass;
    }
}