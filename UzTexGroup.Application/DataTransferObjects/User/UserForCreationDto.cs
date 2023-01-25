namespace UzTexGroup.Application.DataTransferObjects.User;

public record UserForCreationDto(
    string fullName,
    string email,
    string password);
