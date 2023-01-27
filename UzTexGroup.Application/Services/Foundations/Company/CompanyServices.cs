using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Application.Services.Processings.Factory.CompanyProcessing;
using UzTexGroup.Domain.Entities;
using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations;
public class CompanyServices : ICompanyServices
{
    private readonly ICompanyRepository companyRepository;
    private readonly ICompanyFactory companyFactory;
    public CompanyServices(ICompanyRepository companyRepository,
        ICompanyFactory companyFactory)
    {
        this.companyRepository = companyRepository;
        this.companyFactory = companyFactory;
    }

    public async ValueTask<CompanyDto> CreateCompanyAsync(
        CompanyForCreationDto companyForCreationDto)
    {
        var newCompany = this.companyFactory
            .MapToCompany(companyForCreationDto);

        var addedCompany = await this.companyRepository
            .InsertAsync(newCompany);

        return this.companyFactory.MapToCompanyDto(addedCompany);
    }

    public async ValueTask<CompanyDto> ModifyCompanyAsync(
        CompanyForModificationDto companyForModificationDto)
    {
        var storageCompany = await this.companyRepository
            .SelectByIdWithDetailsAync(
            expression: company =>
            company.Id == companyForModificationDto.companyId,
            includes: new string[] { nameof(Company.AboutCompany) });

        return this.companyFactory.
            MapToCompanyDto(storageCompany);
    }

    public async ValueTask<CompanyDto> RemoveCompanyAsync(Guid companyId)
    {
        var storageCompany = await this.companyRepository
            .SelectByIdAsync(companyId);

        var removedCompany = await this.companyRepository
            .DeleteAsync(storageCompany);

        return this.companyFactory
            .MapToCompanyDto(removedCompany);
    }

    public IQueryable<CompanyDto> RetrieveCompanies()
    {
        var companies =  this.companyRepository.SelectAll();

        return companies.Select(company =>
        this.companyFactory.MapToCompanyDto(company));
    }

    public async ValueTask<CompanyDto> RetrieveCompanyByIdAsync(Guid companyId)
    {
        var storageCompany = await this.companyRepository
            .SelectByIdWithDetailsAync(
            expression: company => company.Id == companyId,
            includes: new string[] {nameof(Company.AboutCompany)});

        return this.companyFactory.MapToCompanyDto(storageCompany);
    }
}
