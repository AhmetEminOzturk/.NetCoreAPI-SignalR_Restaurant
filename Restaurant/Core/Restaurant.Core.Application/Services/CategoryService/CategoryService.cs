using AutoMapper;
using Restaurant.Core.Application.Dtos.Category.Requests;
using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Application.Services.CategoryService;
using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.CategoryRepository;
using Restaurant.Infrastructure.Persistence.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.CategoryService
{
    public class CategoryService : GenericService<Category, GenericCategoryDto>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, mapper)
        {
            _categoryRepository = categoryRepository;
        }

        public void TAdd(CreateCategoryRequest createCategoryRequest)
        {
            var newEntity = _mapper.Map<Category>(createCategoryRequest);
            _categoryRepository.Add(newEntity);
        }
    }
}
