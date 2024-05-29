using Zafiro.Domain.Entities;
using Zafiro.Infrastructure.Config;

using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace Zafiro.Infrastructure.Context;

public class CmsContext : DbContext
{
    public DbSet<Site> Site { set; get; }
    public DbSet<Form> Form { set; get; }
    public DbSet<Schema> Schema { set; get; }
    public DbSet<Field> Field { set; get; }
    public DbSet<Lang> Lang { set; get; }
    public DbSet<Article> Article { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySQL("server=localhost;database=Zafiro;user=root;password=asixon");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new SiteConfig());
        builder.ApplyConfiguration(new FormConfig());
        builder.ApplyConfiguration(new SchemaConfig());
        builder.ApplyConfiguration(new FieldConfig());
        builder.ApplyConfiguration(new LangConfig());
        builder.ApplyConfiguration(new ArticleConfig());
    }
}
