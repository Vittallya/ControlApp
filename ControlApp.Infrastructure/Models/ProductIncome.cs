using ControlApp.Core.Entities;

namespace ControlApp.Infrastructure.Models;

public class ProductIncome : IModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public DateTimeOffset IncomeDate { get; set; }
    public int Count { get; set; }
    public decimal TotalSum { get; set; }
    public string? Additional { get; set; }
    public Product? Product { get; set; }

    public void CopyFromEntiy(IEntity entity)
    {
        if (entity is ProductIncomeEntity incomeEntity)
        {
            Id = incomeEntity.Id;
            ProductId = incomeEntity.ProductId;
            IncomeDate = incomeEntity.IncomeDate;
            TotalSum = incomeEntity.TotalSum;
            Additional = incomeEntity.Additional;
            Count = incomeEntity.Count;
        }
    }

    public IEntity GetEntity()
    {
        return new ProductIncomeEntity
        {
            Id = Id,
            Count = Count,
            ProductId = ProductId,
            IncomeDate = IncomeDate.DateTime,
            TotalSum = TotalSum,
            Additional = Additional,
            ProductEntity = Product?.GetEntity() as ProductEntity
        };
    }
}
