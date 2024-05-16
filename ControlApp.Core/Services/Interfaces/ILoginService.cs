namespace ControlApp.Core.Services.Interfaces;

public interface ILoginService
{
    Task<int?> TryGetUserId(string username, CancellationToken cancellationToken);
    Task<bool> IsPasswordCorrect(int userId, string password, CancellationToken cancellationToken);
}
