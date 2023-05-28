using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }
        public Goal[] Goals { get; set; }

        public Game(Team team1, Team team2, Referee referee, Referee firstAssistantReferee, Referee secondAssistantReferee, Goal[] goals, string result, string winner)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = firstAssistantReferee;
            AssistantReferee2 = secondAssistantReferee;
            Goals = goals;
            Result = result;
            Winner = winner;
        }
    }
}
