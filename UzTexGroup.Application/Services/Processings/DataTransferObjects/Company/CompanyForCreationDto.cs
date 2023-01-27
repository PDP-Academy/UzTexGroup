namespace UzTexGroup.Application.DataTransferObjects;
public record CompanyForCreationDto(
    string companyName,
    int? employeeCount,
    int? exportingCountriesCount,
    DateTime foundedDate,
    string titleUz,
    string? titleUzc,
    string? titleEn,
    string? titleRu,
    string imageUrl,
    string aboutCompanyUz,
    string? aboutCompanyUzc,
    string? aboutCompanyEn,
    string? aboutCompanyRu);

