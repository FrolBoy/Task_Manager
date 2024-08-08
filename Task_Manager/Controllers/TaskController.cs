using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_Manager.Database;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Controllers;
[Route("[controller]")]
public class TaskController : AbstractController<TaskModel>
{
    private readonly ITaskRepository _repository;

    public TaskController(ITaskRepository repository) : base(repository)
    {
        _repository = repository;
    }

   
}