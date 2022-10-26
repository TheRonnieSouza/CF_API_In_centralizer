using CF_API_In_centralizer.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CF_API_In_centralizer.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
         public DbSet<Produto>? Produtos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //var connectionString = configuration.GetConnectionString("DefaultConnetion");
            optionsBuilder.UseSqlServer("Password=Insp1r0n@;Persist Security Info=True;User ID=sa;Initial Catalog=DBCOMPREFACIL;Data Source=RS\\SQLEXPRESS");
        }

    }
}
