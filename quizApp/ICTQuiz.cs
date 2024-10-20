using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizApp
{
    public class ICTQuiz : Quiz
    {
        public ICTQuiz(Player player, int time) : base(player)
        {
            AddQuestions();
            SetQuizTime(time);
        }

        public override void SetQuizTime(int time)
        {
            Countdown = time;
            GameScreen.ActiveForm.BackgroundImage = global::quizApp.Properties.Resources.ict100;
        }

        public override void AddQuestions()
        {
            Questions.Add(new Question("What does the acronym PSU stand for?",
                new[] { "Powered Suggestion Unit", "Portable Service Unifier", "Power Supply Unit", "Parameter Severance Unifier" }, 2));
            Questions.Add(new Question("Which is not a network topology?",
                new[] { "Bus", "Ring", "Star", "Diamond" }, 3));
            Questions.Add(new Question("What does the acronym WAN stand for?",
                new[] { "Wired Area Network", "Wide Area Network", "Wireless Aired Network", "Wired Aired Network" }, 1));
            Questions.Add(new Question("How many bits are in a byte?",
                new[] { "8", "4", "2", "6" }, 0));            
            Questions.Add(new Question("What does the acronym PNG stand for?",
                new[] { "Printable Network Graphic", "Portable Neural Graphic", "Portable Network Graphic", "Portable Network Graphics" }, 2));
            Questions.Add(new Question("What does the acronym CPU stand for?",
                new[] { "Central Powered Unit", "Central Processing Unit", "Conditional Processing Unit", "Corrosive Power Unifier" }, 1));
        }
    }
}
