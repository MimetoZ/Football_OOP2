using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Goalkeeper goalkeeper1 = new Goalkeeper { Name = "John", Age = 25, Number = 1, Height = 180 };
            Defender defender1 = new Defender { Name = "Mike", Age = 28, Number = 2, Height = 185 };
            Midfield midfield1 = new Midfield { Name = "David", Age = 23, Number = 8, Height = 175 };
            Striker striker1 = new Striker { Name = "Alex", Age = 26, Number = 9, Height = 180 };

            Goalkeeper goalkeeper2 = new Goalkeeper { Name = "Peter", Age = 27, Number = 1, Height = 182 };
            Defender defender2 = new Defender { Name = "Tom", Age = 29, Number = 4, Height = 190 };
            Midfield midfield2 = new Midfield { Name = "Chris", Age = 24, Number = 7, Height = 180 };
            Striker striker2 = new Striker { Name = "Daniel", Age = 25, Number = 10, Height = 185 };

            Referee referee = new Referee { Name = "Emil", Age = 35 };
            Referee assistantReferee1 = new Referee { Name = "Dave", Age = 55 };
            Referee assistantReferee2 = new Referee { Name = "Jack", Age = 35 };
            Team team1 = new Team
            {
                Coach = new Coach { Name = "Steve", Age = 40 },
                Players = new FootballPlayer[] { goalkeeper1, defender1, midfield1, striker1, defender1, midfield1, striker1, striker1, defender1, midfield1, goalkeeper1 }
            };

            Team team2 = new Team
            {
                Coach = new Coach { Name = "Mark", Age = 45 },
                Players = new FootballPlayer[] { goalkeeper2, defender2, midfield2, striker2, defender2, midfield2, striker2, defender2, midfield2, striker2, goalkeeper2 }
            };

            Goal[] goals = new Goal[]
            {
            new Goal { Minute = 15, Player = striker1 },
            new Goal { Minute = 30, Player = striker2 },
            new Goal { Minute = 60, Player = striker1 }
            };

            string result = "2-1";
            string winner = "Team1";

            Game game = new Game(team1, team2, referee, assistantReferee1, assistantReferee2, goals, result, winner);

            Console.WriteLine($"Game result {game.Result}");
            Console.WriteLine($"Winner {game.Winner}");
            Console.WriteLine("Team 1 average age is {0:f2}", team1.CalculateAverageAge());
        }
    }
}
