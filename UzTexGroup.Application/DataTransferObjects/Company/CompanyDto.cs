using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.DataTransferObjects.Company;
public record CompanyDto(
    Guid id,
    string companyName,
    DateTime foundedDate,
    int employeeCount,
    int exportCountryCount,
    AboutCompaniesDto? aboutCompanies,
    ICollection<Factory> Factories);
