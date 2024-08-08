using Microsoft.AspNetCore.Mvc;
using Task_Manager.Service;

namespace Task_Manager.Controllers;
[Route("[controller]")]

public class MainController : ControllerBase
{

    private readonly ITaskService _taskService;
    
    public MainController(ITaskService taskService)
    {
        _taskService = taskService;
    }
    
    [HttpPut("assign-task")]
    public async Task<bool> AssignTask(int userId, int taskId)
    {
       return await _taskService.AssignTask(userId, taskId);
    }
}