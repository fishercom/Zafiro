namespace Zafiro.Domain.Entities;

public class Form : BaseEntity
{
    public Guid SiteId { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }

    public Site Site { get; set; }
}
