using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;
namespace UzTexGroup.Infrastructure.Repositories;
public class NewsRepository : GenericRepository<News, Guid>, INewsRepository
{
    public NewsRepository(UzTexGroupDbContext appDbContext) : base(appDbContext)
    {
    } 
}
