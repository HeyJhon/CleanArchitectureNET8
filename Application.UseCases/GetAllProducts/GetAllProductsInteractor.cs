using Application.DTOs;
using Application.UseCasePorts;
using Domain.Entities.Interfaces;

namespace Application.UseCases.GetAllProducts;

public class GetAllProductsInteractor : IGetAllProductsInputPort
{
    private readonly IProductRepository _repository;
    private readonly IGetAllProductsOutputPort _outputPort;
    public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
    {
        _repository = repository;
        _outputPort = outputPort;
    }
    public async Task Handle()
    {
        var getProducts = await _repository.GetAll();
        var products = getProducts.Select(p => new ProductDTO()
        {
            Name = p.Name,
            Description = p.Description,
            Price = p.Price
        });

        await _outputPort.Handle(products);
    }
}