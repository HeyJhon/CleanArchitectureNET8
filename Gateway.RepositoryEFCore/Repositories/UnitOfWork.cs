using Domain.Entities.Interfaces;
using Gateway.RepositoryEFCore.DataContext;

namespace Gateway.RepositoryEFCore.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationEFContext _context;
    public UnitOfWork(ApplicationEFContext context)
    {
        _context = context;
    }
    public Task<int> SaveChanges()
    {
        return _context.SaveChangesAsync();
    }
}