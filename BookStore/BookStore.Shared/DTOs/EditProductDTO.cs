using System;
namespace BookStore.Shared.DTOs
{
	public class EditProductDTO
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subjects { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime ModifiedDate { get; set; }

        public List<InCategoryDTO> CategoryList { get; set; }
    }
}

