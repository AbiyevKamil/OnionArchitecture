using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace Repository.Repositories.Abstraction;

public interface IRoleRepository
{
    Task<IdentityResult> CreateAsync(Role role);
}