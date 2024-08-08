using Task_Manager.Interfaces;

namespace Task_Manager.Service;

public class TaskService : ITaskService
{

    private readonly ITaskRepository _taskRepository;
    private readonly IUserRepository _userRepository;
    private readonly IRoleRepository _roleRepository;
    
    public TaskService(ITaskRepository taskRepository, IUserRepository userRepository, IRoleRepository roleRepository)
    {
        _taskRepository = taskRepository;
        _userRepository = userRepository;
        _roleRepository = roleRepository;
    }
    public async Task<bool> AssignTask(int userId, int taskId)
    {
        var user = _userRepository.GetWithRolesAndTasks(userId);
        var task = await _taskRepository.GetByIdAsync(taskId);
        

        if (user.ActiveTasks.Count <= user.UserRole.PermissionLevel)
        {
            user.ActiveTasks.Append(task);
            await _userRepository.SaveChanges();
            return true;
        }

        return false;
    }
}