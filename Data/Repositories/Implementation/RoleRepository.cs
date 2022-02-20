using Core.Entities;
using Data.Repositories.Abstraction;
using Microsoft.AspNetCore.Identity;

namespace Data.Repositories.Implementation;

public class RoleRepository : IRoleRepository
{
    private readonly RoleManager<Role> _roleManager;

    public RoleRepository(RoleManager<Role> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<IdentityResult> CreateAsync(Role role)
    {
        return await _roleManager.CreateAsync(role);
    }
}