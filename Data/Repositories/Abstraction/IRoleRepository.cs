using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Data.Repositories.Abstraction;

public interface IRoleRepository
{
    Task<IdentityResult> CreateAsync(Role role);
}