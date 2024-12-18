﻿namespace AdventCalendarTask.Forms
{
    partial class LoginScreen
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
            rpnlLogin = new AdventForm.RoundedPanel();
            lblHighscore = new Label();
            cbShowPass = new CheckBox();
            rbtnLogin = new AdventForm.RoundedButton();
            rpnlPassword = new AdventForm.RoundedPanel();
            tbPassword = new TextBox();
            rpnlUsername = new AdventForm.RoundedPanel();
            tbUsername = new TextBox();
            lblLogin = new Label();
            lblRegister = new Label();
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
            rpnlLogin.Controls.Add(lblHighscore);
            rpnlLogin.Controls.Add(cbShowPass);
            rpnlLogin.Controls.Add(rbtnLogin);
            rpnlLogin.Controls.Add(rpnlPassword);
            rpnlLogin.Controls.Add(rpnlUsername);
            rpnlLogin.Controls.Add(lblLogin);
            rpnlLogin.ForeColor = Color.White;
            rpnlLogin.Glass = false;
            rpnlLogin.Location = new Point(317, 56);
            rpnlLogin.Name = "rpnlLogin";
            rpnlLogin.PanelColor = Color.Empty;
            rpnlLogin.Radius = 50;
            rpnlLogin.Size = new Size(254, 335);
            rpnlLogin.TabIndex = 0;
            // 
            // lblHighscore
            // 
            lblHighscore.AutoSize = true;
            lblHighscore.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHighscore.Location = new Point(22, 119);
            lblHighscore.Name = "lblHighscore";
            lblHighscore.Size = new Size(74, 14);
            lblHighscore.TabIndex = 5;
            lblHighscore.Text = "lblHighscore";
            lblHighscore.Visible = false;
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
            // rbtnLogin
            // 
            rbtnLogin.BackColor = Color.White;
            rbtnLogin.BorderColor = Color.Transparent;
            rbtnLogin.BorderSize = 0;
            rbtnLogin.FlatStyle = FlatStyle.Flat;
            rbtnLogin.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnLogin.ForeColor = Color.DimGray;
            rbtnLogin.Glass = false;
            rbtnLogin.Location = new Point(22, 274);
            rbtnLogin.Name = "rbtnLogin";
            rbtnLogin.PanelColor = Color.Empty;
            rbtnLogin.Radius = 10;
            rbtnLogin.Size = new Size(208, 40);
            rbtnLogin.TabIndex = 3;
            rbtnLogin.Text = "Log In";
            rbtnLogin.UseVisualStyleBackColor = false;
            rbtnLogin.Click += rbtnLogin_Click;
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
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(22, 34);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(211, 77);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Log In";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Dock = DockStyle.Bottom;
            lblRegister.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.PaleGreen;
            lblRegister.Location = new Point(0, 410);
            lblRegister.Name = "lblRegister";
            lblRegister.Padding = new Padding(0, 0, 0, 3);
            lblRegister.Size = new Size(112, 40);
            lblRegister.TabIndex = 1;
            lblRegister.Text = "Register";
            lblRegister.Click += lblRegister_Click;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 97, 68);
            BackgroundImage = Properties.Resources.bgBlurred;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegister);
            Controls.Add(rpnlLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginScreen";
            Text = "LoginScreen";
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
        private Label lblLogin;
        private AdventForm.RoundedPanel rpnlPassword;
        private AdventForm.RoundedPanel rpnlUsername;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private AdventForm.RoundedButton rbtnLogin;
        private Label lblRegister;
        private CheckBox cbShowPass;
        private Label lblHighscore;
    }
}