using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Foundations.AboutCompany;
public interface IAboutCompanyServices
{
    ValueTask<AboutCompanies> CreateUserAsync(AboutCompanies aboutCompany);
    IQueryable<AboutCompanies> RetrieveUsers();
    ValueTask<AboutCompanies> RetrieveUserByIdAsync(Guid aboutCompanyId);
    ValueTask<AboutCompanies> ModifyUserAsync(AboutCompanies aboutCompany);
    ValueTask<AboutCompanies> RemoveUserAsync(Guid aboutCompanyId);
}