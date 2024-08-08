using Microsoft.EntityFrameworkCore;
using Task_Manager.Interfaces;
using Task_Manager.Database;

namespace Task_Manager.Repositories;

public abstract class AbstractRepo<T> : IGenericInMemoryRepo<T> where T : class, IIdentifiable, new()
{
    protected readonly ApplicationDbContext _context;

    public AbstractRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }
    

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

   public async Task<int> CreateAsync(T entity)
      {
              await _context.Set<T>().AddAsync(entity);
              return await _context.SaveChangesAsync();
      }

    public async Task<bool> UpdateAsync(int id, T entity)
    {
        var existingEntity = await _context.Set<T>().FindAsync(id);
        if (existingEntity == null)
        {
            return false;
        }

        _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var removable = await _context.Set<T>().FindAsync(id);
        if (removable == null)
        {
            return false;
        }

        _context.Set<T>().Remove(removable);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }
}