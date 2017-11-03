using PremierLeague.CoreModels.Models.GameWeek;
using PremierLeague.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.Access.AdminGameWeek
{
    public class GameWeekAccess : IGameWeekAccess
    {
        private readonly PremierLeagueContext _context;
        public GameWeekAccess()
        {
            _context = new PremierLeagueContext();
        }
        public List<CoreGameWeek> GetGameWeeks()
        {
            return _context.DbGameweeks.Select(x => new CoreGameWeek {Name=x.Name, GameWeekId=x.GameWeekId }).ToList();
        }
    }
}
