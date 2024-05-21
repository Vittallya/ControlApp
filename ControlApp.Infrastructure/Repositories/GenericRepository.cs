using ControlApp.Core.Entities;
using ControlApp.EF;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ControlApp.Infrastructure.Extensions;
using System.Text;

namespace ControlApp.Infrastructure.Repositories;

internal class GenericRepository<TEntity, TDbModel>(AppDbContext dbContext) : IGenericRepository<TEntity>
    where TEntity : IEntity
    where TDbModel : class, IModel, new()
{
    protected readonly AppDbContext _dbContext = dbContext;

    public async Task<TEntity> AddItem(TEntity entity)
    {

        var model = new TDbModel();
        model.CopyFromEntiy(entity);

        await _dbContext.Set<TDbModel>().AddAsync(model);
        await _dbContext.SaveChangesAsync();
        return (TEntity)model.GetEntity();
    }

    public async Task<int> DeleteItem(int id)
    {
        var model = await _dbContext.Set<TDbModel>().FindAsync(id);
        _dbContext.Remove(model!);
        return await _dbContext.SaveChangesAsync();
    }

    public Task<List<TResult>> ExecuteSqlRaw<TResult>(string sql, params object[] sqlParams)
        where TResult : class
    {
        var result = _dbContext
            .Database.SqlQueryRaw<TResult>(sql, sqlParams).ToList();
        return Task.FromResult(result);
    }

    public async Task<int> DeleteItems(params int[] ids)
    {
        var tableName = _dbContext.GetTableName<TDbModel>();

        var sqlLabels = 
            string.Join(",",
            Enumerable
            .Range(0, ids.Length)
            .Select(number => "@" + number));

        var stringBuilder = new StringBuilder();
        stringBuilder.Append("DELETE FROM ");
        stringBuilder.Append(tableName);
        stringBuilder.Append(" WHERE Id IN (");
        stringBuilder.Append(sqlLabels);
        stringBuilder.Append(")");

        var sql = stringBuilder.ToString();

        var sqlParams = ids.Select((id, index) => new SqlParameter("@" + index, id)).ToArray();

        return await _dbContext.Database.ExecuteSqlRawAsync(sql, sqlParams);
    }

    public async Task<IReadOnlyCollection<TEntity>> GetAllItems(string? include)
    {
        var set = _dbContext.Set<TDbModel>();

        var models = !string.IsNullOrEmpty(include) ?
            await set.Include(include!).ToListAsync() :
            await set.ToListAsync();

        return models
            .Select(model => (TEntity)model.GetEntity())
            .ToList();
    }

    public async Task<int> UpdateItem(TEntity entity)
    {
        var model = await _dbContext.Set<TDbModel>().FindAsync(entity.Id);
        model!.CopyFromEntiy(entity);
        return await _dbContext.SaveChangesAsync();
    }


    public async Task<TEntity> FindById(int id)
    {
        var model = await _dbContext.Set<TDbModel>().FindAsync(id);
        return (TEntity)model!.GetEntity();
    }
}
