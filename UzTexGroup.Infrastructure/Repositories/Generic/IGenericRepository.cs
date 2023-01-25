using System.Linq.Expressions;

namespace UzTexGroup.Infrastructure.Repositories;

public interface IGenericRepository<TEntity, TKey>
{
    ValueTask<TEntity> InsertAsync(TEntity entity);
    ValueTask<TEntity> UpdateAsync(TEntity entity);
    IQueryable<TEntity> SelectAll();
    ValueTask<TEntity> SelectByIdAsync(TKey id);
    
    ValueTask<TEntity> SelectByIdWithDetailsAync(
        Expression<Func<TEntity, bool>> expression,
        string[] includes);

    ValueTask<TEntity> DeleteAsync(TEntity entity);
    ValueTask<int> SaveChangesAsync();
}
