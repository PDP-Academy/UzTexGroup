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

    public async ValueTask<AboutCompanies> CreateUserAsync(AboutCompanies aboutCompany)
    {
        aboutCompany = await this.aboutCompaniesRepository.InsertAsync(aboutCompany);

        await this.aboutCompaniesRepository.SaveChangesAsync();

        return aboutCompany;
    }

    public ValueTask<AboutCompanies> ModifyUserAsync(AboutCompanies aboutCompany)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<AboutCompanies> RemoveUserAsync(Guid aboutCompanyId)
    {
        var abountCompany = new AboutCompanies() { Id = aboutCompanyId };
        
        abountCompany = await this.aboutCompaniesRepository.DeleteAsync(abountCompany);

        await this.aboutCompaniesRepository.SaveChangesAsync();

        return abountCompany;
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
