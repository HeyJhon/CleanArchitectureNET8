using Domain.Entities.Interfaces;
using Domain.Entities.POCOs;
using Gateway.RepositoryEFCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Gateway.RepositoryEFCore.Repositories;

public class ProductRepository: IProductRepository
{
    private readonly ApplicationEFContext _context;
    public ProductRepository(ApplicationEFContext context)
    {
        _context = context;
    }
    public async Task Create(Product product)
    {
       await _context.AddAsync(product);
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }
}