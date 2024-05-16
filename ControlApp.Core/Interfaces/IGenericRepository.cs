namespace ControlApp.Core.Entities;

public interface IGenericRepository<T>
{
    Task<IReadOnlyCollection<T>> GetAllItems(string? include = null);
    Task<List<TResult>> ExecuteSqlRaw<TResult>(string sql, params object[] sqlParams)
        where TResult : class;
    Task<int> AddItem(T entity);
    Task<int> UpdateItem(T entity);
    Task<int> DeleteItem(int id);
    Task<int> DeleteItems(params int[] ids);
}
