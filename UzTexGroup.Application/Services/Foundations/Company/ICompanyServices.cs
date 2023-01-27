using UzTexGroup.Application.DataTransferObjects;

namespace UzTexGroup.Application.Services.Foundations;
public interface ICompanyServices
{
    ValueTask<CompanyDto> CreateCompanyAsync(CompanyForCreationDto companyForCreationDto);
    IQueryable<CompanyDto> RetrieveCompanies();
    ValueTask<CompanyDto> RetrieveCompanyByIdAsync(Guid companyId);
    ValueTask<CompanyDto> ModifyCompanyAsync(CompanyForModificationDto companyForModificationDto);
    ValueTask<CompanyDto> RemoveCompanyAsync(Guid companyId);
}
