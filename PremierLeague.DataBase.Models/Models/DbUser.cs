using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierLeague.DataBase.Models
{ 
    public class DbUser
    {
        public DbUser()
        {
            UserId = new Guid();

            Types = new HashSet<DbExpectedResult>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public virtual ICollection<DbExpectedResult> Types { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public virtual DbUserRole UserRole { get; set; }
    }
}
