using Microsoft.EntityFrameworkCore;
namespace Contracts.Interface;

public interface IRepositoryManager
{
    public IUser User { get; }
    public    ICartTaro CartTaro { get; }

    public void Save();
    public Task SaveAsync();
    
}