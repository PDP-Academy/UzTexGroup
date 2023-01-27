using UzTexGroup.Application.DataTransferObjects.User;
using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.Models;
using UzTexGroup.Domain.Entities;
using UzTexGroup.Application.Services.Processings.DataTransferObjects;
using UzTexGroup.Application.Services.Processings.DataTransferObjects.News;

namespace UzTexGroup.Application.Services.Processings.Newss;

public interface INewsService
{
    ValueTask<NewsDto> CreateNewsAsync(NewsForCreationDto newsForCreationDto);
    IQueryable<NewsDto> RetrieveNews(QueryParameter queryParameter);
    ValueTask<NewsDto> RetrieveNewsByIdAsync(Guid newsId);
    ValueTask<NewsDto> ModifyNewsAsync(UserForModificationDto userForModificationDto);
    ValueTask<NewsDto> RemoveNewsAsync(Guid userId);
}
