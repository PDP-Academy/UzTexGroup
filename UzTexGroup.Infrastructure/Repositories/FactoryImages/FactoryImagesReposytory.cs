using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

internal class FactoryImagesReposytory : GenericRepository<FactoryImages, Guid>, IFactoryImagesReposytory
{
    public FactoryImagesReposytory(UzTexGroupDbContext appDbContext) 
        : base(appDbContext)
    {
    }
}
