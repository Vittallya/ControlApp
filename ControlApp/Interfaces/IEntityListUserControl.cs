using ControlApp.Core.Entities;

namespace ControlApp.Interfaces;

public interface IEntityListUserControl<TEntity>
    where TEntity : IEntity
{
    int SelectedCount { get; }
    IReadOnlyCollection<TEntity> SelectedEntities { get; }
    void SetupDataSource(IReadOnlyCollection<TEntity> entities);
}
