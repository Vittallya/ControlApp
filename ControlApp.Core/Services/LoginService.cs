using ControlApp.Core.Extensions;
using ControlApp.Core.Entities;
using ControlApp.Core.Services.Interfaces;

namespace ControlApp.Core.Services;

public class LoginService(IUserRepository userRepository) : ILoginService
{
    private readonly IUserRepository _userRepository = userRepository;

    public async Task<bool> IsPasswordCorrect(int userId, string password, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByIdAsync(userId);

        if (user != null)
        {
            return password.VerifyPassword(user.PasswordHash);
        }
        return false;
    }

    public async Task<int?> TryGetUserId(string username, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserByLoginAsync(username, cancellationToken);
        return user?.Id;
    }
}
