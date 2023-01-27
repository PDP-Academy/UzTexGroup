namespace UzTexGroup.Application.DataTransferObjects;
public record CompanyForModificationDto(
    Guid companyId,
    string? companyName,
    int? employeeCount,
    int? exportingCountriesCount,
    string? titleUz,
    string? titleUzc,
    string? titleEn,
    string? titleRu,
    string? imageUrl,
    string? aboutCompanyUz,
    string? aboutCompanyUzc,
    string? aboutCompanyEn,
    string? aboutCompanyRu);
