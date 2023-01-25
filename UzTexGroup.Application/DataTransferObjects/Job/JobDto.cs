using UzTexGroup.Application.DataTransferObjects.Factory;

namespace UzTexGroup.Application.DataTransferObjects.Job;

public record JobDto(
    Guid jobId,
    string jobName,
    string workTime,
    decimal salary,
    string requirement,
    Guid factoryId,
    FactoryDto factory);
