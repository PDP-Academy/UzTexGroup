using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.AboutCompany;
public class AboutCompanyServices : IAboutCompanyServices
{
    private readonly IAboutCompaniesRepository aboutCompaniesRepository;
    public AboutCompanyServices(IAboutCompaniesRepository aboutCompaniesRepository)
    {
        this.aboutCompaniesRepository = aboutCompaniesRepository;
    }

    public ValueTask<AboutCompanies> CreateUserAsync(AboutCompanies aboutCompany)
    {
        throw new NotImplementedException();
    }

    public ValueTask<AboutCompanies> ModifyUserAsync(AboutCompanies aboutCompany)
    {
        throw new NotImplementedException();
    }

    public ValueTask<AboutCompanies> RemoveUserAsync(Guid aboutCompanyId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<AboutCompanies> RetrieveUserByIdAsync(Guid aboutCompanyId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<AboutCompanies> RetrieveUsers()
    {
        throw new NotImplementedException();
    }
}
