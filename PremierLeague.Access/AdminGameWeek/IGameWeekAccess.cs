using PremierLeague.CoreModels.Models.GameWeek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Access.AdminGameWeek
{
    public interface IGameWeekAccess
    {
        List<CoreGameWeek> GetGameWeeks();
    }
}
