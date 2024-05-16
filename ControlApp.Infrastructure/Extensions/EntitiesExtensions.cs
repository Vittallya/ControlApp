using ControlApp.Core.Entities;
using ControlApp.Infrastructure.Models;

namespace ControlApp.Infrastructure.Extensions;

public static class EntitiesExtensions
{
    public static User GetModelFromEntityWithoutId(this UserEntity userEntity)
    {
        return new User 
        { 
            Login = userEntity.Login,
            Name = userEntity.Name,
            PasswordHash = userEntity.PasswordHash 
        };
    }

    public static User CopyDataToModel(this UserEntity userEntity, User user)
    {
        user.Login = userEntity.Login;
        user.Name = userEntity.Name;
        user.PasswordHash = userEntity.PasswordHash;
        return user;
    }

    public static Product GetModelFromEntityWithoutId(this ProductEntity productEntity)
    {
        return new Product
        {
            Category = productEntity.Category,
            Cost = productEntity.Cost,
            Count = productEntity.Count,
            Description = productEntity.Description,
            ImageName = productEntity.ImageName,
            Manufacturer = productEntity.Manufacturer,
            Name = productEntity.Name,
        };
    }

    public static Product CopyDataToModel(this ProductEntity productEntity, Product product)
    {
        product.Name = productEntity.Name;
        product.Description = productEntity.Description;
        product.Category = productEntity.Category;
        product.Cost = productEntity.Cost;
        product.Count = productEntity.Count;
        product.Manufacturer = productEntity.Manufacturer;
        product.ImageName = productEntity.ImageName;
        return product;
    }

    public static ProductEntity GetProductEntity(this Product product)
    {
        return new ProductEntity
        {
            Category = product.Category,
            Cost = product.Cost,
            Count = product.Count,
            Manufacturer = product.Manufacturer,
            Name = product.Name,
            Description = product.Description,
            ImageName= product.ImageName,
            Id = product.Id
        };
    }
}
