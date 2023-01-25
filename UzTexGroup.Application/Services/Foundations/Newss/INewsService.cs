using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Foundations.Newss;

public interface INewsService
{
    ValueTask<News> CreateUserAsync(News news);
    IQueryable<News> RetrieveUsers();
    ValueTask<News> RetrieveUserByIdAsync(Guid newsId);
    ValueTask<News> ModifyUserAsync(News news);
    ValueTask<News> RemoveUserAsync(Guid newsId);
}
