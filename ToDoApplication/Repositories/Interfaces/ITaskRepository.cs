using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DataEntities;

namespace Repositories.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<ToDoTask>> GetAllTasksAsync();
        Task<ToDoTask?> GetTaskByIdAsync(int id);
        Task AddTaskAsync(ToDoTask task);
        Task UpdateTaskAsync(ToDoTask task);
        Task DeleteTaskAsync(int id);
    }
}
