using Restaurant.Core.Domain.Entities;
using Restaurant.Infrastructure.Persistence.Repositories.CategoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void TAdd(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryRepository.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryRepository.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}
