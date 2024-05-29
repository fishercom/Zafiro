namespace Zafiro.Domain.Entities;

public class Form : BaseEntity
{
    public Guid SiteId { get; set; }
    public required string Name { get; set; }
    public required string Slug { get; set; }

    public required Site Site { get; set; }
}
