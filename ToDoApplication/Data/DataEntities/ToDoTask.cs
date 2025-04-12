using System.ComponentModel.DataAnnotations;

namespace Data.DataEntities
{
    public class ToDoTask
    {
        public Guid ToDoTaskId { get; set; }= Guid.NewGuid();
        [Required]
        public string TaskTitle { get; set; }
        [Required]
        public string TaskDescription { get; set; }
        [Required]
        public TaskType TaskType { get; set; } // Daily,Monthly,Yearly
        public DateTime CreatedAt { get; set; }=DateTime.UtcNow;
        public DateTime? DueDate {  get; set; }
        public bool IsCompleted { get; set; }=false;
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
    public enum TaskType
    {
        Daily, Monthly, Yearly
    }

}
