using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Team
    {
        private FootballPlayer[] players;

        public Coach Coach { get; set; }
        public FootballPlayer[] Players
        {
            get { return players; }
            set
            {
                if (value.Length < 11 || value.Length > 22)
                {
                    throw new ArgumentException("A team must have at least 11 players and at most 22 players.");
                }
                players = value;
            }
        }

        public double CalculateAverageAge()
        {
            int sum = 0;
            foreach (FootballPlayer player in Players)
            {
                sum += player.Age;
            }

            return (double)sum / Players.Length;
        }
    }
}
