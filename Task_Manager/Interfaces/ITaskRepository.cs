using Task_Manager.Models;

namespace Task_Manager.Interfaces;

public interface ITaskRepository : IGenericInMemoryRepo<TaskModel>
{
    
}