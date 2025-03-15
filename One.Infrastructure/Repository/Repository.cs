using Microsoft.EntityFrameworkCore;
using One.Domain.Interfaces;
using One.Infrastructure.Data;
using System.Linq.Expressions;

namespace One.Infrastructure.Repository
{
    public class Repository<T>(OneDBContext context) : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet = context.Set<T>();

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync([id]);
        }

        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync([id]);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
