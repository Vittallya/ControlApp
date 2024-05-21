using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.EF;
using ControlApp.Infrastructure.Extensions;
using ControlApp.Infrastructure.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Repositories;

internal class ProductSaleRepository(AppDbContext dbContext) : GenericRepository<ProductSaleEntity, Sale>(dbContext), IProductSaleRepository
{
    public Task<int> GetTotalSalesCount(int productId)
    {
        var tableName = _dbContext.GetTableName<Sale>();
        var sql = $"SELECT SUM(Count) as TotalCount FROM {tableName} WHERE ProductId = @productId";
        var param = new SqlParameter("productId", productId);
        var queryResult = _dbContext.Database.SqlQueryRaw<TotalCountEntity>(sql, param).First().TotalCount;
        return Task.FromResult(queryResult.HasValue ? queryResult.Value : 0);
    }
}
