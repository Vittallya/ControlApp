using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IProductReturnRepository : IGenericRepository<ProductReturnEntity>
{
    Task<int> GetTotalCount(int productId);
}
