using ControlApp.Core.Entities;

namespace ControlApp.Core.Interfaces;

public interface IAccountValidationService<TEntity>
    where TEntity : IEntity
{
    Task<bool> Validate(TEntity entity, TEntity? preview);
}
