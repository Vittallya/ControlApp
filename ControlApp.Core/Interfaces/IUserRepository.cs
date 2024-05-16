using ControlApp.Core.Entities;

namespace ControlApp.Core.Entities;

public interface IUserRepository
{
    Task<UserEntity?> GetUserByLoginAsync(string login, CancellationToken cancellationToken);
    Task<UserEntity?> GetUserByIdAsync(int id);
    Task<int> AddUserAsync(UserEntity user);
}
