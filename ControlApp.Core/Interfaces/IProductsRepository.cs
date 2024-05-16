using ControlApp.Core.Entities;

namespace ControlApp.Core.Entities;

public interface IProductsRepository
{
    Task<IReadOnlyCollection<ProductEntity>> GetProducts(int skipCount = -1, int count = -1);
    Task<IReadOnlyCollection<ProductEntity>> GetProducts(ProductFilter filter);
    Task<int> AddProduct(ProductEntity product);
    Task<int> UpdateProduct(ProductEntity product);
    Task DeleteProduct(int productId);
    Task<ProductEntity?> GetById(int productId);
    Task<int> UpdateProductCount(int productId, int count);
}
