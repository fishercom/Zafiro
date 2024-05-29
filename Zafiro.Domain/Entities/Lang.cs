namespace Zafiro.Domain.Entities;

public class Lang : BaseEntity
{
    public required string Name { get; set; }
    public required string Slug { get; set; }
}
