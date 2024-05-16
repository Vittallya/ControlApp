using ControlApp.Core.Entities;

namespace ControlApp.Core.Entities;

public class ProductIncomeEntity : IEntity
{
    public ProductIncomeEntity()
    {
        IncomeDate = DateTime.UtcNow;
    }
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTime IncomeDate { get; set; }
    public int Count { get; set; }
    public decimal TotalSum { get; set; }
    public string? Additional { get; set; }
    public ProductEntity? ProductEntity { get; set; }
    public string? ProductName => ProductEntity?.Name;
}
