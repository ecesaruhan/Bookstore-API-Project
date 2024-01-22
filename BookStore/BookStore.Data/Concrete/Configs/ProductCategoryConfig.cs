using System;
using BookStore.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Concrete.Configs
{
	public class ProductCategoryConfig:IEntityTypeConfiguration<ProductCategory>
	{
		public void Configure(EntityTypeBuilder<ProductCategory> builder)
		{
            builder.HasKey(x => new
            { x.ProductId, x.CategoryId });
          
            builder.HasData(
                new ProductCategory { ProductId = 1, CategoryId = 1 },
                new ProductCategory { ProductId = 1, CategoryId = 6 },

                new ProductCategory { ProductId = 2, CategoryId = 1 },
                new ProductCategory { ProductId = 2, CategoryId = 6 },

                new ProductCategory { ProductId = 3, CategoryId = 1 },
                new ProductCategory { ProductId = 3, CategoryId = 6 },

                new ProductCategory { ProductId = 4, CategoryId = 2 },

                new ProductCategory { ProductId = 5, CategoryId = 2 },

                new ProductCategory { ProductId = 6, CategoryId = 2 },

                new ProductCategory { ProductId = 7, CategoryId = 3 },

                new ProductCategory { ProductId = 8, CategoryId = 3 },

                new ProductCategory { ProductId = 9, CategoryId = 3 },

                new ProductCategory { ProductId = 10, CategoryId = 4 },

                new ProductCategory { ProductId = 11, CategoryId = 1 },
                new ProductCategory { ProductId = 11, CategoryId = 4 },

                new ProductCategory { ProductId = 12, CategoryId = 5 },

                new ProductCategory { ProductId = 13, CategoryId = 5 },

                new ProductCategory { ProductId = 14, CategoryId = 3 },
                new ProductCategory { ProductId = 14, CategoryId = 6 },

                new ProductCategory { ProductId = 15, CategoryId = 5 },
                new ProductCategory { ProductId = 15, CategoryId = 6 },

                new ProductCategory { ProductId = 16, CategoryId = 5 },
                new ProductCategory { ProductId = 16, CategoryId = 6 }

                );
        }
	}
}

