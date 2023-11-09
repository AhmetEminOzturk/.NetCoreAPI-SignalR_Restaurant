using AutoMapper;
using Restaurant.Core.Application.Dtos.Category.Requests;
using Restaurant.Core.Application.Dtos.Category.Responses;
using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Mappings
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, GenericCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
            CreateMap<Category, DisplayCategoryResponse>().ReverseMap();
            CreateMap<Category, GetCategoryResponse>().ReverseMap();
        }
    }
}
