using Entities.Models;
using Contracts.Interface;
using Entities.Data;
using Microsoft.EntityFrameworkCore;
namespace Repository;

public class UserRepository : RepositoryBase<User>, IUser
{
    public UserRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
    
    public async Task<User?> GetByIdAsync(int id)
    {
        return await _context.User.FindAsync(id);
    }
    
    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _context.User
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    
    public void AddUser(User user)
    {
        if (user == null)
            throw new ArgumentNullException(nameof(user));
            
        _context.User.Add(user);
    }
}