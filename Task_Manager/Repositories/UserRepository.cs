using Microsoft.EntityFrameworkCore;
using Task_Manager.Database;
using Task_Manager.Interfaces;
using Task_Manager.Models;

namespace Task_Manager.Repositories;

public class UserRepository : AbstractRepo<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
        
    }

    public User GetWithRolesAndTasks(int userId)
    {
        return _context.Users.Where(u => u.Id == userId).Include(u => u.UserRole).Include(u => u.ActiveTasks).FirstOrDefault();
    }
}