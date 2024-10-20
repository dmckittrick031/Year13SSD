using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class Quiz
    {
        public Player Player { get; set; }
        public int Countdown { get; set; }

        public List<Question> Questions = new();

        public int CurrentQuestionPos { get; set; }

        public Quiz(Player player)
        {
            Player = player;
            CurrentQuestionPos = 0;
        }

        public virtual void SetQuizTime(int time)
        {

        }

        public virtual void AddQuestions()
        {

        }
        public bool HasNextQuestion
        {
            get { return CurrentQuestionPos < (Questions.Count - 1); }
        }

        public void CheckAnswer(int selectedIndex)
        {
            if (selectedIndex == Questions[CurrentQuestionPos].CorrectAnsPos)
            {
                Player.Score++;
            }
        }
        public void ResetQuiz()
        {
            CurrentQuestionPos = 0;
            Player.Score = 0;
        }
    }
}
