using ControlApp.Core.Entities;

namespace ControlApp.Infrastructure.Models;

public class User : IModel
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }

    public void CopyFromEntiy(IEntity entity)
    {
        if(entity is UserEntity userEntity)
        {
            Id = userEntity.Id;
            Name = userEntity.Name;
            PasswordHash = userEntity.PasswordHash;
            Login = userEntity.Login;
        }
    }

    public IEntity GetEntity()
    {
        return new UserEntity { Id = Id, Name = Name, Login = Login, PasswordHash = PasswordHash };
    }
}
