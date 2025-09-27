using Contracts.Interface;
using Entities.Data;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected readonly RepositoryContext _context;
    protected readonly DbSet<T> _dbSet;

    public RepositoryBase(RepositoryContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public virtual void Create(T entity)
    {
        _dbSet.Add(entity);
    }

    public virtual void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public virtual void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<bool> ExistsAsync(int id)
    {
        return await _dbSet.FindAsync(id) != null;
    }
}
