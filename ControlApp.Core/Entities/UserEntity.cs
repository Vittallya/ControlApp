namespace ControlApp.Core.Entities;

public record UserEntity : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }
}
