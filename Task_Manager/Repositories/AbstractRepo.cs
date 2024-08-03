using Task_Manager.Interfaces;

namespace Task_Manager.Repositories;

public abstract class AbstractRepo<T> : IGenericInMemoryRepo<T> where T : class, IIdentifible, new()
{
    

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }
}