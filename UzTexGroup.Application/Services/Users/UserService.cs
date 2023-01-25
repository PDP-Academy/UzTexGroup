using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.DataTransferObjects.User;
using UzTexGroup.Application.Models;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Users;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public ValueTask<UserDto> CreateUserAsync(UserForCreationDto userForCreationDto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserDto> ModifyUserAsync(UserForModificationDto userForModificationDto)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserDto> RemoveUserAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserDto> RetrieveUserByIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserDto> RetrieveUsers(QueryParameter queryParameter)
    {
        throw new NotImplementedException();
    }
}
