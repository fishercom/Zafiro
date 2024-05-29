namespace Zafiro.Domain.Interfaces;

public interface IDelete<TEntityId>
{
    void Delete(TEntityId entityId);
}

