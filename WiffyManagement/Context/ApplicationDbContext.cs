using Microsoft.EntityFrameworkCore;
using WiffyManagement.Data;

namespace WiffyManagement.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}
