using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Gateway.RepositoryEFCore.DataContext;

public class ApplicationEFCoreContextFactory : IDesignTimeDbContextFactory<ApplicationEFContext>
{
    public ApplicationEFContext CreateDbContext(string[] args)
    {
        var optionsBuilder =
            new DbContextOptionsBuilder<ApplicationEFContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=JFMDSystemDb");

        return new ApplicationEFContext(optionsBuilder.Options);
    }
}