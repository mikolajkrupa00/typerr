using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.DataBase.Models
{
    public class DbMatch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatchId { get; set; }

        public int HomeTeamId { get; set; }
        [ForeignKey("HomeTeamId")]
        public virtual DbTeam HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        [ForeignKey("AwayTeamId")]
        public virtual DbTeam AwayTeam { get; set; }

        public int GameWeekId { get; set; }
        [ForeignKey("GameWeekId")]
        public virtual DbGameWeek GameWeek { get; set; }

        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
