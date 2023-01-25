using UzTexGroup.Application.DataTransferObjects.User;
using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.Models;

namespace UzTexGroup.Application.Services.Users;

public interface IUserFactory
{
    ValueTask<UserDto> CreateUserAsync(UserForCreationDto userForCreationDto);
    IQueryable<UserDto> RetrieveUsers(QueryParameter queryParameter);
    ValueTask<UserDto> RetrieveUserByIdAsync(Guid userId);
    ValueTask<UserDto> ModifyUserAsync(UserForModificationDto userForModificationDto);
    ValueTask<UserDto> RemoveUserAsync(Guid userId);
}
