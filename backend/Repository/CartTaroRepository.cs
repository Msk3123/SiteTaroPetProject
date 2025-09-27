using Contracts.Interface;
using Entities.Models;
using Entities.Data;

namespace Repository;

public class CartTaroRepository : RepositoryBase<CartTaro>, ICartTaro
{
    public CartTaroRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
   
    
    public void AddCartTaro(CartTaro cartTaro)
    {
        if (cartTaro == null)
            throw new ArgumentNullException(nameof(cartTaro));
            
        _context.CartTaro.Add(cartTaro);
    }
}