using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IEntityService<TEntity>
    where TEntity : IEntity
{
    Task<EntityOperationResult<TEntity>> AddOrUpdateAsync(TEntity entity);
    Task<EntityOperationResult<TEntity>> DeleteAsync(int id);
}
