using Application.DTOs;

namespace Application.UseCasePorts;

public interface ICreateProductInputPort
{
    Task Handle(CreateProductDTO  product);
}