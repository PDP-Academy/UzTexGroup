using UzTexGroup.Application.Services.Processings.DataTransferObjects.Factory;

namespace UzTexGroup.Application.Services.Processings.DataTransferObjects.Job;

public record JobDto(
    Guid jobId,
    string jobName,
    string workTime,
    decimal salary,
    string requirement,
    Guid factoryId,
    FactoryDto factory);
