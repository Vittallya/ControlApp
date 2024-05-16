using ControlApp.Core.Entities;
using ControlApp.EF;
using ControlApp.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ControlApp.Infrastructure.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly AppDbContext dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<int> AddUserAsync(UserEntity user)
    {
        var model = user.GetModelFromEntityWithoutId();
        await dbContext.Users.AddAsync(model);
        return await dbContext.SaveChangesAsync();
    }

    public async Task<UserEntity?> GetUserByIdAsync(int id)
    {
        var user = await dbContext.Users.FindAsync(id);
        return user?.GetEntity() as UserEntity;
    }

    public async Task<UserEntity?> GetUserByLoginAsync(string login, CancellationToken cancellationToken)
    {
        var user = await dbContext.Users.FirstOrDefaultAsync(user => user.Login == login, cancellationToken);
        return user?.GetEntity() as UserEntity;
    }
}
