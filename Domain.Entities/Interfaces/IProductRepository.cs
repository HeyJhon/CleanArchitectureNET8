using Domain.Entities.POCOs;

namespace Domain.Entities.Interfaces;

public interface IProductRepository
{
    Task Create(Product product);
    Task<IEnumerable<Product>> GetAll();
}