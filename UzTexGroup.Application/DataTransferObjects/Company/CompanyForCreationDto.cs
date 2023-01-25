namespace UzTexGroup.Application.DataTransferObjects.Company;
public record CompanyForCreationDto(
    string companyName,
    int? employeeCount,
    int? exportingCountriesCount,
    string titleUz,
    string? titleUzc,
    string? titleEn,
    string? titleRu,
    string imageUrl,
    string aboutCompanyUz,
    string? aboutCompanyUzc,
    string? aboutCompanyEn,
    string? aboutCompanyRu);

