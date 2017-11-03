using PremierLeague.ViewModels.Models.GameWeek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Services.AdminGameWeek
{
    public interface IAdminGameWeekService
    {
        VMAdminGameWeekIndex GetGameWeeks();
        void AddGameWeek();
    }
}
