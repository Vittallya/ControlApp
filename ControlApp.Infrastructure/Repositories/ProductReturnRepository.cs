using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.EF;
using ControlApp.Infrastructure.Extensions;
using ControlApp.Infrastructure.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Repositories;

internal class ProductReturnRepository(AppDbContext dbContext)
    : GenericRepository<ProductReturnEntity, ProductReturn>(dbContext), IProductReturnRepository
{
    public Task<int> GetTotalCount(int productId)
    {
        var tableName = _dbContext.GetTableName<ProductReturn>();
        var sql = $"SELECT SUM(COUNT) as TotalCount FROM {tableName} WHERE ProductId = @id";
        var idParam = new SqlParameter("id", productId);

        var count = _dbContext.Database.SqlQueryRaw<TotalCountEntity>(sql, idParam).First().TotalCount;

        return Task.FromResult(count.HasValue ? count.Value : 0);
    }
}
