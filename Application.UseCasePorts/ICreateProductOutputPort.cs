using Application.DTOs;

namespace Application.UseCasePorts;

public interface ICreateProductOutputPort
{
    Task Handle(ProductDTO product);
}