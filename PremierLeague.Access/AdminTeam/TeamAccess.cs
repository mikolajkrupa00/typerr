using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.CoreModels.Models;
using PremierLeague.DataBase.Models;
using PremierLeague.Migrations;

namespace PremierLeague.Access.AdminTeam
{
    public class TeamAccess : ITeamAccess
    {
        private readonly PremierLeagueContext _context;
        public TeamAccess()
        {
            _context = new PremierLeagueContext();
        }

        public void AddTeam(CoreNewTeam coreNewTeam)
        {
            var dbTeam = new DbTeam()
            {
                Name = coreNewTeam.TeamName
            };
            _context.DbTeams.Add(dbTeam);
            _context.SaveChanges();
        }

        public List<CoreTeam> GetTeams()
        {
            return _context.DbTeams.Select(x => new CoreTeam { Name = x.Name, TeamId = x.TeamId }).ToList();   
        }

        public void DeleteTeam(int id)
        {
            var team = _context.DbTeams.FirstOrDefault(x => x.TeamId == id);
            _context.DbTeams.Remove(team);
            _context.SaveChanges();
            
        }
    }
}
