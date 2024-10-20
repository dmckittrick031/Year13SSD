using System.Diagnostics;

namespace quizApp
{
    public partial class GameScreen : Form
    {
        bool sidebarExtend;
        public static Quiz _quiz;
        private System.Windows.Forms.Timer _timer = new();
        public GameScreen(string name, int quizSelection)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            SetupQuiz(name, quizSelection);

            if (quizSelection == 1)
            {
                GameScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.code;
            }
            else if (quizSelection == 2)
            {
                GameScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.ict100;
            }
            else
            {
                GameScreen.ActiveForm.BackgroundImage = null;
            }
        }

        private void SetupQuiz(string name, int quizSelection)
        {
            Player player = new(name);
            Text = $"{player.Name}'s Quiz";

            switch (quizSelection)
            {
                case 1:
                    _quiz = new CodeQuiz(player, 15);
                    break;
                case 2:
                    _quiz = new ICTQuiz(player, 20);
                    break;
            }

            FirstQuestion();
            SetupTimer();
            _timer.Start();
        }

        private void FirstQuestion()
        {
            lblQuestionText.Text = _quiz.Questions.First().QuestionText;
            lblQuestionNum.Text = $"Question {(_quiz.CurrentQuestionPos + 1)}";

            rbAnsOne.Text = _quiz.Questions.First().Answers[0];
            rbAnsTwo.Text = _quiz.Questions.First().Answers[1];
            rbAnsThree.Text = _quiz.Questions.First().Answers[2];
            rbAnsFour.Text = _quiz.Questions.First().Answers[3];
        }

        private void SetupTimer()
        {
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _quiz.Countdown--;
            lblTimeRemaining.Text = $"Time Remaining              {_quiz.Countdown}";

            if (_quiz.Countdown < 0)
            {
                _timer.Stop();
                EndScreen endScreen = new();
                endScreen.Show();
                Hide();
            }
        }

        private void NextQuestion()
        {
            if (_quiz.HasNextQuestion)
            {
                _quiz.CurrentQuestionPos++;

                lblQuestionText.Text = _quiz.Questions[_quiz.CurrentQuestionPos].QuestionText;
                lblQuestionNum.Text = $"Question {_quiz.CurrentQuestionPos + 1}";
                rbAnsOne.Text = _quiz.Questions[_quiz.CurrentQuestionPos].Answers[0];
                rbAnsTwo.Text = _quiz.Questions[_quiz.CurrentQuestionPos].Answers[1];
                rbAnsThree.Text = _quiz.Questions[_quiz.CurrentQuestionPos].Answers[2];
                rbAnsFour.Text = _quiz.Questions[_quiz.CurrentQuestionPos].Answers[3];
            }
            else
            {
                EndScreen endScreen = new();
                _timer.Stop();
                endScreen.Show();
                Hide();
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
        }

        private void rbICT_CheckedChanged(object sender, EventArgs e)
        {
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rbAnsOne.Checked)
            {
                _quiz.CheckAnswer(0);
                NextQuestion();
            }
            else if (rbAnsTwo.Checked)
            {
                _quiz.CheckAnswer(1);
                NextQuestion();
            }
            else if (rbAnsThree.Checked)
            {
                _quiz.CheckAnswer(2);
                NextQuestion();
            }
            else if (rbAnsFour.Checked)
            {
                _quiz.CheckAnswer(3);
                NextQuestion();
            }
        }

        private void lblTimeRemaining_Click(object sender, EventArgs e)
        {

        }
    }
}