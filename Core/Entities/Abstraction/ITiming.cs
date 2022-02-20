namespace Core.Entities.Abstraction;

public interface ITiming
{
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}