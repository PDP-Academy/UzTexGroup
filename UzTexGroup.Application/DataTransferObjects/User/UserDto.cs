namespace UzTexGroup.Application.DataTransferObjects;

public record UserDto(
    Guid Id,
    string fullName,
    string email);