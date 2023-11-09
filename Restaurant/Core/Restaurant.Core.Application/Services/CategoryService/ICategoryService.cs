using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Application.Services.CategoryService
{
    public interface ICategoryService : IGenericService<Category , GenericCategoryDto>
    {
    }
}
