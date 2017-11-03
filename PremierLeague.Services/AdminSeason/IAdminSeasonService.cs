using PremierLeague.CoreModels.Models.Season;
using PremierLeague.ViewModels.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Services.AdminSeason
{
    public interface IAdminSeasonService
    {
        VMAdminSeasonIndex GetSeasons();
        void AddNewSeason(VMAdminSeasonAddSeason season);
        void DeleteSeason(int seasonId);
    }
}
