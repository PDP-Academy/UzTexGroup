using UzTexGroup.Infrastructure.Repositories;
using UzTexGroup.Domain.Entities;
namespace UzTexGroup.Application.Services.Foundations;

public class FactoryService : IFactoryService
{
    private readonly IFactoryReposytory factoryRepository;

    public FactoryService(IFactoryReposytory factoryRepository)
    {
        this.factoryRepository = factoryRepository;
    }

    public async ValueTask<Factory> CreateFactoryAsync(Factory factory)
    {
       return await factoryRepository.InsertAsync(factory);
    }

    public async ValueTask<Factory> ModifyFactoryAsync(Factory factory)
    {
       return await factoryRepository.UpdateAsync(factory);
    }

    public async ValueTask<Factory> RemoveFactoryAsync(Factory factory)
    {
        return await factoryRepository.DeleteAsync(factory);
    }

    public async ValueTask<Factory> RetrieveByIdWithDetailsAync(Guid FactoryId)
    {
        return await factoryRepository.SelectByIdWithDetailsAync(
            factory => factory.Id == FactoryId,
            new string[] {"FactoryImages","Jobs"});
    }

    public async ValueTask<Factory> RetrieveFactoryByIdAsync(Guid FactoryId)
    {
        return await factoryRepository.SelectByIdAsync(FactoryId);
    }

    public IQueryable<Factory> RetrieveFactorys()
    {
        return factoryRepository.SelectAll();
    }
}
