namespace UzTexGroup.Application.DataTransferObjects;
public record CompanyDto(
    Guid? id,
    string companyName,
    DateTime foundedDate,
    int employeeCount,
    int exportCountryCount,
    AboutCompaniesDto? aboutCompanies,
    ICollection<UzTexGroup.Domain.Entities.Factory>? Factories);
