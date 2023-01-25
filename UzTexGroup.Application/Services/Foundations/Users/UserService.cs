using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.DataTransferObjects.User;
using UzTexGroup.Application.Models;
using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.Users;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public ValueTask<User> CreateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> ModifyUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> RemoveUserAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> RetrieveUserByIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> RetrieveUsers()
    {
        throw new NotImplementedException();
    }
}
