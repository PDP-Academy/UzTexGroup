namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.Job;

public record JobModifucationDto(
    Guid jobId,
    string? jobName,
    string? workTime,
    decimal? salary,
    string? requirement,
    Guid? factoryId);
