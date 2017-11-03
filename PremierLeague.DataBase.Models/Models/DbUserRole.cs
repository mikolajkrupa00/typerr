using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.DataBase.Models
{
    public class DbUserRole
    {
        public DbUserRole()
        {
            Users = new HashSet<DbUser>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public ICollection<DbUser> Users { get; set; }
    }
}
