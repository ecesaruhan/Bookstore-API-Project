using System;
using BookStore.Shared.DTOs;
using BookStore.Shared.ResponseDTOs;

namespace BookStore.Business.Abstract
{
	public interface IProductService
	{
        #region Generic

        Task<Response<List<ProductDTO>>> GetAllAsync();

        Task<Response<ProductDTO>> GetByIdAsync(int id);

        Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO);

        Task<Response<ProductDTO>> UpdateAsync(EditProductDTO editProductDTO);

        Task<Response<NoContent>> HardDeleteAsync(int id);

        Task<Response<NoContent>> SoftDeleteAsync(int id);


        #endregion

        #region Product

        Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync();

        Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId);

        Task<Response<ProductDTO>> GetProductWithCategoriesAsync();

        #endregion
    }
}

