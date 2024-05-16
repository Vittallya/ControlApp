using ControlApp.Core.Entities;

namespace ControlApp.Infrastructure.Models;

public class Product : IModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Category { get; set; }
    public required decimal Cost { get; set; }
    public required int Count { get; set; }
    public required string Manufacturer { get; set; }
    public required string Description { get; set; }
    public required string ImageName { get; set; }

    public void CopyFromEntiy(IEntity entity)
    {
        if (entity is ProductEntity productEntity)
        {
            Id = productEntity.Id;
            Name = productEntity.Name;
            Category = productEntity.Category;
            Cost = productEntity.Cost;
            Count = productEntity.Count;
            Manufacturer = productEntity.Manufacturer;
            Description = productEntity.Description;
            ImageName = productEntity.ImageName;
        }
    }

    public IEntity GetEntity()
    {
        return new ProductEntity
        {
            Id = Id,
            Name = Name,
            Category = Category,
            Cost = Cost,
            Count = Count,
            Manufacturer = Manufacturer,
            Description = Description,
            ImageName = ImageName,
        };
    }
}
