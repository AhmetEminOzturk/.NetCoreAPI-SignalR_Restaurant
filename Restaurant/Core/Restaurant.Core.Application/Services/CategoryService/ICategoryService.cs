﻿using Restaurant.Core.Application.Dtos.Category;
using Restaurant.Core.Application.Dtos.Category.Requests;
using Restaurant.Core.Application.Dtos.Testimonial.Requests;
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
        void TAdd(CreateCategoryRequest createCategoryRequest);
    }
}
