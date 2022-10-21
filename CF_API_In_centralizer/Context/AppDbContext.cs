using CF_API_In_centralizer.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CF_API_In_centralizer.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto>? Produtos { get; set;}
    }
}
