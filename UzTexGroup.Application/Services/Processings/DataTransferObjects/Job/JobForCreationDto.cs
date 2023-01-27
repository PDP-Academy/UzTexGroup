namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.Job;

public record JobForCreationDto(
    string jobName,
    string workTime,
    decimal salary,
    string requirement,
    Guid factoryId);

