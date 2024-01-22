using System;
using BookStore.Entity.Abstract;

namespace BookStore.Entity.Concrete
{
	public class Product:BaseEntity
	{
		public string Subjects { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public bool IsHome { get; set; }

		public List<ProductCategory> ProductCategories { get; set; }
	}
}

