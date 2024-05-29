using Zafiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Zafiro.Infrastructure.Config;

public class FieldConfig : IEntityTypeConfiguration<Field>
{
    public void Configure(EntityTypeBuilder<Field> builder)
    {
        builder.HasIndex(c => c.SchemaId);

        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(p => p.Slug)
            .HasMaxLength(100)
            .IsRequired();
    }
}

