using PremierLeague.CoreModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Access.AdminTeam
{
    public interface ITeamAccess
    {
        void AddTeam(CoreNewTeam coreNewTeam);
        List<CoreTeam> GetTeams();
        void DeleteTeam(int id);
    }
}
