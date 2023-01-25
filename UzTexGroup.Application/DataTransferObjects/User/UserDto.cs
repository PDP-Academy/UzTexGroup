namespace UzTexGroup.Application.DataTransferObjects;

public record UserDto(
    Guid id,
    string fullName,
    string email);