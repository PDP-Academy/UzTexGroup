using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;
public class JobRepository : GenericRepository<Jobs, Guid>, IJobRepository
{
	public JobRepository(UzTexGroupDbContext appDbContext) : base(appDbContext)
	{
	}
}
