using System.Diagnostics;

namespace quizApp
{
    public partial class quizQuestionTemplate1 : Form
    {
        bool sidebarExtend;
        public quizQuestionTemplate1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExtend)
            {
                flowSidebar.Width -= 10;

                if (flowSidebar.Width == flowSidebar.MinimumSize.Width)
                {
                    sidebarExtend = false;
                    tmrSidebar.Stop();
                }
            }
            else
            {
                flowSidebar.Width += 10;

                if (flowSidebar.Width == flowSidebar.MaximumSize.Width)
                {
                    sidebarExtend = true;
                    tmrSidebar.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSidebar.Start();
        }

        private void flowSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void rbCode_CheckedChanged(object sender, EventArgs e)
        {
            quizQuestionTemplate1.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.code;
        }

        private void rbICT_CheckedChanged(object sender, EventArgs e)
        {
            quizQuestionTemplate1.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.ict100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void lblQuestionText_Click(object sender, EventArgs e)
        {

        }

        private void rbAns_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAnsThree_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}