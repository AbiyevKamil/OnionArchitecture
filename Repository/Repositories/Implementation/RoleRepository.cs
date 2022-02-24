using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Repository.Repositories.Abstraction;

namespace Repository.Repositories.Implementation;

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