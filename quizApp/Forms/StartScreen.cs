using System.Diagnostics;

namespace quizApp
{
    public partial class StartScreen : Form
    {
        bool sidebarExtend;
        public StartScreen()
        {
            InitializeComponent();
            PopulateNameFromPrevious();
            GetLastScore();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void PopulateNameFromPrevious()
        {
            if (GameScreen._quiz != null)
            {
                if (GameScreen._quiz.Player.Name.Any())
                {
                    tbNameInput.Text = GameScreen._quiz.Player.Name;
                }
            }
        }

        private void GetLastScore()
        {
            try
            {
                using (BinaryReader br = new(File.Open(@"C:\Users\User\Documents\quizApp\Saves\scores.bin", FileMode.Open)))
                {
                    int pos = 0;
                    int length = (int)br.BaseStream.Length;

                    while (pos < length)
                    {
                        int score = br.ReadInt32();
                        lblLastScore.Text += $":                {score}";
                        pos += sizeof(int);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
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
            StartScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.code;
        }

        private void rbICT_CheckedChanged(object sender, EventArgs e)
        {
            StartScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.ict100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (rbCode.Checked)
            {
                StartQuiz(1);
            }
            else if (rbICT.Checked)
            {
                StartQuiz(2);
            }
            else
            {
                lblSelectQuiz.Text = "Please select a quiz";
                await Task.Delay(5000);
                lblSelectQuiz.Text = "Select Your Quiz";
            }
        }

        private async void StartQuiz(int quizChoice)
        {
            if (tbNameInput.Text.Any())
            {
                GameScreen gameScreen = new(tbNameInput.Text, quizChoice);
                gameScreen.Show();
                Hide();
            }
            else
            {
                lblName.Text = "Please enter your name";
                await Task.Delay(3000);
                lblName.Text = "Name";
            }
        }

    }
}