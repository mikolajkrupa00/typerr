using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PremierLeague.DataBase.Models
{
    public class DbExpectedResult
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpectedResultId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual DbUser User { get; set; }

        public int MatchId { get; set; }
        [ForeignKey("MatchId")]
        public virtual DbMatch Match { get; set; }

    }
}