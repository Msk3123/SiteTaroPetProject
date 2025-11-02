using Contracts.Interface;
using Entities.Models;
using Entities.Data;
using Microsoft.EntityFrameworkCore;


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
    
    public void RemoveCartTaro(CartTaro cartTaro)
    {
        if (cartTaro == null)
            throw new ArgumentNullException(nameof(cartTaro));
            
        _context.CartTaro.Remove(cartTaro);
    }
    public void UpdateCartTaro(CartTaro cartTaro)
    {
        if (cartTaro == null)
            throw new ArgumentNullException(nameof(cartTaro));
            
        _context.CartTaro.Update(cartTaro);
    }
    public async Task<IEnumerable<CartTaro>> GetAllCartTaro()
    {
        return await _context.CartTaro.AsNoTracking().ToListAsync();
    }
    
}