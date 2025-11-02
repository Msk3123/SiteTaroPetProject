using Microsoft.Extensions.Logging;
using Contracts.Interface;
using Entities.Data;
using Entities.Models;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private IUser? _user;
    private ICartTaro? _cartTaro;
    private readonly ILogger<RepositoryManager> _logger;
    
    public RepositoryManager(RepositoryContext context, ILogger<RepositoryManager> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    public IUser User =>
        _user ??= new UserRepository(_context);
    
    public ICartTaro CartTaro =>
        _cartTaro ??= new CartTaroRepository(_context);
    public void Save()
    {
        try
        {
            _logger.LogInformation("Saving changes to database");
            _context.SaveChanges();
            _logger.LogInformation("Changes saved successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while saving changes");
                        throw; // Re-throw the exception
        }
    }

    public async Task SaveAsync()
    {
        try
        {
            _logger.LogInformation("Saving changes to database asynchronously");
            await _context.SaveChangesAsync();
            _logger.LogInformation("Changes saved successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while saving changes asynchronously");
            throw;
        }
    }
}