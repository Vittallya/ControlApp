namespace ControlApp.Core.Entities;

public interface IModel
{
    int Id { get; }

    IEntity GetEntity();

    void CopyFromEntiy(IEntity entity);
}
