using System;
namespace BookStore.Shared.DTOs
{
	public class InProductDTO
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subjects { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Url { get; set; }
    }
}

