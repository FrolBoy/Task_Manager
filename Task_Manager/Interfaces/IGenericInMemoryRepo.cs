namespace Task_Manager.Interfaces;

public interface IGenericInMemoryRepo<T>
{ 
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<int> CreateAsync(T entity);
    Task<bool> UpdateAsync(int id, T entity);
    Task<bool> DeleteAsync(int id);
    Task<int> SaveChanges();
}