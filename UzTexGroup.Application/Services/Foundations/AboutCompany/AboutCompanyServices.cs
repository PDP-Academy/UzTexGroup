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

    public async ValueTask<AboutCompanies> ModifyUserAsync(AboutCompanies aboutCompany)
    {
        aboutCompany = await this.aboutCompaniesRepository.UpdateAsync(aboutCompany);

        return aboutCompany;
    }

    public async ValueTask<AboutCompanies> RemoveUserAsync(Guid aboutCompanyId)
    {
        var abountCompany = new AboutCompanies() { Id = aboutCompanyId };
        
        abountCompany = await this.aboutCompaniesRepository.DeleteAsync(abountCompany);

        await this.aboutCompaniesRepository.SaveChangesAsync();

        return abountCompany;
    }

    public async ValueTask<AboutCompanies> RetrieveUserByIdAsync(Guid aboutCompanyId)
    {
        var abountCompany = await this.aboutCompaniesRepository.SelectByIdAsync(aboutCompanyId);

        return abountCompany;
    }

    public IQueryable<AboutCompanies> RetrieveUsers()
    {
        var aboutCompanyUsers = this.aboutCompaniesRepository.SelectAll();

        return aboutCompanyUsers;
    }
}
