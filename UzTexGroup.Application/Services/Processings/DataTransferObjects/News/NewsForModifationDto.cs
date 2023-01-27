using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.News;

public record NewsForModifationDto(
    string? titleUz,
    string? titleUzC,
    string? titleEn,
    string? titleRu,
    string? bodyUz,
    string? bodyUzC,
    string? bodyEn,
    string? bodyRu,
    ICollection<NewsImages>? images);
