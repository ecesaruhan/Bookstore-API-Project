using System;
using AutoMapper;
using BookStore.Business.Abstract;
using BookStore.Data.Abstract;
using BookStore.Shared.DTOs;
using BookStore.Shared.ResponseDTOs;

namespace BookStore.Business.Concrete
{
	public class CategoryManager:ICategoryService
	{
		private readonly IMapper _mapper;

		private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<CategoryDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDTO>>> GetIsActiveCategories(bool isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<CategoryDTO>>> GetIsDeletedCategories(bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> SoftDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO)
        {
            throw new NotImplementedException();
        }
    }
}

