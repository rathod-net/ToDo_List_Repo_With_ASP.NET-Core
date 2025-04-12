using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class TaskComment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid TaskId { get; set; }
        public ToDoTask Task { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }

}
