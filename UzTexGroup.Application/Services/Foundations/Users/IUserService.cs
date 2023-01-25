using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Foundations.Users;

public interface IUserService
{
    ValueTask<User> CreateUserAsync(User user);
    IQueryable<User> RetrieveUsers();
    ValueTask<User> RetrieveUserByIdAsync(Guid userId);
    ValueTask<User> ModifyUserAsync(User user);
    ValueTask<User> RemoveUserAsync(Guid userId);
}
