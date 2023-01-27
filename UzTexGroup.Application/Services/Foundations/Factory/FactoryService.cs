using UzTexGroup.Infrastructure.Repositories;

namespace UzTexGroup.Application.Services.Foundations.Factory
{
    public class FactoryService : IFactoryService
    {
        private readonly IFactoryReposytory factoryRepository;

        public FactoryService(IFactoryReposytory factoryRepository)
        {
            this.factoryRepository = factoryRepository;
        }

        public async ValueTask<Domain.Entities.Factory> CreateFactoryAsync(Domain.Entities.Factory factory)
        {
           return await factoryRepository.InsertAsync(factory);
        }

        public async ValueTask<Domain.Entities.Factory> ModifyFactoryAsync(Domain.Entities.Factory factory)
        {
           return await factoryRepository.UpdateAsync(factory);
        }

        public async ValueTask<Domain.Entities.Factory> RemoveFactoryAsync(Domain.Entities.Factory factory)
        {
            return await factoryRepository.DeleteAsync(factory);
        }

        public async ValueTask<Domain.Entities.Factory> RetrieveByIdWithDetailsAync(Guid FactoryId)
        {
            return await factoryRepository.SelectByIdWithDetailsAync(
                factory => factory.Id == FactoryId,
                new string[] {"FactoryImages","Jobs"});
        }

        public async ValueTask<Domain.Entities.Factory> RetrieveFactoryByIdAsync(Guid FactoryId)
        {
            return await factoryRepository.SelectByIdAsync(FactoryId);
        }

        public IQueryable<Domain.Entities.Factory> RetrieveFactorys()
        {
            return factoryRepository.SelectAll();
        }
    }
}
