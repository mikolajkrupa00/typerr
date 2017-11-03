using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.CoreModels.Models.Season;
using PremierLeague.Migrations;
using PremierLeague.DataBase.Models;

namespace PremierLeague.Access.AdminSeason
{
    public class SeasonAccess : ISeasonAccess
    {
        private readonly PremierLeagueContext _context;
        public SeasonAccess()
        {
           _context = new PremierLeagueContext();
        }
        
        public List<CoreSeason> GetSeasons()
        {
            return _context.DbSeasons.Select(x => new CoreSeason { EndYear = x.EndYear, SeasonId = x.SeasonId, StartYear = x.StartYear }).ToList();
        }

        public void AddNewSeason(CoreNewSeason season)
        {
            _context.DbSeasons.Add(new DbSeason { EndYear = season.EndYear, StartYear = season.StartYear });
            _context.SaveChanges();
        }
        public void DeleteSeason(int seasonId)
        {
            var season = _context.DbSeasons.FirstOrDefault(x => x.SeasonId == seasonId);
            _context.DbSeasons.Remove(season);
            _context.SaveChanges();
        }
    }
}
