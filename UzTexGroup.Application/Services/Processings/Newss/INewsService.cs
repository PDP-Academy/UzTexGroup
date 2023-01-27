using UzTexGroup.Application.DataTransferObjects.User;
using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.Models;
using UzTexGroup.Domain.Entities;
using UzTexGroup.Application.Services.Processings.DataTransferObjects;
using UzTexGroup.Application.Services.Processings.DataTransferObjects.News;

namespace UzTexGroup.Application.Services.Processings.Newss;

public interface INewsService
{
    ValueTask<NewsDto> CreateUserAsync(NewsForCreationDto newsForCreationDto);
    IQueryable<NewsDto> RetrieveUsers(QueryParameter queryParameter);
    ValueTask<NewsDto> RetrieveUserByIdAsync(Guid newsId);
    ValueTask<NewsDto> ModifyUserAsync(UserForModificationDto userForModificationDto);
    ValueTask<NewsDto> RemoveUserAsync(Guid userId);
}
