namespace Zafiro.Domain.Entities;

public class Article : BaseEntity
{
    public Guid? ParentId { get; set; }
    public Guid SchemaId { get; set; }
    public Guid LangId { get; set; }

    public required string Title { get; set; }
    public string? Content { get; set; }
    public string? Metadata { get; set; }
    public required string Slug { get; set; }
    public bool? Visible { get; set; }

    public Article? Parent { get; set; }
    public required Schema Schema { get; set; }
    public required Lang Lang { get; set; }

    public List<Article>? Children { get; set; }
}
