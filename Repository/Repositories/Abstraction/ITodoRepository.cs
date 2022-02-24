using DataAccess.Entities;
using Repository.Repositories.Abstraction.Base;

namespace Repository.Repositories.Abstraction;

public interface ITodoRepository : IRepository<Todo>
{
    Task<IEnumerable<Todo>> GetByUserAsync(User user);
}