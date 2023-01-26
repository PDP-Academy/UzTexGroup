using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.Company;
public interface ICompanyServices
{
    ValueTask<UzTexGroup.Domain.Entities.Company> CreateUserAsync(UzTexGroup.Domain.Entities.Company company);
    IQueryable<UzTexGroup.Domain.Entities.Company> RetrieveUsers();
    ValueTask<UzTexGroup.Domain.Entities.Company> RetrieveUserByIdAsync(Guid companyId);
    ValueTask<UzTexGroup.Domain.Entities.Company> ModifyUserAsync(UzTexGroup.Domain.Entities.Company company);
    ValueTask<UzTexGroup.Domain.Entities.Company> RemoveUserAsync(Guid companyId);
}
