using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using NFLRoster.Models;

namespace NFLRoster.Data
{
    public class SeedData
    {
        public static System.Collections.Generic.List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team
                {
                    TeamName = "Vikings",
                    City = "Minnieapolis",
                    State = "Minniesota"
                },

                new Team()
                {
                    TeamName = "Bears",
                    City = "Chicago",
                    State = "Illinois"
                },

                new Team()
                {
                    TeamName = "Lions",
                    City = "Detroit",
                    State = "Michigan"
                },

                new Team()
                {
                    TeamName = "Packers",
                    City = "Green Bay",
                    State = "Wisconsin"
                },
            };

            return teams;
        }

        public static List<Player> getPlayers(NFLContext context)
        {
            List<Player> players = new List<Player>()
            {
                new Player
                {
                    PlayerId = 01,
                    JerseyNumber = 12,
                    FirstName = "Kirk",
                    LastName = "Cousins",
                    Position = "Quarterback",
                    TeamName = context.Teams.Find("Vikings").TeamName
                },

                new Player
                {
                    PlayerId = 02,
                    JerseyNumber = 10,
                    FirstName = "Mitch",
                    LastName = "Trubisky",
                    Position = "Quarterback",
                    TeamName = context.Teams.Find("Bears").TeamName
                },

                new Player
                {
                    PlayerId = 03,
                    JerseyNumber = 00,
                    FirstName = "Aaron",
                    LastName = "Rodgers",
                    Position = "Quarterback",
                    TeamName = context.Teams.Find("Packers").TeamName
                },
                new Player
                {
                    PlayerId = 04,
                    JerseyNumber = 09,
                    FirstName = "Matthew",
                    LastName = "Stafford",
                    Position = "Quarterback",
                    TeamName = context.Teams.Find("Lions").TeamName
                },
            };

            return players;
        }
    }
}
