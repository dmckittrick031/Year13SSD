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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            tmrLoading.Start();
        }

        private void progLoading_Click(object sender, EventArgs e)
        {

        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            progLoading.Increment(2);

            if (progLoading.Value >= progLoading.Maximum)
            {
                tmrLoading.Stop();
                Hide();
                LoadForms._loginScreen.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
