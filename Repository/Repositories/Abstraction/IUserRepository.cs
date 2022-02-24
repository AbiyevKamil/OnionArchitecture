using System.Security.Claims;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace Repository.Repositories.Abstraction;

public interface IUserRepository
{
    Task<IdentityResult> CreateAsync(User user);
    Task<User> FindUserByUserNameAsync(string username);
    Task<User> FindUserByEmailNameAsync(string email);
    Task<User> FindUserByClaimsNameAsync(ClaimsPrincipal claims);
    Task<User> FindUserByIdNameAsync(string id);
    Task<bool> CheckPasswordAsync(User user, string password);
    Task<bool> CheckIsInRoleAsync(User user, string rolename);
    Task<IList<string>> GetUserRoles(User user);
}