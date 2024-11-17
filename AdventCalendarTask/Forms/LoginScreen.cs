using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventCalendarTask.Assets;
using AdventCalendarTask.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;

namespace AdventCalendarTask.Forms
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            rpnlLogin.Left = (this.ClientSize.Width - rpnlLogin.Width) / 2;
            rpnlLogin.Top = (this.ClientSize.Height - rpnlLogin.Height) / 2;
            GetLastScore();
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

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadForms._registerScreen.Show();
        }

        private void RgScrn_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void rbtnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                if (File.Exists("Users.txt"))
                {
                    bool userFound = false;

                    string[] users = File.ReadLines("Users.txt").ToArray();

                    foreach (var user in users)
                    {
                        string[] usernameAndPassword = user.Split("~");

                        if (username == usernameAndPassword[0] && password == usernameAndPassword[1])
                        {
                            userFound = true; 
                            break;
                        }
                    }

                    if (userFound)
                    {
                        Hide();
                        //LoadForms._startScreen.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No users have been registered. To continue, please register an account.", "No Users Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and / or password.", "Cannot Log In");
            }
        }
        private void GetLastScore()
        {
            Player playerDeserialized = Serializer.DeserializePlayer();

            if (playerDeserialized != null)
            {
                lblHighscore.Text = $"{playerDeserialized.username} scored {playerDeserialized.score}";
                lblHighscore.Visible = true;
            }
            else 
            { 
                lblHighscore.Visible = false; 
            }
        }
    }
}
