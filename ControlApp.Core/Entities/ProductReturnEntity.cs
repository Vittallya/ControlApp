namespace ControlApp.Core.Entities;

public class ProductReturnEntity : IEntity
{
    public ProductReturnEntity()
    {
        ReturnDate = DateTime.UtcNow;
    }

    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTime ReturnDate { get; set; }
    public int Count { get; set; }
    public string Reason { get; set; }
    public string? Additional { get; set; }
    public ProductEntity? Product { get; set; }
    public string? ProductName => Product?.Name;
}
