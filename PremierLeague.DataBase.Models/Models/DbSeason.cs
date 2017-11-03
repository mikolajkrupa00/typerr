using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.DataBase.Models
{
    public class DbSeason
    {
        public DbSeason()
        {
            GameWeeks = new HashSet<DbGameWeek>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public virtual ICollection<DbGameWeek> GameWeeks { get; set; }
    }
}
