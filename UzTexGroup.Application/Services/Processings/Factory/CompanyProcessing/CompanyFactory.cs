using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Processings.Factory.CompanyProcessing;

public class CompanyFactory : ICompanyFactory
{
    public Company MapToCompany(
        CompanyForCreationDto companyForCreationDto)
    {
        return new Company
        {
            CompanyName = companyForCreationDto.companyName,
            EmployeeCount = companyForCreationDto.employeeCount ?? 0,
            ExportingCountriesCount = companyForCreationDto.exportingCountriesCount ?? 0,
            AboutCompany = new AboutCompanies
            {
                AboutCompanyEn = companyForCreationDto.aboutCompanyEn,
                AboutCompanyRu = companyForCreationDto.aboutCompanyRu,
                AboutCompanyUz = companyForCreationDto.aboutCompanyUz,
                AboutCompanyUzC = companyForCreationDto.aboutCompanyUzc,
                TitleEn = companyForCreationDto.titleEn,
                TitleRu = companyForCreationDto.titleRu,
                TitleUz = companyForCreationDto.titleUz,
                TitleUzC = companyForCreationDto.titleUzc,
                ImageUrl = companyForCreationDto.imageUrl
            }
        };
    }

    public CompanyDto MapToCompanyDto(Company company)
    {
        return new CompanyDto
        (
            null,
            company.CompanyName,
            company.FoundedDate,
            company.EmployeeCount,
            company.ExportingCountriesCount,
            new AboutCompaniesDto
            (
                null,
                company.AboutCompany.TitleUz,
                company.AboutCompany.TitleUzC,
                company.AboutCompany.TitleEn,
                company.AboutCompany.TitleRu,
                company.AboutCompany.ImageUrl,
                company.AboutCompany.AboutCompanyUz,
                company.AboutCompany.AboutCompanyUzC,
                company.AboutCompany.AboutCompanyEn,
                company.AboutCompany.AboutCompanyRu,
                company.AboutCompany.Id

            ),
            null
        );
    }

    public void MapToCompany(
        Company storageCompany,
        CompanyForModificationDto companyForModificationDto)
    {
        storageCompany.CompanyName = companyForModificationDto.companyName ?? storageCompany.CompanyName;
        storageCompany.EmployeeCount = companyForModificationDto.employeeCount ?? storageCompany.EmployeeCount;
        storageCompany.ExportingCountriesCount = companyForModificationDto.exportingCountriesCount ?? storageCompany.ExportingCountriesCount;
        storageCompany.AboutCompany.TitleUz = companyForModificationDto.titleUz;
        storageCompany.AboutCompany.TitleUzC = companyForModificationDto.titleUzc ?? storageCompany.AboutCompany.TitleUzC;
        storageCompany.AboutCompany.TitleEn = companyForModificationDto.titleEn ?? storageCompany.AboutCompany.TitleEn;
        storageCompany.AboutCompany.TitleRu = companyForModificationDto.titleRu ?? storageCompany.AboutCompany.TitleRu;
        storageCompany.AboutCompany.ImageUrl = companyForModificationDto.imageUrl ?? storageCompany.AboutCompany.ImageUrl;
        storageCompany.AboutCompany.AboutCompanyUz = companyForModificationDto.aboutCompanyUz;
        storageCompany.AboutCompany.AboutCompanyUzC = companyForModificationDto.aboutCompanyUzc ?? storageCompany.AboutCompany.AboutCompanyUzC;
        storageCompany.AboutCompany.AboutCompanyEn = companyForModificationDto.aboutCompanyEn ?? storageCompany.AboutCompany.AboutCompanyEn;
        storageCompany.AboutCompany.AboutCompanyRu = companyForModificationDto.aboutCompanyRu ?? storageCompany.AboutCompany.AboutCompanyRu;
        storageCompany.FoundedDate = DateTime.UtcNow;
    }
}
