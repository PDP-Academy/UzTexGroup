using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.Company;
public class CompanyServices : ICompanyServices
{
    private readonly ICompanyRepository companyRepository;
    public CompanyServices(ICompanyRepository companyRepository)
    {
        this.companyRepository = companyRepository;
    }

    public ValueTask<Domain.Entities.Company> CreateUserAsync(Domain.Entities.Company company)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Domain.Entities.Company> ModifyUserAsync(Domain.Entities.Company company)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Domain.Entities.Company> RemoveUserAsync(Guid companyId)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Domain.Entities.Company> RetrieveUserByIdAsync(Guid companyId)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Domain.Entities.Company> RetrieveUsers()
    {
        throw new NotImplementedException();
    }
}
