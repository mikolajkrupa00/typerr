using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierLeague.ViewModels.Models.GameWeek;
using PremierLeague.Access.AdminGameWeek;
using PremierLeague.Access.AdminSeason;

namespace PremierLeague.Services.AdminGameWeek
{
    public class AdminGameWeekService : IAdminGameWeekService
    {
        private readonly IGameWeekAccess _gameWeekAccess;
        private readonly ISeasonAccess _seasonAcces;
        public AdminGameWeekService()
        {
            _gameWeekAccess = new GameWeekAccess();
            _seasonAcces = new SeasonAccess();
        }
        public VMAdminGameWeekIndex GetGameWeeks()
        {
            return new VMAdminGameWeekIndex() { GameWeeks = _gameWeekAccess.GetGameWeeks().Select(x => new VMAdminGameWeekIndexGameWeek { Name = x.Name, GameWeekId = x.GameWeekId }).ToList() };
        }
        public void AddGameWeek()
        {
        }
    }
}
