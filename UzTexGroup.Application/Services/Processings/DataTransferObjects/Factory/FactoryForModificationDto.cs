namespace UzTexGroup.Application.DataTransferObjects.Factory;

public record FactoryForModificationDto(
    Guid factoryId,
    string? name,
    Guid? companyId,
    Guid? addressId);
