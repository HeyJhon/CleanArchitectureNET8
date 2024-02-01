using Application.DTOs;
using Application.UseCasePorts;

namespace JFMSystems.Presenters;

public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDTO>>
{
    public IEnumerable<ProductDTO> Content { get; private set; }

    public Task Handle(IEnumerable<ProductDTO> products)
    {
        Content = products;
        return Task.CompletedTask;
    }
}