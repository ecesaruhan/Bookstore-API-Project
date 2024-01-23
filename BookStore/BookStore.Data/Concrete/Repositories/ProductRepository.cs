using System;
using BookStore.Data.Abstract;
using BookStore.Data.Concrete.Contexts;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(BookStoreDbContext _context) : base(_context)
        {
        }

        private BookStoreDbContext BookStoreDbContext
        {
            get { return _dbContext as BookStoreDbContext; }
        }

        public async Task<List<Product>> GetAllProductsWithCategoriesAsync()
        {
            List<Product> products = await BookStoreDbContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToListAsync();
            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            List<Product> products = await BookStoreDbContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categoryId))
                .ToListAsync();
            return products;
        }

        public async Task<Product> GetProductWithCategoriesAsync(int id)
        {
            Product product = await BookStoreDbContext
                .Products
                .Where(p => p.Id == id)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .SingleOrDefaultAsync();
            return product;
        }
    }
}

