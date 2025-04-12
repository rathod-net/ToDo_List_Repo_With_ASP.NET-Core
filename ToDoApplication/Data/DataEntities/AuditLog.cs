using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class AuditLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Action { get; set; }  // e.g., Created, Updated, Deleted
        public string TableName { get; set; }
        public string RecordId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public Guid? UserId { get; set; }
        public User User { get; set; }
    }

}
