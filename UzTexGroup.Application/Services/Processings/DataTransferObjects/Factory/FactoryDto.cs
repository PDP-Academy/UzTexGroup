using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.Factory;

public record FactoryDto(
    string name,
    Guid companyId,
    Guid addressId,
    AddressDto address,
    FactoryImagesDto? factoryImagesDto);

