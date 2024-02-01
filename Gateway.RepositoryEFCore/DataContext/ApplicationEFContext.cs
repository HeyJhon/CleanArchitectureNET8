using Domain.Entities.POCOs;
using Microsoft.EntityFrameworkCore;

namespace Gateway.RepositoryEFCore.DataContext
{
    public class ApplicationEFContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationEFContext(DbContextOptions<ApplicationEFContext> options) : base(options) { }
    }
}
