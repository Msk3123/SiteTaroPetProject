namespace Contracts.Interface;

public interface IRepositoryBase<T>
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<bool> ExistsAsync(int id);
}