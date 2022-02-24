using System.Collections.ObjectModel;
using DataAccess.Entities.Abstraction;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Entities;

public class User : IdentityUser, ITiming
{
    public ICollection<Todo> Todos { get; set; } = new Collection<Todo>();

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}