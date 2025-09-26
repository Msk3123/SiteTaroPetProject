using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Entities.Data;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
        
        
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
    public DbSet<CartTaro> CartTaro { get; set; }
    public DbSet<User> User { get; set; }
    
}