using ControlApp.Core.Entities;

namespace ControlApp.Infrastructure.Models;

public class Sale : IModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTimeOffset SaleDate { get; set; }
    public int Count { get; set; }
    public decimal TotalSum { get; set; }
    public string? Additional { get; set; }
    public Product? Product { get; set; }

    public void CopyFromEntiy(IEntity entity)
    {
        if (entity is ProductSaleEntity saleEntity)
        {
            Id = saleEntity.Id;
            ProductId = saleEntity.ProductId;
            TotalSum = saleEntity.TotalSum;
            Additional = saleEntity.Additional;
            Count = saleEntity.Count;
            SaleDate = saleEntity.SaleDate;
        }
    }

    public IEntity GetEntity()
    {
        return new ProductSaleEntity
        {
            Id = Id,
            Count = Count,
            ProductId = ProductId,
            TotalSum = TotalSum,
            Additional = Additional,
            SaleDate = SaleDate.DateTime,
            Product = Product?.GetEntity() as ProductEntity
        };
    }
}
