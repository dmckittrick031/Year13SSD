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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            rpnlLogin.Left = (this.ClientSize.Width - rpnlLogin.Width) / 2;
            rpnlLogin.Top = (this.ClientSize.Height - rpnlLogin.Height) / 2;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
