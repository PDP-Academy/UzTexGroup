namespace UzTexGroup.Application.Services.Foundations.Factory
{
    public interface IFactoryService
    {
        ValueTask<Domain.Entities.Factory> CreateFactoryAsync(Domain.Entities.Factory Factory);
        IQueryable<Domain.Entities.Factory> RetrieveFactorys();
        ValueTask<Domain.Entities.Factory> RetrieveFactoryByIdAsync(Guid FactoryId);
        ValueTask<Domain.Entities.Factory> ModifyFactoryAsync(Domain.Entities.Factory Factory);
        ValueTask<Domain.Entities.Factory> RemoveFactoryAsync(Domain.Entities.Factory Factory);
        ValueTask<Domain.Entities.Factory> RetrieveByIdWithDetailsAync(Guid FactoryId);
    }
}
