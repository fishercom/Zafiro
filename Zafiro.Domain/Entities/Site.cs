namespace Zafiro.Domain.Entities;

public class Site : BaseEntity
{
    public required string Name { get; set; }
    public string? Url { get; set; }
}
