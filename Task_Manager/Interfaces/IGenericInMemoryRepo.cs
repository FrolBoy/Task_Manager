namespace Task_Manager.Interfaces;

public interface IGenericInMemoryRepo<T>
{ 
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync();
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}