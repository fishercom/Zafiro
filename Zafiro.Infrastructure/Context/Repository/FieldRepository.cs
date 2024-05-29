using Zafiro.Domain.Entities;
using Zafiro.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Zafiro.Infrastructure.Context.Repository;

public class FieldRepository : IBaseRepository<Field, Guid>
{
    private readonly CmsContext _db;

    public FieldRepository(CmsContext db)
    {
        _db = db;
    }

    public Field Add(Field entity)
    {
        _db.Field.Add(entity);
        return entity;
    }

    public void Delete(Guid entityId)
    {
        var item = Find(entityId);
        _db.Field.Remove(item);
    }

    public Field Edit(Field entity)
    {
        var item = Find(entity.Id);
        item.SchemaId = entity.SchemaId;
        item.Name = entity.Name;
        item.Slug = entity.Slug;
        item.Attributes = entity.Attributes;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Field Find(Guid entityId)
    {
        var item = _db.Field.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Field> List()
    {
        var list = _db.Field.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
