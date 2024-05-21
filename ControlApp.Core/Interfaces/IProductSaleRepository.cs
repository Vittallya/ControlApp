using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IProductSaleRepository : IGenericRepository<ProductSaleEntity>
{
    Task<int> GetTotalSalesCount(int productId);
}
