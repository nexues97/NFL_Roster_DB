using NFLRoster.Data;

namespace NFLRoster.Migrations.NFL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NFLRoster.Data.NFLContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\NFL";
        }

        protected override void Seed(NFLRoster.Data.NFLContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Teams.AddOrUpdate(
                t => t.TeamName, SeedData.getTeams().ToArray());
            context.SaveChanges();

            context.Players.AddOrUpdate(
                p => new { p.FirstName, p.LastName }, SeedData.getPlayers(context).ToArray());
            context.SaveChanges();
        }
    }
}
