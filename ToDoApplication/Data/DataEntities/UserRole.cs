using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class UserRole
    {
        public Guid UserRoleId { get; set; }
        public User User { get; set; }
        public Guid RoleId { get; set; }
        public Role  Role { get; set; }
    }
}
