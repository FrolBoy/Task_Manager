using Microsoft.EntityFrameworkCore;
using Task_Manager.Interfaces;
using Task_Manager.Database;

namespace Task_Manager.Repositories;

public abstract class AbstractRepo<T> : IGenericInMemoryRepo<T> where T : class, IIdentifible, new()
{
    protected readonly ApplicationDbContext _context;

    public AbstractRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
    

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
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