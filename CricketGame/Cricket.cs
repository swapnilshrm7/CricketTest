using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public String result { get; set; }
        public Boolean notout=true;
        public Cricket()
        {
            PlayerScore = 0;
        }
        public void Score(int runs)
        {
            PlayerScore+=runs;
        }
        public void check(int score1,int score2)
        {
            if(score1>score2)
            {
                result = "player 1 win";
            }
            else if(score1<score2)
            {
                result = "player 2 win";
            }
            else
            {
                result = "tie";
            }
        }
    }
}
