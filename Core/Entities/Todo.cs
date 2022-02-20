using Core.Entities.Abstraction;

namespace Core.Entities;

public class Todo : IEntity, ITiming
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;

    public bool IsCompleted { get; set; } = false;
    public bool IsDeleted { get; set; } = false;

    public string UserId { get; set; } = string.Empty;
    public virtual User User { get; set; } = new User();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}