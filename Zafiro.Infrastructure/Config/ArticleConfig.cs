using Zafiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Zafiro.Infrastructure.Config;

public class ArticleConfig : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(p => p.Title)
            .HasMaxLength(255)
            .IsRequired();
        builder.Property(p => p.Slug)
            .HasMaxLength(512)
            .IsRequired();
    }
}

