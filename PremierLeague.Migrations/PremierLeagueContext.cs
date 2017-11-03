using PremierLeague.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Migrations
{
    public class PremierLeagueContext : DbContext
    {
        public DbSet<DbUser> DbUsers { get; set; }
        public DbSet<DbUserRole> DbUserRoles { get; set; }
        public DbSet<DbSeason> DbSeasons { get; set; }
        public DbSet<DbGameWeek> DbGameweeks { get; set; }
        public DbSet<DbMatch> DbMatches { get; set; }
        public DbSet<DbTeam> DbTeams { get; set; }
        public DbSet<DbExpectedResult> DbExpectedResult { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }

}
