using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IProductIncomeRepository : IGenericRepository<ProductIncomeEntity>
{
    Task<int> GetTotalIncomeCount(int productId);
}
