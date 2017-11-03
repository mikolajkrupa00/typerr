using PremierLeague.CoreModels.Models.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Access.AdminSeason
{
    public interface ISeasonAccess
    {
        List<CoreSeason> GetSeasons();
        void AddNewSeason(CoreNewSeason season);
        void DeleteSeason(int seasonId);
    }
}
