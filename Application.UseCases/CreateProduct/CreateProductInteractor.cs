using Application.DTOs;
using Application.UseCasePorts;
using Domain.Entities.Interfaces;
using Domain.Entities.POCOs;

namespace Application.UseCases.CreateProduct;

public class CreateProductInteractor : ICreateProductInputPort
{
    private readonly IProductRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateProductOutputPort _outputPort;
    public CreateProductInteractor(
        IProductRepository repository, 
        IUnitOfWork unitOfWork, 
        ICreateProductOutputPort outputPort)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
    }
    public async Task Handle(CreateProductDTO product)
    {
        Product newProduct = new Product()
        {
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock,
            Description = product.Description
        };

        await _repository.Create(newProduct);
        await _unitOfWork.SaveChanges();
        await _outputPort.Handle(new ProductDTO()
        {
           Id = newProduct.Id,
           Description = newProduct.Description,
           Name = newProduct.Name,
           Price = newProduct.Price,
           Stock = newProduct.Stock,
        });
    }
}