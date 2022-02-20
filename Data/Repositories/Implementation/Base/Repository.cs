using Core.Entities.Abstraction;
using Data.Contexts;
using Data.Repositories.Abstraction.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data.Repositories.Implementation.Base;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly TodoContext _context;
    protected readonly ILogger _logger;
    protected readonly DbSet<TEntity> _dbSet;

    public Repository(TodoContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
        _dbSet = _context.Set<TEntity>();
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<TEntity> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync((int) id);
    }

    public virtual async Task<bool> Add(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
        return true;
    }

    public virtual async Task<bool> Update(TEntity entity)
    {
        var exist = await _dbSet.FirstOrDefaultAsync(i => i.Id == entity.Id);
        if (exist != null)
            return false;
        _dbSet.Update(entity);
        return true;
    }

    public virtual async Task<bool> Delete(TEntity entity)
    {
        var exist = await _dbSet.FirstOrDefaultAsync(i => i.Id == entity.Id);
        if (exist != null)
            return false;
        _dbSet.Remove(entity);
        return true;
    }
}