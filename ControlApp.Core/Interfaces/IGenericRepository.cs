namespace ControlApp.Core.Entities;

public interface IGenericRepository<T>
{
    Task<IReadOnlyCollection<T>> GetAllItems(string? include = null);
    Task<int> AddItem(T entity);
    Task<int> UpdateItem(T entity);
    Task<int> DeleteItem(int id);
    Task<int> DeleteItems(params int[] ids);
}
