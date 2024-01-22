using System;
using BookStore.Data.Concrete.Configs;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Concrete.Contexts
{
	public class BookStoreDbContext:DbContext
	{
		public BookStoreDbContext(DbContextOptions options) : base(options) { }

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products{ get; set; }

		public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);

			base.OnModelCreating(modelBuilder);
        }
    }
}

