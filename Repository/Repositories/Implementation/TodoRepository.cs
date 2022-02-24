using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Repositories.Abstraction;
using Repository.Repositories.Implementation.Base;

namespace Repository.Repositories.Implementation;

public class TodoRepository : Repository<Todo>, ITodoRepository
{
    public TodoRepository(TodoContext context, ILogger logger) : base(context, logger)
    {
    }

    public async Task<IEnumerable<Todo>> GetByUserAsync(User user)
    {
        return await _dbSet.Include(i => i.User)
            .Where(i => i.UserId == user.Id && !i.IsDeleted)
            .ToListAsync();
    }

    public override async Task<bool> Delete(Todo entity)
    {
        var exist = await _dbSet.FirstOrDefaultAsync(i => i.Id == i.Id);
        if (exist == null)
            return false;
        exist.IsDeleted = true;
        return true;
    }

    public override async Task<IEnumerable<Todo>> GetAllAsync()
    {
        return await _dbSet.Include(i => i.User)
            .Where(i => !i.IsDeleted).ToListAsync();
    }

    public override async Task<Todo> GetByIdAsync(object id)
    {
        return await _dbSet.Include(i => i.UserId)
            .FirstOrDefaultAsync(i => i.Id == (int) id && !i.IsDeleted);
    }
}