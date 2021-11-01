using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Common.DAL.Repository
{
    public interface IQueryRepository<TEntity> : IDisposable where TEntity : class
    {
        bool Any();
        bool Any(Expression<Func<TEntity, bool>> expression);
        Task<bool> AnyAsync();
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        int Count(Expression<Func<TEntity, bool>> expression);
        int Count();
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> expression);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        TEntity GetById(params object[] keyValues);
        Task<TEntity> GetByIdAsync(params object[] keyValues);
    }
}
