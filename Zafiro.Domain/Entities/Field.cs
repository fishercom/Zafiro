namespace Zafiro.Domain.Entities;

public class Field : BaseEntity
{
    public Guid SchemaId { get; set; }

    public required string Name { get; set; } = string.Empty;
    public string? Attributes { get; set; } = string.Empty;
    public required string Slug { get; set; }
    public enum FieldType {
        Text,
        Numeric,
        Date,
        Email,
        Select,
        Radio,
        Checkbox,
        Url,
        Html,
    }

    public required Schema Schema { get; set; }

}
