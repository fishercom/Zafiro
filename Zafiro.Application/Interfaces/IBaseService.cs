using System;
using Zafiro.Domain.Interfaces;
using Zafiro.Domain.Interfaces.Repositories;

namespace Zafiro.Application.Interfaces;

public interface IBaseService<TEntity, TEntityId>
    : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntityId>, IList<TEntity, TEntityId>
{

}

