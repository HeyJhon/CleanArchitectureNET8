namespace Application.DTOs;

public class CreateProductDTO
{
    public string Name { get; init; }
    public decimal Price { get; init; }
    public int Stock { get; init; }
    public string Description { get; init; }
}