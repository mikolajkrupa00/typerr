namespace PremierLeague.Migrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class premierleaguecontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DbExpectedResults",
                c => new
                    {
                        ExpectedResultId = c.Int(nullable: false, identity: true),
                        HomeTeamGoals = c.Int(nullable: false),
                        AwayTeamGoals = c.Int(nullable: false),
                        UserId = c.Guid(nullable: false),
                        MatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpectedResultId)
                .ForeignKey("dbo.DbMatches", t => t.MatchId, cascadeDelete: false)
                .ForeignKey("dbo.DbUsers", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.MatchId);
            
            CreateTable(
                "dbo.DbMatches",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                        HomeTeamId = c.Int(nullable: false),
                        AwayTeamId = c.Int(nullable: false),
                        GameWeekId = c.Int(nullable: false),
                        HomeTeamGoals = c.Int(nullable: false),
                        AwayTeamGoals = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId)
                .ForeignKey("dbo.DbTeams", t => t.AwayTeamId, cascadeDelete: false)
                .ForeignKey("dbo.DbGameWeeks", t => t.GameWeekId, cascadeDelete: false)
                .ForeignKey("dbo.DbTeams", t => t.HomeTeamId, cascadeDelete: false)
                .Index(t => t.HomeTeamId)
                .Index(t => t.AwayTeamId)
                .Index(t => t.GameWeekId);
            
            CreateTable(
                "dbo.DbTeams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.DbGameWeeks",
                c => new
                    {
                        GameWeekId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SeasonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameWeekId)
                .ForeignKey("dbo.DbSeasons", t => t.SeasonId, cascadeDelete: false)
                .Index(t => t.SeasonId);
            
            CreateTable(
                "dbo.DbSeasons",
                c => new
                    {
                        SeasonId = c.Int(nullable: false, identity: true),
                        StartYear = c.Int(nullable: false),
                        EndYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonId);
            
            CreateTable(
                "dbo.DbUsers",
                c => new
                    {
                        UserId = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.DbUserRoles", t => t.UserRoleId, cascadeDelete: false)
                .Index(t => t.UserRoleId);
            
            CreateTable(
                "dbo.DbUserRoles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DbUsers", "UserRoleId", "dbo.DbUserRoles");
            DropForeignKey("dbo.DbExpectedResults", "UserId", "dbo.DbUsers");
            DropForeignKey("dbo.DbExpectedResults", "MatchId", "dbo.DbMatches");
            DropForeignKey("dbo.DbMatches", "HomeTeamId", "dbo.DbTeams");
            DropForeignKey("dbo.DbGameWeeks", "SeasonId", "dbo.DbSeasons");
            DropForeignKey("dbo.DbMatches", "GameWeekId", "dbo.DbGameWeeks");
            DropForeignKey("dbo.DbMatches", "AwayTeamId", "dbo.DbTeams");
            DropIndex("dbo.DbUsers", new[] { "UserRoleId" });
            DropIndex("dbo.DbGameWeeks", new[] { "SeasonId" });
            DropIndex("dbo.DbMatches", new[] { "GameWeekId" });
            DropIndex("dbo.DbMatches", new[] { "AwayTeamId" });
            DropIndex("dbo.DbMatches", new[] { "HomeTeamId" });
            DropIndex("dbo.DbExpectedResults", new[] { "MatchId" });
            DropIndex("dbo.DbExpectedResults", new[] { "UserId" });
            DropTable("dbo.DbUserRoles");
            DropTable("dbo.DbUsers");
            DropTable("dbo.DbSeasons");
            DropTable("dbo.DbGameWeeks");
            DropTable("dbo.DbTeams");
            DropTable("dbo.DbMatches");
            DropTable("dbo.DbExpectedResults");
        }
    }
}
