using System;
using AutoMapper;
using BookStore.Entity.Concrete;
using BookStore.Shared.DTOs;

namespace BookStore.Business.Mappings
{
	public class GeneralMappingProfile:Profile
	{
		public GeneralMappingProfile()
		{
			CreateMap<Category, InCategoryDTO>().ReverseMap();

			CreateMap<Category, AddCategoryDTO>().ReverseMap();

            CreateMap<Category, EditCategoryDTO>().ReverseMap();


            CreateMap<Category, CategoryDTO>()
				.ForMember(cdto=>cdto.ProductList, options=>options.MapFrom(c=>c.ProductCategories.Select(pc=>pc.Product)))
				.ReverseMap();



            CreateMap<Product, InProductDTO>().ReverseMap();

			CreateMap<Product, AddProductDTO>().ReverseMap();

            CreateMap<Product, EditProductDTO>()
				.ForMember(pdto=>pdto.CategoryList, options=>options.MapFrom(p=>p.ProductCategories.Select(pc=>pc.Category)))
				.ReverseMap();

            CreateMap<Product, ProductDTO>()
				.ForMember(pdto=>pdto.CategoryList, options=>options.MapFrom(p=>p.ProductCategories.Select(pc=>pc.Category)))
				.ReverseMap();

		}
	
	}
}

