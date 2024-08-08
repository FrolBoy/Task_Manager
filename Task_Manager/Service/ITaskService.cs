namespace Task_Manager.Service;

public interface ITaskService
{
    Task<bool> AssignTask(int userId, int taskId);
}