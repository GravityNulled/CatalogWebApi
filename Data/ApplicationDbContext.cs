using Catalog.Model;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<item>? Items { get; set; }
    }
}