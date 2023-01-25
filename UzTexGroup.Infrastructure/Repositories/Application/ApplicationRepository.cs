using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

public class ApplicationRepository : GenericRepository<Application, Guid>, IApplicationRepository
{
	public ApplicationRepository(UzTexGroupDbContext appDbContext)
		: base(appDbContext)
	{
	}
}
