using System;
using Ardalis.GuardClauses;
using Zafiro.Application.Interfaces;
using Zafiro.Domain.Entities;
using Zafiro.Domain.Interfaces.Repositories;

namespace Zafiro.Application.Services;

public class ArticleService : IBaseService<Article, Guid>
{
    private readonly IBaseRepository<Article, Guid> repArticle;
    public ArticleService(
        IBaseRepository<Article, Guid> _repArticle
        )
    {
        repArticle = _repArticle;
    }

    public Article Add(Article entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Article results = repArticle.Add(entity);

        repArticle.SaveAll();

        return results;
    }

    public Article Edit(Article entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Article results = repArticle.Edit(entity);
        repArticle.SaveAll();

        return results;
    }

    public void Delete(Guid entityId)
    {
        repArticle.Delete(entityId);
        repArticle.SaveAll();
    }

    public Article Find(Guid entityId)
    {
        return repArticle.Find(entityId);
    }

    public List<Article> List()
    {
        return repArticle.List();
    }

}

