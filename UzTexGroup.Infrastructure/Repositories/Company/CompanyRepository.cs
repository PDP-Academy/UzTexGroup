using Microsoft.EntityFrameworkCore.Query.Internal;
using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;
public class CompanyRepository : GenericRepository<Company, Guid>, ICompanyRepository
{
	public CompanyRepository(UzTexGroupDbContext appContext) 
		: base(appContext)
	{
	}
}
