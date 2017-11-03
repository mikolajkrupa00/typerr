using PremierLeague.ViewModels.Models;
using PremierLeague.ViewModels.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.ViewModels.Models.GameWeek
{
    public class VMAdminGameWeekAddGameWeek
    {
        public List<VMAdminGameWeekSeasonGameWeek> Seasons { get; set; }
        public string GameWeekName { get; set; }
    }
}
