using System;
using Ardalis.GuardClauses;
using Zafiro.Application.Interfaces;
using Zafiro.Domain.Entities;
using Zafiro.Domain.Interfaces.Repositories;

namespace Zafiro.Application.Services;

public class SchemaService : IBaseService<Schema, Guid>
{
    private readonly IBaseRepository<Schema, Guid> repSchema;
    private readonly IBaseRepository<Field, Guid> repField;
    public SchemaService(
        IBaseRepository<Schema, Guid> _repSchema,
        IBaseRepository<Field, Guid> _repField
        )
    {
        repSchema = _repSchema;
        repField = _repField;
    }

    public Schema Add(Schema entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Schema results = repSchema.Add(entity);

        entity.Fields.ForEach(field =>
        {
            field.SchemaId = results.Id;
            repField.Add(field);
        });

        repSchema.SaveAll();

        return results;
    }

    public Schema Edit(Schema entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Schema results = repSchema.Edit(entity);
        repSchema.SaveAll();

        return results;
    }

    public void Delete(Guid entityId)
    {
        repSchema.Delete(entityId);
        repSchema.SaveAll();
    }

    public Schema Find(Guid entityId)
    {
        return repSchema.Find(entityId);
    }

    public List<Schema> List()
    {
        return repSchema.List();
    }

}

