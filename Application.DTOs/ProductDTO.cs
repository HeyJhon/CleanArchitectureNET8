namespace Application.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public int Stock { get; init; }
        public string Description { get; init; }
    }
}
