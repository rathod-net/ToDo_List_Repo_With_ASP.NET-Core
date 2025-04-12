using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataEntities
{
    public class User
    {
        public Guid UserId { get; set; }= Guid.NewGuid();
        [Required]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<ToDoTask> ToDoTasks  { get; set; }
    }
}
