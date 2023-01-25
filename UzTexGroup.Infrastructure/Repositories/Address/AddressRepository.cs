using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.DbContexts;

namespace UzTexGroup.Infrastructure.Repositories;

public class AddressRepository : GenericRepository<Address,Guid>, IAddressRepository
{
	public AddressRepository(UzTexGroupDbContext appDbContext)
		: base(appDbContext)
	{

	}
}
