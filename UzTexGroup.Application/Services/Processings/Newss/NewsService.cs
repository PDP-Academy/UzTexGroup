using UzTexGroup.Domain.Entities;
using UzTexGroup.Domain.Exceptions;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Processings.Newss;

public class NewsService : INewsService
{
    private readonly INewsRepository newsRepository;

    public NewsService(INewsRepository newsRepository)
    {
        this.newsRepository = newsRepository;
    }

    public async ValueTask<News> CreateNewsAsync(News news)
    {
        var createdNews = await newsRepository.InsertAsync(news);
        return createdNews;
    }

    public async ValueTask<News> ModifyNewsAsync(News news)
    {
        var modifiedNews = await newsRepository.UpdateAsync(news);
        return modifiedNews;
    }

    public async ValueTask<News> RemoveNewsAsync(Guid newsId)
    {
        var news = await RetrieveNewsByIdAsync(newsId);

        return await newsRepository.DeleteAsync(news);
    }

    public IQueryable<News> RetrieveNews()
    {
        return newsRepository.SelectAll();
    }

    public async ValueTask<News> RetrieveNewsByIdAsync(Guid newsId)
    {
        var news = await newsRepository.SelectByIdAsync(newsId);

        if (news is null)
        {
            throw new NotFoundException("News not found");
        }
        return news;
    }
}
