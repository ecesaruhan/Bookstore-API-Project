using System;
using AutoMapper;
using BookStore.Business.Abstract;
using BookStore.Data.Abstract;
using BookStore.Shared.DTOs;
using BookStore.Shared.ResponseDTOs;

namespace BookStore.Business.Concrete
{
	public class ProductManager:IProductService
	{
		private readonly IMapper _mapper;

		private readonly IProductRepository _repository;

        public ProductManager(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<Response<ProductDTO>> CreateAsync(AddProductDTO addProductDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDTO>>> GetAllProductsWithCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ProductDTO>>> GetProductsByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ProductDTO>> GetProductWithCategoriesAsync()
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

        public Task<Response<ProductDTO>> UpdateAsync(EditProductDTO editProductDTO)
        {
            throw new NotImplementedException();
        }
    }
}

