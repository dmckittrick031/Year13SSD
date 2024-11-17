using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarTask.Assets
{
    [Serializable]
    internal class Player
    {
        public string username;
        public int score;

        public Player(string username) 
        {
            this.username = username;
            score = 0;
        }

        public void ResetPlayer()
        {
            username = String.Empty;
            score = 0;
        }

        public void IncreaseScore()
        {
            score++;
        }
    }
}
