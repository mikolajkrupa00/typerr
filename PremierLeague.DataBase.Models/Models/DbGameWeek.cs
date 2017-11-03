using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.DataBase.Models
{
    public class DbGameWeek
    {
        public DbGameWeek()
        {
            Matches = new HashSet<DbMatch>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameWeekId { get; set; }
        public string Name { get; set; }
        public int SeasonId { get; set; }
        [ForeignKey("SeasonId")]
        public virtual DbSeason Season { get; set; }
        public virtual ICollection<DbMatch> Matches { get; set; }
    }
}
