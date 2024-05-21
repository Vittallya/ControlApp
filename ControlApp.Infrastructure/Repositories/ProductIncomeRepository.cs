using ControlApp.Core.Entities;
using ControlApp.Core.Interfaces;
using ControlApp.EF;
using ControlApp.Infrastructure.Extensions;
using ControlApp.Infrastructure.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Repositories;

internal class ProductIncomeRepository(AppDbContext dbContext) : GenericRepository<ProductIncomeEntity, ProductIncome>(dbContext), IProductIncomeRepository
{
    public Task<int> GetTotalIncomeCount(int productId)
    {
        var tableName = _dbContext.GetTableName<ProductIncome>();
        var sql = $"SELECT SUM(COUNT) as TotalCount FROM {tableName} WHERE ProductId = @id";
        var idParam = new SqlParameter("id", productId);

        var count = _dbContext.Database.SqlQueryRaw<TotalCountEntity>(sql, idParam).First().TotalCount;

        return Task.FromResult(count.HasValue ? count.Value : 0);
    }
}
