using System.Collections.ObjectModel;
using Core.Entities.Abstraction;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public class User : IdentityUser, ITiming
{
    public ICollection<Todo> Todos { get; set; } = new Collection<Todo>();

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}