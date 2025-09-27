using Microsoft.EntityFrameworkCore;
namespace Contracts.Interface;

public interface IRepositoryManager
{
    IUser User { get; }
    ICartTaro CartTaro { get; }
    void Save();
    
}