using Microsoft.AspNetCore.Mvc;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Controllers;
[Route("[controller]")]
public class RoleController : AbstractController<Role>
{

    private readonly IRoleRepository _roleRepository;
    public RoleController(IRoleRepository roleRepository) : base(roleRepository)
    {
        _roleRepository = roleRepository;
    }
}