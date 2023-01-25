using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

public class FactoryReposytory :GenericRepository<Factory,Guid>,IFactoryReposytory
{
    public FactoryReposytory(UzTexGroupDbContext appContext)
        : base(appContext)
    {
    }
}
