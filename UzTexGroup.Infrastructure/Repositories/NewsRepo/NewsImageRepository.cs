using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories.NewsRepo
{
    public class NewsImageRepository : GenericRepository<NewImages, Guid>, INewsImageRepository
    {
        public NewsImageRepository(UzTexGroupDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
