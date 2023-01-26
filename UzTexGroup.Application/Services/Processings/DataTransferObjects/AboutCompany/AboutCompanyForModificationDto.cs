namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.AboutCompany;
public record AboutCompanyForModificationDto(
    string? titleUz,
    string? titleUzC,
    string? titleEn,
    string? titleRu,
    string? imageUrl,
    string? aboutCompanyUz,
    string? aboutCompanyUzC,
    string? aboutCompanyEn,
    string? aboutCompanyRu);
