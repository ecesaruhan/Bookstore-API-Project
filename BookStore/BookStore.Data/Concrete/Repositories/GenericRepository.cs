using System;
using System.Linq.Expressions;
using BookStore.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Concrete.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        protected readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> options = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            if (options != null)
            {
                query = query.Where(options);
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            TEntity entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public async Task HardDeleteAsync(TEntity entity)
        {
            _dbContext
                 .Set<TEntity>()
                 .Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext
                .Set<TEntity>()
                .Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

