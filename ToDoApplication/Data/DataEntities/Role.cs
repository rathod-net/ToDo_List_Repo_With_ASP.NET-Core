using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class Role
    {
        public Guid RoleId { get; set; }= Guid.NewGuid();
        [Required]
        public string RoleName { get; set; } // Admin,User etc.
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
