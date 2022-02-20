using Core.Entities;
using Data.Repositories.Abstraction.Base;

namespace Data.Repositories.Abstraction;

public interface ITodoRepository : IRepository<Todo>
{
    Task<IEnumerable<Todo>> GetByUserAsync(User user);
}