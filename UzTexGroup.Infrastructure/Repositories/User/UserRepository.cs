using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

public class UserRepository : GenericRepository<User, Guid>, IUserRepository
{
	public UserRepository(UzTexGroupDbContext appDbContext)
		: base(appDbContext)
	{
	}
}
