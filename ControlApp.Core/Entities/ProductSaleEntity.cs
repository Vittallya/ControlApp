namespace ControlApp.Core.Entities;

public class ProductSaleEntity : IEntity
{
    public ProductSaleEntity()
    {
        SaleDate = DateTime.UtcNow;
    }

    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTime SaleDate { get; set; }
    public int Count { get; set; }
    public decimal TotalSum { get; set; }
    public string? Additional { get; set; }
    public ProductEntity? Product { get; set; }
    public string? ProductName => Product?.Name;
}
