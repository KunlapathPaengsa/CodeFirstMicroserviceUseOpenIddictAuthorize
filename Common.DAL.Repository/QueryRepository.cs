using Common.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.DAL.Repository
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity>, IDisposable
    where TEntity : class
    {
        protected IDbContext _dbContext;
        protected DbSet<TEntity> _dbSet;

        public QueryRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = this._dbContext.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> expression) => this._dbSet.Where<TEntity>(expression);

        public virtual Task<List<TEntity>> FindByAsync(
          Expression<Func<TEntity, bool>> expression)
        {
            return this._dbSet.Where<TEntity>(expression).ToListAsync<TEntity>();
        }

        public virtual TEntity GetById(params object[] keyValues) => this._dbSet.Find(keyValues);

        public virtual Task<TEntity> GetByIdAsync(params object[] keyValues) => this._dbSet.FindAsync(keyValues).AsTask();

        public virtual int Count(Expression<Func<TEntity, bool>> expression) => this._dbSet.Count<TEntity>(expression);

        public virtual int Count() => this._dbSet.Count<TEntity>();

        public virtual Task<int> CountAsync() => this._dbSet.CountAsync<TEntity>();

        public virtual Task<int> CountAsync(Expression<Func<TEntity, bool>> expression) => this._dbSet.CountAsync<TEntity>(expression);

        public virtual bool Any() => this._dbSet.Any<TEntity>();

        public virtual bool Any(Expression<Func<TEntity, bool>> expression) => this._dbSet.Any<TEntity>(expression);

        public virtual Task<bool> AnyAsync() => this._dbSet.AnyAsync<TEntity>();

        public virtual Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression) => this._dbSet.AnyAsync<TEntity>(expression);

        public virtual Task<List<TEntity>> GetAllAsync() => this._dbSet.ToListAsync<TEntity>();

        public virtual IQueryable<TEntity> GetAll() => this._dbSet.AsQueryable();

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression) => this._dbSet.FirstOrDefault<TEntity>(expression);

        public virtual Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression) => this._dbSet.FirstOrDefaultAsync<TEntity>(expression);

        public virtual void Dispose()
        {
            if (this._dbContext == null)
                return;
            this._dbContext.Dispose();
        }
    }
}
