namespace Task_Manager.Interfaces;

public interface IGenericInMemoryRepo<T>
{ 
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync();
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}