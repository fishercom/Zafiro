using Zafiro.Domain.Entities;
using Zafiro.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Zafiro.Infrastructure.Context.Repository;

public class ArticleRepository : IBaseRepository<Article, Guid>
{
    private readonly CmsContext _db;

    public ArticleRepository(CmsContext db)
    {
        _db = db;
    }

    public Article Add(Article entity)
    {
        _db.Article.Add(entity);
        return entity;
    }

    public void Delete(Guid entityId)
    {
        var item = Find(entityId);
        _db.Article.Remove(item);
    }

    public Article Edit(Article entity)
    {
        var item = Find(entity.Id);
        item.Title = entity.Title;
        item.Content = entity.Content;
        item.Metadata = entity.Metadata;
        item.Slug = entity.Slug;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Article Find(Guid entityId)
    {
        var item = _db.Article.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Article> List()
    {
        var list = _db.Article.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
