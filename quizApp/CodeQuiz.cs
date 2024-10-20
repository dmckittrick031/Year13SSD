using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class CodeQuiz : Quiz
    {
        public CodeQuiz(Player player, int time) : base(player)
        {
            AddQuestions();
            SetQuizTime(time);
        }

        public override void SetQuizTime(int time)
        {
            Countdown = time;
            GameScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.code;
        }

        public override void AddQuestions()
        {
            Questions.Add(new Question("What is the default acces modifier for C#?",
                new[] { "internal", "private", "public", "async" }, 0));
            Questions.Add(new Question("Which of the following is equivalent to Nullable<var>?",
                new[] { "var.Null", "var.SetNullable()", "var#", "var?" }, 3));
            Questions.Add(new Question("What is the sign for a verbatim string?",
                new[] { "+", "@", "v", "!" }, 1));
            Questions.Add(new Question("How would you find the amount of items in a list?",
                new[] { "Count()", "Length", "Count", "length" }, 2));
        }
    }
}
