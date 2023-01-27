namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.Factory;

public record FactoryForModificationDto(
    Guid factoryId,
    string? name,
    Guid? companyId,
    Guid? addressId);
