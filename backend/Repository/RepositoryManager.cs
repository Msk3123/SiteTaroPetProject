
using Contracts.Interface;
using Entities.Data;
using Entities.Models;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private IUser? _user;
    
    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
    }
    
    public IUser User =>
        _user ??= new UserRepository(_context);
    
    public void Save() => _context.SaveChanges();
    
    public async Task SaveAsync() => await _context.SaveChangesAsync();

}