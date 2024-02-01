using Application.DTOs;

namespace Application.UseCasePorts;

public interface IGetAllProductsOutputPort
{
    Task Handle(IEnumerable<ProductDTO> products);
}