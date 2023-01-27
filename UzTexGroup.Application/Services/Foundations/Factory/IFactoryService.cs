using UzTexGroup.Domain.Entities;

namespace UzTexGroup.Application.Services.Foundations
{
    public interface IFactoryService
    {
        ValueTask<Factory> CreateFactoryAsync(Factory Factory);
        IQueryable<Factory> RetrieveFactorys();
        ValueTask<Factory> RetrieveFactoryByIdAsync(Guid FactoryId);
        ValueTask<Factory> ModifyFactoryAsync(Factory Factory);
        ValueTask<Factory> RemoveFactoryAsync(Factory Factory);
        ValueTask<Factory> RetrieveByIdWithDetailsAync(Guid FactoryId);
    }
}
