using Core.Entities.Abstraction;

namespace Data.Repositories.Abstraction.Base;

public interface IRepository<TEntity> where TEntity : class, IEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetByIdAsync(object id);

    Task<bool> Add(TEntity entity);

    Task<bool> Update(TEntity entity);

    Task<bool> Delete(TEntity entity);
}