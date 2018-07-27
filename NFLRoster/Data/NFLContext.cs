using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NFLRoster.Models;

namespace NFLRoster.Data
{
    public class NFLContext : DbContext
    {
        public NFLContext() : base("NFLRosterContext")
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}