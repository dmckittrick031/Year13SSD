using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventCalendarTask.Forms
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
            rpnlLogin.Left = (this.ClientSize.Width - rpnlLogin.Width) / 2;
            rpnlLogin.Top = (this.ClientSize.Height - rpnlLogin.Height) / 2;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForms._loginScreen.Show();
        }

        private void LgScrn_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void rbtnRegister_Click(object sender, EventArgs e)
        {
            string filePath = @"Users.txt";

            using (FileStream aFile = new(filePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new(aFile))
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
                {
                    sw.Write($"{username}~{password}");

                    MessageBox.Show($"Succesfully registered {username}.", "User Registered");
                    username = String.Empty;
                    password = String.Empty;
                }
                else
                {
                    MessageBox.Show("Please enter a username and/or password.", "Cannot Register User");
                }
            }

        }
    }
}
