namespace AdventCalendarTask.Forms
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
            this.rpnlLogin = new AdventForm.RoundedPanel();
            this.rbtnLogin = new AdventForm.RoundedButton();
            this.rpnlPassword = new AdventForm.RoundedPanel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.rpnlUsername = new AdventForm.RoundedPanel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rpnlLogin.SuspendLayout();
            this.rpnlPassword.SuspendLayout();
            this.rpnlUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpnlLogin
            // 
            this.rpnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rpnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(51)))));
            this.rpnlLogin.BorderColor = System.Drawing.Color.Red;
            this.rpnlLogin.BorderSize = 0;
            this.rpnlLogin.Controls.Add(this.rbtnLogin);
            this.rpnlLogin.Controls.Add(this.rpnlPassword);
            this.rpnlLogin.Controls.Add(this.rpnlUsername);
            this.rpnlLogin.Controls.Add(this.lblLogin);
            this.rpnlLogin.ForeColor = System.Drawing.Color.White;
            this.rpnlLogin.Glass = false;
            this.rpnlLogin.Location = new System.Drawing.Point(317, 56);
            this.rpnlLogin.Name = "rpnlLogin";
            this.rpnlLogin.PanelColor = System.Drawing.Color.Empty;
            this.rpnlLogin.Radius = 50;
            this.rpnlLogin.Size = new System.Drawing.Size(254, 335);
            this.rpnlLogin.TabIndex = 0;
            // 
            // rbtnLogin
            // 
            this.rbtnLogin.BackColor = System.Drawing.Color.White;
            this.rbtnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnLogin.BorderSize = 0;
            this.rbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnLogin.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.rbtnLogin.Glass = false;
            this.rbtnLogin.Location = new System.Drawing.Point(22, 274);
            this.rbtnLogin.Name = "rbtnLogin";
            this.rbtnLogin.PanelColor = System.Drawing.Color.Empty;
            this.rbtnLogin.Radius = 10;
            this.rbtnLogin.Size = new System.Drawing.Size(208, 40);
            this.rbtnLogin.TabIndex = 3;
            this.rbtnLogin.Text = "Log In";
            this.rbtnLogin.UseVisualStyleBackColor = false;
            // 
            // rpnlPassword
            // 
            this.rpnlPassword.BackColor = System.Drawing.Color.White;
            this.rpnlPassword.BorderColor = System.Drawing.Color.Transparent;
            this.rpnlPassword.BorderSize = 0;
            this.rpnlPassword.Controls.Add(this.tbPassword);
            this.rpnlPassword.ForeColor = System.Drawing.Color.White;
            this.rpnlPassword.Glass = false;
            this.rpnlPassword.Location = new System.Drawing.Point(22, 192);
            this.rpnlPassword.Name = "rpnlPassword";
            this.rpnlPassword.PanelColor = System.Drawing.Color.Empty;
            this.rpnlPassword.Radius = 10;
            this.rpnlPassword.Size = new System.Drawing.Size(211, 25);
            this.rpnlPassword.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(3, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(205, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // rpnlUsername
            // 
            this.rpnlUsername.BackColor = System.Drawing.Color.White;
            this.rpnlUsername.BorderColor = System.Drawing.Color.Transparent;
            this.rpnlUsername.BorderSize = 0;
            this.rpnlUsername.Controls.Add(this.tbLogin);
            this.rpnlUsername.ForeColor = System.Drawing.Color.White;
            this.rpnlUsername.Glass = false;
            this.rpnlUsername.Location = new System.Drawing.Point(22, 143);
            this.rpnlUsername.Name = "rpnlUsername";
            this.rpnlUsername.PanelColor = System.Drawing.Color.Empty;
            this.rpnlUsername.Radius = 10;
            this.rpnlUsername.Size = new System.Drawing.Size(211, 25);
            this.rpnlUsername.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLogin.Location = new System.Drawing.Point(3, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PlaceholderText = "Username";
            this.tbLogin.Size = new System.Drawing.Size(184, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(22, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(211, 77);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Log In";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(12, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Register";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(82)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::AdventCalendarTask.Properties.Resources.christmasBGBlurred;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rpnlLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.rpnlLogin.ResumeLayout(false);
            this.rpnlLogin.PerformLayout();
            this.rpnlPassword.ResumeLayout(false);
            this.rpnlPassword.PerformLayout();
            this.rpnlUsername.ResumeLayout(false);
            this.rpnlUsername.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventForm.RoundedPanel rpnlLogin;
        private Label lblLogin;
        private AdventForm.RoundedPanel rpnlPassword;
        private AdventForm.RoundedPanel rpnlUsername;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private AdventForm.RoundedButton rbtnLogin;
        private Label label1;
    }
}