using Task_Manager.Models;

namespace Task_Manager.Interfaces;

public interface IUserRepository : IGenericInMemoryRepo<User>
{
    User GetWithRolesAndTasks(int userId);
}