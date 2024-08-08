using Task_Manager.Database;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Repositories;

public class TaskRepository : AbstractRepo<TaskModel>, ITaskRepository
{
    public TaskRepository(ApplicationDbContext context) : base(context)
    {
        
    }
}