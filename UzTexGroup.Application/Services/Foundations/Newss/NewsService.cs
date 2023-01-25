using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.Newss;

public class NewsService : INewsService
{
    private readonly INewsRepository newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        this.newsRepository = newsRepository;
    }
    public ValueTask<News> CreateUserAsync(News news)
    {
        throw new NotImplementedException();
    }

    public ValueTask<News> ModifyUserAsync(News news)
    {
        throw new NotImplementedException();
    }

    public ValueTask<News> RemoveUserAsync(Guid newsId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<News> RetrieveUserByIdAsync(Guid newsId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<News> RetrieveUsers()
    {
        throw new NotImplementedException();
    }
}
