namespace Zafiro.Domain.Interfaces;

public interface IList<TEntity, TEntityId>
{
    List<TEntity> List();
    TEntity Find(TEntityId entityId);

}

