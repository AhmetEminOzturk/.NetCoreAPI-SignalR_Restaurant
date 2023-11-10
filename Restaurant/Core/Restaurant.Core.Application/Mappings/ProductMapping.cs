using AutoMapper;
using Restaurant.Core.Application.Dtos.Product.Requests;
using Restaurant.Core.Application.Dtos.Product.Responses;
using Restaurant.Core.Application.Dtos.Product;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, GenericProductDto>().ReverseMap();
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, UpdateProductRequest>().ReverseMap();
            CreateMap<Product, DisplayProductResponse>().ReverseMap();
            CreateMap<Product, GetProductResponse>().ReverseMap();
            CreateMap<Product, DisplayProductsWithCategoriesResponse>().ReverseMap();
        }
    }
}
