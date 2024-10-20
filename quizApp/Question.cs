using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnsPos { get; set; }

        public Question(string questionText, string[] answers, int correctAnsPos) 
        {
            QuestionText = questionText;
            Answers = answers;
            CorrectAnsPos = correctAnsPos;
        }
    }
}
