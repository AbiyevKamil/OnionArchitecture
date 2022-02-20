using System.Security.Claims;
using Core.Entities;
using Data.Contexts;
using Data.Repositories.Abstraction;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Data.Repositories.Implementation;

public class UserRepository : IUserRepository
{
    private readonly TodoContext _context;
    private readonly ILogger _logger;
    private readonly UserManager<User> _userManager;

    public UserRepository(TodoContext context, ILogger logger, UserManager<User> userManager)
    {
        _context = context;
        _logger = logger;
        _userManager = userManager;
    }


    public virtual async Task<IdentityResult> CreateAsync(User user)
    {
        return await _userManager.CreateAsync(user);
    }

    public virtual async Task<User> FindUserByUserNameAsync(string username)
    {
        return await _userManager.FindByNameAsync(username);
    }

    public virtual async Task<User> FindUserByEmailNameAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }

    public virtual async Task<User> FindUserByClaimsNameAsync(ClaimsPrincipal claims)
    {
        return await _userManager.GetUserAsync(claims);
    }

    public virtual async Task<User> FindUserByIdNameAsync(string id)
    {
        return await _userManager.FindByIdAsync(id);
    }

    public virtual async Task<bool> CheckPasswordAsync(User user, string password)
    {
        return await _userManager.CheckPasswordAsync(user, password);
    }

    public virtual async Task<bool> CheckIsInRoleAsync(User user, string rolename)
    {
        return await _userManager.IsInRoleAsync(user, rolename);
    }

    public virtual async Task<IList<string>> GetUserRoles(User user)
    {
        return await _userManager.GetRolesAsync(user);
    }
}