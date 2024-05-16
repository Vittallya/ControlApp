using ControlApp.Core.Entities;

namespace ControlApp.Infrastructure.Models;

public class ProductReturn : IModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTimeOffset ReturnDate { get; set; }
    public int Count { get; set; }
    public string Reason { get; set; } = null!;
    public string? Additional { get; set; }
    public Product? Product { get; set; }

    public void CopyFromEntiy(IEntity entity)
    {
        if(entity is ProductReturnEntity returnEntity)
        {
            Id = returnEntity.Id;
            ProductId = returnEntity.ProductId;
            ReturnDate = returnEntity.ReturnDate;
            Count = returnEntity.Count;
            Additional = returnEntity.Additional;
            Reason = returnEntity.Reason;
        }
    }

    public IEntity GetEntity()
    {
        return new ProductReturnEntity
        {
            Id = Id,
            ProductId = ProductId,
            ReturnDate = ReturnDate.DateTime,
            Count = Count,
            Additional = Additional,
            Reason = Reason,
            Product = Product?.GetEntity() as ProductEntity
        };
    }
}
