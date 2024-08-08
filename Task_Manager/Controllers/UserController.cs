using Microsoft.AspNetCore.Mvc;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Controllers;
[Route("[controller]")]

public class UserController : AbstractController<User>
{

    private readonly IUserRepository _repository;
    public UserController(IUserRepository repository) : base(repository)
    {
        _repository = repository;
    }
}