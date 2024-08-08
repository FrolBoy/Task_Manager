using Task_Manager.Database;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Repositories;

public class RoleRepository : AbstractRepo<Role>, IRoleRepository
{
    public RoleRepository(ApplicationDbContext context) : base(context)
    {
        
    }
}