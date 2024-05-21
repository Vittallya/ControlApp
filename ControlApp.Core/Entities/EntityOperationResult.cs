namespace ControlApp.Core.Entities;

public enum OperationResultStatus
{
    Ok, Error, Warning
}

public class EntityOperationResult<TEntity>(OperationResultStatus status, TEntity entity, IReadOnlyCollection<string>? errors)
    where TEntity : IEntity
{

    public EntityOperationResult(bool isOk, TEntity entity, IReadOnlyCollection<string>? errors = null)
        :this(isOk ? OperationResultStatus.Ok : OperationResultStatus.Error, entity, errors)
    {
        
    }

    public OperationResultStatus Status { get; } = status;
    public IReadOnlyCollection<string> Errors { get; } = errors ?? [];

    public TEntity Entity { get; } = entity;
}
