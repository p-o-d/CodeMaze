using System;
using System.Linq;
using System.Linq.Expressions;
using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected RepositoryContext RepositoryContext { get; }

        public RepositoryBase(RepositoryContext context)
        {
            RepositoryContext = context;
        }

        public IQueryable<TEntity> GetAll(bool trackChanges)
        {
            return trackChanges
                ? RepositoryContext.Set<TEntity>()
                : RepositoryContext.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges)
        {
            return trackChanges
                ? RepositoryContext.Set<TEntity>().Where(expression)
                : RepositoryContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public void Create(TEntity entity)
        {
            RepositoryContext.Add(entity);
        }

        public void Update(TEntity entity)
        {
            RepositoryContext.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            RepositoryContext.Remove(entity);
        }
    }
}
