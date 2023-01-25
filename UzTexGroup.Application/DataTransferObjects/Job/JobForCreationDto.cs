namespace UzTexGroup.Application.DataTransferObjects.Job;

public record JobForCreationDto(
    string jobName,
    string workTime,
    decimal salary,
    string requirement,
    Guid factoryId);

