using UzTexGroup.Application.DataTransferObjects;
using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Processings.Factory.CompanyProcessing;

public interface ICompanyFactory
{
    CompanyDto MapToCompanyDto(Company company);
    Company MapToCompany(CompanyForCreationDto companyForCreationDto);
    void MapToCompany(Company storageCompany, CompanyForModificationDto companyForModificationDto);
}
