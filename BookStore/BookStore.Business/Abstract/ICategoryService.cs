using System;
using BookStore.Shared.DTOs;
using BookStore.Shared.ResponseDTOs;

namespace BookStore.Business.Abstract
{
	public interface ICategoryService
	{
        #region Generic

        Task<Response<List<CategoryDTO>>> GetAllAsync();

        Task<Response<CategoryDTO>> GetByIdAsync(int id);

        Task<Response<CategoryDTO>> CreateAsync(AddCategoryDTO addCategoryDTO);

        Task<Response<CategoryDTO>> UpdateAsync(EditCategoryDTO editCategoryDTO);

        Task<Response<NoContent>> HardDeleteAsync(int id);

        Task<Response<NoContent>> SoftDeleteAsync(int id);


        #endregion

        #region Category

        Task<Response<List<CategoryDTO>>> GetAllCategoriesWithProductsAsync();

        Task<Response<List<CategoryDTO>>> GetIsDeletedCategories(bool isDeleted = false);

        Task<Response<List<CategoryDTO>>> GetIsActiveCategories(bool isActive = true);

        #endregion
    }
}

