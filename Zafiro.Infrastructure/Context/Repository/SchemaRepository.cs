using Zafiro.Domain.Entities;
using Zafiro.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Zafiro.Infrastructure.Context.Repository;

public class SchemaRepository : IBaseRepository<Schema, Guid>
{
    private readonly CmsContext _db;

    public SchemaRepository(CmsContext db)
    {
        _db = db;
    }

    public Schema Add(Schema entity)
    {
        _db.Schema.Add(entity);
        return entity;
    }

    public void Delete(Guid entityId)
    {
        var item = Find(entityId);
        _db.Schema.Remove(item);
    }

    public Schema Edit(Schema entity)
    {
        var item = Find(entity.Id);
        item.ParentId = entity.ParentId;
        item.SiteId = entity.SiteId;
        item.Name = entity.Name;
        item.Slug = entity.Slug;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Schema Find(Guid entityId)
    {
        var item = _db.Schema.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Schema> List()
    {
        var list = _db.Schema.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}