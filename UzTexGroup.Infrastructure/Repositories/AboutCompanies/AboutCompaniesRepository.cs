using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

public class AboutCompaniesRepository 
    : GenericRepository<AboutCompanies,Guid>,IAboutCompaniesRepository
{
	public AboutCompaniesRepository(UzTexGroupDbContext appDbContext)
		: base(appDbContext)
	{

	}
}
