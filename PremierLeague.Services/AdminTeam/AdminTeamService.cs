using PremierLeague.Access.AdminTeam;
using PremierLeague.CoreModels.Models;
using PremierLeague.ViewModels.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Services.AdminTeam
{
    public class AdminTeamService : IAdminTeamService
    {
        private readonly ITeamAccess _teamAccess;
        public AdminTeamService()
        {
            _teamAccess = new TeamAccess();
        }

        public void AddTeam(VMAdminTeamAddTeam vmAddTeam)
        {
            var coreNewTeam = new CoreNewTeam()
            {
                TeamName = vmAddTeam.TeamName
            };
            _teamAccess.AddTeam(coreNewTeam);
        }

        public VMAdminTeamIndex GetTeams()
        {
            var coreTeams = _teamAccess.GetTeams();
            VMAdminTeamIndex vmTeams = new VMAdminTeamIndex()
            {
                Teams = coreTeams.Select(x => new VMAdminTeamIndexTeam { Name = x.Name, TeamId = x.TeamId }).ToList()
            };
            return vmTeams;
        }

        public void DeleteTeam(int id)
        {
            _teamAccess.DeleteTeam(id);
        }
    }
}

