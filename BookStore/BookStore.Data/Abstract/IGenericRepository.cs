using System;
using System.Linq.Expressions;

namespace BookStore.Data.Abstract
{
	public interface IGenericRepository<TEntity> where TEntity : class
	{
		Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> options = null);

        Task<TEntity> GetByIdAsync(int id);

		Task<TEntity> CreateAsync(TEntity entity);

		Task UpdateAsync(TEntity entity);
		Task HardDeleteAsync(TEntity entity);
	}
}

