namespace Zafiro.Domain.Entities;

public class Schema : BaseEntity
{
    public Guid SiteId { get; set; }
    public Guid? ParentId { get; set; }
    public required string Name { get; set; }
    public required string Slug { get; set; }
    public enum PostType
    {
        Page,
        Post,
        Form,
        Product
    }

    public Schema? Parent { get; set; }
    public required Site Site { get; set; }

    public List<Article>? Articles { get; set; }
    public List<Field>? Fields { get; set; }

}
