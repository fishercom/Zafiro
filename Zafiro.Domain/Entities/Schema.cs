namespace Zafiro.Domain.Entities;

public class Schema : BaseEntity
{
    public Guid SiteId { get; set; }
    public Guid? ParentId { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public enum PostType
    {
        Page,
        Post,
        Form,
        Product
    }

    public Schema? Parent { get; set; }
    public Site Site { get; set; }

    public List<Article> Articles { get; set; }
    public List<Field> Fields { get; set; }

}
