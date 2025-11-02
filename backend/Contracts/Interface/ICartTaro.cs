using Entities.Models;

namespace Contracts.Interface;

public interface ICartTaro
{
    public void AddCartTaro(CartTaro user);
    
    public void RemoveCartTaro(CartTaro user);
    
    public void UpdateCartTaro(CartTaro user);
    
    public Task<IEnumerable<CartTaro>> GetAllCartTaro();

}