using ControlApp.Core.Entities;

namespace ControlApp.Interfaces;

public interface IEntityUserControl<TEntity>
    where TEntity : IEntity
{
    void SetupEntity(TEntity entity);

    TEntity Entity { get; }
}
