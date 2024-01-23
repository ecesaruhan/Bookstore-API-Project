using System;
using BookStore.Data.Abstract;
using BookStore.Data.Concrete.Contexts;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookStoreDbContext _context) : base(_context)
        {

        }

        private BookStoreDbContext BookStoreDbContext
        {
            get { return _dbContext as BookStoreDbContext; }
        }



        public Task<List<Category>> GetAllCategoriesActiveDeletedAsync(bool? isActive = null, bool? isDeleted = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllCategoriesWithProductsAsync()
        {
            List<Category> categories = await BookStoreDbContext
                .Categories
                .Include(c => c.ProductCategories)
                .ThenInclude(pc => pc.Product)
                .ToListAsync();
            return categories;
                
        }

        public Task<Category> GetCategoryWithProductsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

