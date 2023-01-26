namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.AboutCompany;
public record AboutCompaniesDto(
    Guid Id,
    string titleUz,
    string? titleUzC,
    string? titleEn,
    string? titleRu,
    string imageUrl,
    string aboutCompanyUz,
    string? aboutCompanyUzC,
    string? aboutCompanyEn,
    string? aboutCompanyRu,
    Guid companyId);
