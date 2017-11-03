using PremierLeague.CoreModels.Models;
using PremierLeague.ViewModels.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Services.AdminTeam
{
    public interface IAdminTeamService
    {
        void AddTeam(VMAdminTeamAddTeam vmAddTeam);
        VMAdminTeamIndex GetTeams();
        void DeleteTeam(int id);
    }
}
