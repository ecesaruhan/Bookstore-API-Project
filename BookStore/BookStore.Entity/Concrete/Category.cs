using System;
using BookStore.Entity.Abstract;

namespace BookStore.Entity.Concrete
{
	public class Category:BaseEntity
	{
		public string Description { get; set; }

		public List<ProductCategory> ProductCategories { get; set; }
	}
}

