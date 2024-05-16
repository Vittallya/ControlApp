using ControlApp.Core.Entities;

namespace ControlApp.ViewModels;

public class ProductIncomeViewModel(ProductIncomeEntity incomeEntity)
{
    public int Id { get; set; } = incomeEntity.Id;
    public required int ProductId { get; set; } = incomeEntity.ProductId;
    public required DateTimeOffset IncomeDate { get; set; } = incomeEntity.IncomeDate;
    public required int Count { get; set; } = incomeEntity.Count;
    public required decimal TotalSum { get; set; } = incomeEntity.TotalSum;
    public string? Additional { get; set; } = incomeEntity.Additional;
    public ProductEntity? Product { get; set; } = incomeEntity.ProductEntity;
    public string? ProductName { get; set; } = incomeEntity.ProductEntity?.Name;
}
