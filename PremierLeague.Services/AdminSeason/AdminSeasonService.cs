using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.ViewModels.Models.Season;
using PremierLeague.Access.AdminSeason;
using PremierLeague.CoreModels.Models.Season;

namespace PremierLeague.Services.AdminSeason
{
    public class AdminSeasonService : IAdminSeasonService
    {
        private readonly ISeasonAccess _seasonAcces;
        public AdminSeasonService()
        {
            _seasonAcces = new SeasonAccess();
        }
        public VMAdminSeasonIndex GetSeasons()
        {
            var seasons = _seasonAcces.GetSeasons();
            return new VMAdminSeasonIndex { Seasons = seasons.Select(x => new VMAdminSeasonIndexSeason { EndYear = x.EndYear, SeasonId = x.SeasonId, StartYear = x.StartYear }).ToList() };
        }
        public void AddNewSeason(VMAdminSeasonAddSeason season)
        {
            var coreSeason = new CoreNewSeason {EndYear=season.EndYear, StartYear=season.StartYear };
            _seasonAcces.AddNewSeason(coreSeason);
        }
        public void DeleteSeason(int seasonId)
        {
            _seasonAcces.DeleteSeason(seasonId);
        }
    }
}
